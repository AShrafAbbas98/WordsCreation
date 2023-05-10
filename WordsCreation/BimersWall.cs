using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Document = Autodesk.Revit.DB.Document;

namespace WordsCreation
{
    internal class BimersWall
    {
        // Attribute
        private const string _familyName = "Basic Wall";
        private string _typeName = null;
        private int _thickness = 300;
        private string _MainRFTx = "7T12/m";
        private string _MainRFTy = "5T12/m";
        public Document familyDocument = null;
        // Property 
        public int Thickness { get => _thickness; set => _thickness = value; }
        public string MainRFTx { get => _MainRFTx; set => _MainRFTx = value; }
        public string MainRFTy { get => _MainRFTy; set => _MainRFTy = value; }
        string TypeName { get => _typeName; set => _typeName = value; }



        // Constructor
        public BimersWall(string typeName, int thickness, string mainRFTx, string mainRFTy)
        {
            TypeName = typeName;
            Thickness = thickness;
            MainRFTx = mainRFTx;
            MainRFTy = mainRFTy;
        }
        public BimersWall(string typeName, int thickness)
        {
            TypeName = typeName;
            Thickness = thickness;
        }
        public BimersWall()
        {
        }
        Wall wallobj = null;
        // Set new wall type to null
        WallType newWallType = null;
        Level firstLevel = null;
        double height = 0;
        public void CreateWallSymbol(Document document, int thickness, double wallHeight, XYZ startPoint, XYZ endPoint, int i)
        {
            this.Thickness = thickness;
            this.TypeName = $"W{i} {this.Thickness}mm";

            WallType checkName = new FilteredElementCollector(document)
            .OfCategory(BuiltInCategory.INVALID)
            .OfClass(typeof(WallType))
            .FirstOrDefault(w => w.Name == this.TypeName) as WallType;

            if (checkName != null)
            {
                this.TypeName = $"W{i} {this.Thickness}mm 0{i}";
            }

            // First level 
            firstLevel = HelperDb.GetFirstLevel(document);



            using (Transaction tx = new Transaction(document, "Create Wall"))
            {
                try
                {
                    tx.Start();
                    newWallType = HelperDb.CreateNewWallType(document, this.TypeName, this.Thickness, checkName);

                    // ********* PLACE WALL **********
                    // lOCATIONS
                    double x1 = UnitUtils.ConvertToInternalUnits(startPoint.X, UnitTypeId.Millimeters);
                    double y1 = UnitUtils.ConvertToInternalUnits(startPoint.Y, UnitTypeId.Millimeters);
                    double z1 = UnitUtils.ConvertToInternalUnits(startPoint.Z, UnitTypeId.Millimeters);
                    double x2 = UnitUtils.ConvertToInternalUnits(endPoint.X, UnitTypeId.Millimeters);
                    double y2 = UnitUtils.ConvertToInternalUnits(endPoint.Y, UnitTypeId.Millimeters);
                    double z2 = UnitUtils.ConvertToInternalUnits(endPoint.Z, UnitTypeId.Millimeters);

                    XYZ startPoint1 = new XYZ(x1, y1, z1);
                    XYZ endPoint1 = new XYZ(x2, y2, z2);
                    // Create lin between points
                    Line geoLine = Line.CreateBound(startPoint1, endPoint1);

                    // Set Height
                    height = UnitUtils.ConvertToInternalUnits(wallHeight, UnitTypeId.Millimeters);
                    double offset = 0;

                    // PLace Wall
                    wallobj = Wall.Create(document, geoLine, newWallType.Id, firstLevel.Id, height, offset, false, true);

                    //DeleteInstance
                    if (newWallType != null)
                    {
                        document.Delete(wallobj.Id);
                    }
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    string err = ex.Message;
                }
            }
        }

        public void CreateWallWords(Document document, UIDocument uidoc,char c, string word)
        {
            HelperDb.CreayeWord(document, uidoc, newWallType.Id, firstLevel.Id, height, c, word);
        }
        ~BimersWall() { }
    }
}
