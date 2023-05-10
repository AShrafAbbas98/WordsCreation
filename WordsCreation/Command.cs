using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Line = Autodesk.Revit.DB.Line;

namespace WordsCreation
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Get the Revit objects
            var uiApplication = commandData.Application;
            var application = uiApplication.Application;
            var document = uiApplication.ActiveUIDocument.Document;
            UIDocument uidoc = uiApplication.ActiveUIDocument;
            try
            {
                #region Walls
                BimersWall bimersWall = new BimersWall();


                // This list will be from WPF
                List<List<Object>> walls = new List<List<Object>>();

                // Wall Data
                List<Object> wallData = new List<object>
                {
                    350,
                    10000
                };
                walls.Add(wallData);

                //Start Point
                List<XYZ> wallStartPoint = new List<XYZ>();
                int x1 = 0;
                int y1 = 0;
                int z1 = 0;
                XYZ stP = new XYZ(x1, y1, z1);
                wallStartPoint.Add(stP);

                //End Point
                List<XYZ> wallEndPoint = new List<XYZ>();
                int x2 = 1000;
                int y2 = 0;
                int z2 = 0;
                XYZ endP = new XYZ(x2, y2, z2);
                wallEndPoint.Add(endP);



                for (int i = 0; i < walls.Count; i++)
                {
                    bimersWall.CreateWallSymbol(document, (int)walls[i][0], (int)walls[i][1], wallStartPoint[i], wallEndPoint[i], i + 1);
                }

                string bim = "BIM";
                string part01_DEV = "DEV";
                string part02_ELOP = "ELOP";
                string part02_MENT = "MENT";
                List<string> parts = new List<string>()
                    {
                        bim,
                        part01_DEV,
                        part02_ELOP,
                        part02_MENT,
                    };
                foreach (string part in parts)
                {
                    foreach (char char_BIM in part)
                    {
                        bimersWall.CreateWallWords(document, uidoc,char_BIM, part);

                    }
                }
                #endregion
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Error", ex.Message);
                return Result.Failed;
            }
        }
    }
}
