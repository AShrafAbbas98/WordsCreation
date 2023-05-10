using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Document = Autodesk.Revit.DB.Document;
using Floor = Autodesk.Revit.DB.Floor;

namespace WordsCreation
{
    internal class HelperDb
    {
        public static void setColumnParameters(FamilySymbol familySymbol, int width, int depth, string mainRFt, string stirrups)
        {
            // Get a reference to the width parameter
            var widthParam = familySymbol.LookupParameter("b");

            if (widthParam != null)
            {
                // Set the value of the width parameter
                widthParam.SetValueString(width.ToString());
            }
            // Get a reference to the Depth parameter
            var depthParam = familySymbol.LookupParameter("h");
            if (depthParam != null)
            {
                // Set the value of the Depth parameter
                depthParam.SetValueString(depth.ToString());
            }
            // Get a reference to the Main RFT parameter
            var rftParam = familySymbol.LookupParameter("Main RFT");
            if (rftParam != null)
            {
                // Set the value of the Main RFT parameter
                rftParam.Set(mainRFt);
            }
            // Get a reference to the Stirrups parameter
            var stirrupsParam = familySymbol.LookupParameter("Stirrups");
            if (stirrupsParam != null)
            {
                // Set the value of the Stirrups parameter
                stirrupsParam.Set(stirrups);
            }

        }

        public static void setColumnParameters(FamilySymbol familySymbol, int diameter, string mainRFt, string stirrups)
        {
            // Get a reference to the Diameter parameter
            var diaParam = familySymbol.LookupParameter("Diameter");

            if (diaParam != null)
            {
                // Set the value of the Diameter parameter
                diaParam.SetValueString(diameter.ToString());
            }
            // Get a reference to the Main RFT parameter
            var rftParam = familySymbol.LookupParameter("Main RFT");
            if (rftParam != null)
            {
                // Set the value of the Main RFT parameter
                rftParam.Set(mainRFt);
            }
            // Get a reference to the Stirrups parameter
            var stirrupsParam = familySymbol.LookupParameter("Stirrups");
            if (stirrupsParam != null)
            {
                // Set the value of the Stirrups parameter
                stirrupsParam.Set(stirrups);
            }

        }

        public static void setBeamParameters(FamilySymbol familySymbol, int width, int depth, string bottomMainRFt, string topMainRFt, string stirrupHangers, string stirrups)
        {
            // Get a reference to the Diameter parameter
            var bParam = familySymbol.LookupParameter("b");

            if (bParam != null)
            {
                // Set the value of the Diameter parameter
                bParam.SetValueString(width.ToString());
            }
            // Get a reference to the Diameter parameter
            var hParam = familySymbol.LookupParameter("h");

            if (hParam != null)
            {
                // Set the value of the Diameter parameter
                hParam.SetValueString(depth.ToString());
            }
            // Get a reference to the Main RFT parameter
            var rftParam = familySymbol.LookupParameter("Bottom RFT");
            if (rftParam != null)
            {
                // Set the value of the Main RFT parameter
                rftParam.Set(bottomMainRFt);
            }
            // Get a reference to the Main RFT parameter
            var trftParam = familySymbol.LookupParameter("Top RFT over Column");
            if (trftParam != null)
            {
                // Set the value of the Main RFT parameter
                trftParam.Set(topMainRFt);
            }
            // Get a reference to the Main RFT parameter
            var shParam = familySymbol.LookupParameter("Stirrups Hangers");
            if (shParam != null)
            {
                // Set the value of the Main RFT parameter
                shParam.Set(stirrupHangers);
            }
            // Get a reference to the Stirrups parameter
            var stirrupsParam = familySymbol.LookupParameter("Stirrups");
            if (stirrupsParam != null)
            {
                // Set the value of the Stirrups parameter
                stirrupsParam.Set(stirrups);
            }
        }

        public static void setFootingParameters(FamilySymbol familySymbol, int width, int depth, int thickness, string MainRFtX, string MainRFtY)
        {
            // Get a reference to the Diameter parameter
            var bParam = familySymbol.LookupParameter("Width");

            if (bParam != null)
            {
                // Set the value of the Diameter parameter
                bParam.SetValueString(width.ToString());
            }
            // Get a reference to the Diameter parameter
            var hParam = familySymbol.LookupParameter("Length");

            if (hParam != null)
            {
                // Set the value of the Diameter parameter
                hParam.SetValueString(depth.ToString());
            }
            // Get a reference to the Diameter parameter
            var tParam = familySymbol.LookupParameter("Thickness");

            if (tParam != null)
            {
                // Set the value of the Diameter parameter
                tParam.SetValueString(thickness.ToString());
            }

            // Get a reference to the Main RFT parameter
            var rftParam = familySymbol.LookupParameter("Main Bottom  RFT - X Dir");
            if (rftParam != null)
            {
                // Set the value of the Main RFT parameter
                rftParam.Set(MainRFtX);
            }
            // Get a reference to the Main RFT parameter
            var trftParam = familySymbol.LookupParameter("Main Bottom  RFT - Y Dir");
            if (trftParam != null)
            {
                // Set the value of the Main RFT parameter
                trftParam.Set(MainRFtY);
            }

        }

        public static void setWallParameters(FamilySymbol familySymbol, int thickness, string MainRFtX, string MainRFtY)
        {

            // Get a reference to the Diameter parameter
            var tParam = familySymbol.LookupParameter("Thickness");

            if (tParam != null)
            {
                // Set the value of the Diameter parameter
                tParam.SetValueString(thickness.ToString());
            }

            // Get a reference to the Main RFT parameter
            var rftParam = familySymbol.LookupParameter("Main Bottom  RFT - X Dir");
            if (rftParam != null)
            {
                // Set the value of the Main RFT parameter
                rftParam.Set(MainRFtX);
            }
            // Get a reference to the Main RFT parameter
            var trftParam = familySymbol.LookupParameter("Main Bottom  RFT - Y Dir");
            if (trftParam != null)
            {
                // Set the value of the Main RFT parameter
                trftParam.Set(MainRFtY);
            }

        }

        public static void setWallOpeningParameters(FamilySymbol familySymbol, int Width, int Height)
        {
            // Get a reference to the Width parameter
            var wParam = familySymbol.LookupParameter("Width");

            if (wParam != null)
            {
                // Set the value of the Width parameter
                wParam.SetValueString(Width.ToString());
            }

            // Get a reference to the Height parameter
            var hParam = familySymbol.LookupParameter("Height");

            if (hParam != null)
            {
                // Set the value of the Height parameter
                hParam.SetValueString(Height.ToString());
            }
        }

        public static void SaveDocument(Autodesk.Revit.DB.Document document, string filePath)
        {
            var app = document.Application;

            // Check if the file already exists
            if (System.IO.File.Exists(filePath))
            {
                //// If the file exists, ask the user if they want to open it
                //TaskDialogResult result = TaskDialog.Show(
                //    "File already exists!",
                //    "Do you want to open the existing file?",
                //    TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No);

                //if (result != TaskDialogResult.Yes)
                //{
                //    return;
                //}

                // Open the file
                app.OpenDocumentFile(filePath);
            }
            else
            {
                // Save the file
                SaveAsOptions options = new SaveAsOptions();
                options.OverwriteExistingFile = true;
                document.SaveAs(filePath, options);
            }
        }

        private static void CloseFamilyDocument(Document familyDocument)
        {
            using (var transaction = new Transaction(familyDocument, "Create New Family"))
            {
                try
                {
                    transaction.Start();
                    if (familyDocument.IsFamilyDocument)
                    {
                        familyDocument.Close(false);
                    }
                    else
                    {
                        // Handle non-family document error here
                    }
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    TaskDialog.Show("Error", ex.Message);
                }
            }
        }

        public static void CloseFamily(Document familyDocument)
        {
            // Save the changes to the family document
            familyDocument.Save();

            // Close the family document
            familyDocument.Close(false);
        }

        public static void DeleteSymbolByName(Document document, FamilySymbol familySymbol, string name)
        {
            familySymbol = new FilteredElementCollector(document)
                  .OfClass(typeof(FamilySymbol))
                  .Cast<FamilySymbol>()
                  .FirstOrDefault(x => x.Name.Equals(name));
            if (familySymbol != null)
            {
                document.Delete(familySymbol.Id);
            }
        }
        public static void DeleteSymbolByNameIndex(Document document, FamilySymbol familySymbol, string familyName, string name, int stIndex, int NoOfChar)
        {
            familySymbol = new FilteredElementCollector(document)
                .OfClass(typeof(FamilySymbol))
                .Cast<FamilySymbol>()
                .Where(x => x.Family.Name == familyName)
                .FirstOrDefault(x => x.Name.Substring(stIndex, NoOfChar) == name);
            if (familySymbol != null)
            {
                document.Delete(familySymbol.Id);
            }
        }

        public static Level GetFirstLevel(Document document)
        {
            // Grab all levels
            var levelsCollection = new FilteredElementCollector(document)
                .WhereElementIsNotElementType()
                .OfCategory(BuiltInCategory.INVALID)
                .OfClass(typeof(Level));

            // First level in the collection
            Level firstLevel = levelsCollection.FirstElement() as Level;

            return firstLevel;
        }

        private static WallType GetDefoultWallType(Document document)
        {
            // First level 
            Level firstLevel = HelperDb.GetFirstLevel(document);

            // Grab all walls
            var wallsCollection = new FilteredElementCollector(document)
                .WhereElementIsNotElementType()
                .OfClass(typeof(Wall));


            // First wall in the collection
            Wall firstWall = wallsCollection.FirstOrDefault(w => w.Name.Substring(0, 7) == "Generic") as Wall;


            // Grab all wall types
            var wallTypesCollection = new FilteredElementCollector(document)
               .OfCategory(BuiltInCategory.INVALID)
               .OfClass(typeof(WallType));

            // First wallType in the collection
            WallType firstWallType = wallTypesCollection.FirstOrDefault(w => w.Name.Substring(0, 7) == "Generic") as WallType;

            return firstWallType;
        }

        private static FloorType GetDefoultFloorType(Document document)
        {
            // First level 
            Level firstLevel = HelperDb.GetFirstLevel(document);

            // Grab all fllors
            var floorsCollection = new FilteredElementCollector(document)
                .WhereElementIsNotElementType()
                .OfClass(typeof(Floor));


            // First floor in the collection
            Floor firstFloor = floorsCollection.FirstOrDefault(w => w.Name.Substring(0, 7) == "Generic") as Floor;


            // Grab all floor types
            var floorTypesCollection = new FilteredElementCollector(document)
               .OfCategory(BuiltInCategory.INVALID)
               .OfClass(typeof(FloorType));

            // First wallType in the collection
            FloorType firstFloorType = floorTypesCollection.FirstOrDefault(w => w.Name.Substring(0, 7) == "Generic") as FloorType;

            return firstFloorType;
        }

        public static WallType CreateNewWallType(Document document, string wallName, int thickness, WallType checkName)
        {
            // First wallType in the collection
            WallType firstWallType = HelperDb.GetDefoultWallType(document);
            WallType newWallType = null;
            if (checkName == null)
            {
                // Duplicate wallType
                newWallType = firstWallType.Duplicate(wallName) as WallType;
            }
            else
            {
                newWallType = checkName;
            }

            // Get the existing compound structure of the wall type
            CompoundStructure compoundStructure = newWallType.GetCompoundStructure();

            // Get the layers in the compound structure
            IList<CompoundStructureLayer> layers = compoundStructure.GetLayers();

            // Update the thickness of the first layer in the compound structure
            layers[0].Width = UnitUtils.ConvertToInternalUnits(thickness, UnitTypeId.Millimeters);

            // Set the updated layers back to the wall type
            compoundStructure.SetLayers(layers);
            newWallType.SetCompoundStructure(compoundStructure);

            return newWallType;
        }

        #region MyRegion
        //    public static FloorType CreateNewFloorType(Document document, string floorName, int thickness)
        //    {
        //        // Validate input
        //        if (thickness <= 0)
        //        {
        //            TaskDialog.Show(ErrorMessages, "Thickness must be greater than 0.");
        //            return null;
        //        }

        //        // Get default floor type
        //        FloorType defaultFloorType = GetDefoultFloorType(document);
        //        if (defaultFloorType == null)
        //        {
        //            TaskDialog.Show(ErrorMessages, "Default floor type not found.");
        //            return null;
        //        }

        //        // Create the new floor type
        //        FloorType newFloorType = CreateNewFloorType(document, floorName, thickness);

        //        // First, we need to get the default floor type
        //        FloorType defaultFloorType = HelperDb.GetDefoultFloorType(document);
        //        if (defaultFloorType == null)
        //        {
        //            TaskDialog.Show("Error", "Default floor type not found.");
        //            return null;
        //        }

        //        // Duplicate the default floor type to create a new floor type
        //        FloorType newFloorType = defaultFloorType.Duplicate(floorName) as FloorType;

        //        // Set the thickness parameter of the new floor type
        //        Parameter thicknessParam = newFloorType.get_Parameter(BuiltInParameter.FLOOR_ATTR_THICKNESS_PARAM);
        //        if (thicknessParam == null)
        //        {
        //            TaskDialog.Show("Error", "Thickness parameter not found in floor type.");
        //            return null;
        //        }
        //        thicknessParam.Set(thickness);

        //        // Create a list of curves for the floor boundary, similar to the previous example
        //        List<Curve> curveList = new List<Curve>
        //{
        //    Line.CreateBound(new XYZ(0, 0, 0), new XYZ(10, 0, 0)),
        //    Line.CreateBound(new XYZ(10, 0, 0), new XYZ(10, 10, 0)),
        //    Line.CreateBound(new XYZ(10, 10, 0), new XYZ(0, 10, 0)),
        //    Line.CreateBound(new XYZ(0, 10, 0), new XYZ(0, 0, 0))
        //};

        //        // Create a list of curve loops for the floor boundary, similar to the previous example
        //        IList<CurveLoop> curveLoops = new List<CurveLoop>();
        //        CurveLoop curveLoop = new CurveLoop();
        //        foreach (Curve curve in curveList)
        //        {
        //            curveLoop.Append(curve);
        //        }
        //        curveLoops.Add(curveLoop);

        //        // Get the first level in the document
        //        Level level = HelperDb.GetFirstLevel(document);
        //        if (level == null)
        //        {
        //            TaskDialog.Show("Error", "No levels found in document.");
        //            return null;
        //        }

        //        // Create a floor instance using the boundary curves and the new floor type
        //        using (Transaction tx = new Transaction(document))
        //        {
        //            tx.Start("Create new floor type and instance");
        //            // Create the new floor type
        //            // Create the new floor instance
        //            Floor floor = document.Create.NewFloor((CurveArray)curveLoops, newFloorType, level, false);
        //            tx.Commit();
        //        }

        //        return newFloorType;
        //    } 
        #endregion

        private const string ErrorMessages = "ErrorMessages";

        // Creates a new FloorType and Floor instance with the given name and thickness.
        public static FloorType CreateNewFloorType(Document document, string floorName, int thickness)
        {
            // Validate input
            if (thickness <= 0)
            {
                TaskDialog.Show(ErrorMessages, "Thickness must be greater than 0.");
                return null;
            }

            // Get default floor type
            FloorType defaultFloorType = GetDefoultFloorType(document);
            if (defaultFloorType == null)
            {
                TaskDialog.Show(ErrorMessages, "Default floor type not found.");
                return null;
            }

            // Create the new floor type
            FloorType newFloorType = CreateNewFloorType(document, defaultFloorType, floorName, thickness);

            // Get boundary curves
            CurveLoop curves = GetFloorBoundaryCurves();

            // Get first level
            Level level = GetFirstLevel(document);
            if (level == null)
            {
                TaskDialog.Show(ErrorMessages, "No levels found in document.");
                return null;
            }

            // Create the floor instance
            Floor floor = CreateNewFloor(document, newFloorType, level, new List<CurveLoop> { curves });

            return newFloorType;
        }

        private static FloorType CreateNewFloorType(Document document, FloorType defaultFloorType, string name, int thickness)
        {
            FloorType newFloorType = defaultFloorType.Duplicate(name) as FloorType;
            Parameter thicknessParam = newFloorType.get_Parameter(BuiltInParameter.FLOOR_ATTR_THICKNESS_PARAM);
            thicknessParam.Set(thickness);
            return newFloorType;
        }

        private static CurveLoop GetFloorBoundaryCurves()
        {
            XYZ startPoint = new XYZ(0, 0, 0);
            XYZ endPoint1 = new XYZ(10, 0, 0);
            XYZ endPoint2 = new XYZ(10, 20, 0);
            XYZ endPoint3 = new XYZ(0, 20, 0);

            Line line1 = Line.CreateBound(startPoint, endPoint1);
            Line line2 = Line.CreateBound(endPoint1, endPoint2);
            Line line3 = Line.CreateBound(endPoint2, endPoint3);
            Line line4 = Line.CreateBound(endPoint3, startPoint);

            CurveArray curveArray = new CurveArray();
            curveArray.Append(line1);
            curveArray.Append(line2);
            curveArray.Append(line3);
            curveArray.Append(line4);

            CurveLoop curveLoop = CurveLoop.Create((IList<Curve>)curveArray);
            return curveLoop;
        }

        private static Floor CreateNewFloor(Document document, FloorType floorType, Level level, IList<CurveLoop> boundaryCurves)
        {
            using (Transaction tx = new Transaction(document))
            {
                tx.Start("Create new floor");

                Floor floor = Floor.Create(document, boundaryCurves, floorType.Id, level.Id);

                tx.Commit();
                return floor;
            }
        }

        public static void CreayeWord(Document document, UIDocument uidoc,ElementId newWallTypeId, ElementId LevelId, double height, char c, string word)
        {
            using (Transaction tx = new Transaction(document, "Create Wall"))
            {
                //string bim = "BIM";
                XYZ st = null;
                XYZ end = null;
                Line geoLine = null;
                Wall wallobj = null;

                //foreach (char c in bim)
                //{
                List<XYZ> coordinates = null;
                coordinates = DetermineeCharacterCoordinates(c, word);
                try
                {
                    if (c == 'B' || c == 'D' || c == 'O')
                    {
                        for (int j = 0; j <= coordinates.Count - 1; j++)
                        {
                            tx.Start();

                            if (j == coordinates.Count - 1)
                            {
                                st = coordinates[j];
                                end = coordinates[0];
                            }
                            else
                            {
                                st = coordinates[j];
                                end = coordinates[j + 1];
                            }
                            geoLine = Line.CreateBound(st, end);

                            // PLace Wall
                            wallobj = Wall.Create(document, geoLine, newWallTypeId, LevelId, height, 0, false, true);
                            tx.Commit();
                            Thread.Sleep(250); // pause for 1 seconds
                            uidoc.RefreshActiveView(); // refresh the document
                        }
                    }
                    else if (c == 'E')
                    {
                        for (int j = 0; j <= coordinates.Count - 2; j++)
                        {
                            tx.Start();

                            if (j == 3)
                            {
                                tx.Commit();
                                continue;
                            }
                            else
                            {
                                st = coordinates[j];
                                end = coordinates[j + 1];

                                geoLine = Line.CreateBound(st, end);

                                // PLace Wall
                                wallobj = Wall.Create(document, geoLine, newWallTypeId, LevelId, height, 0, false, true);
                                tx.Commit();
                                Thread.Sleep(250); // pause for 1 seconds
                                uidoc.RefreshActiveView(); // refresh the document
                            }
                        }
                    }
                    else if (c == 'T')
                    {
                        for (int j = 0; j <= coordinates.Count - 2; j++)
                        {
                            tx.Start();

                            if (j == 1)
                            {
                                tx.Commit();
                                continue;
                            }
                            else
                            {
                                st = coordinates[j];
                                end = coordinates[j + 1];

                                geoLine = Line.CreateBound(st, end);

                                // PLace Wall
                                wallobj = Wall.Create(document, geoLine, newWallTypeId, LevelId, height, 0, false, true);
                                tx.Commit();
                                Thread.Sleep(250); // pause for 1 seconds
                                uidoc.RefreshActiveView(); // refresh the document
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j <= coordinates.Count - 2; j++)
                        {
                            tx.Start();

                            st = coordinates[j];
                            end = coordinates[j + 1];

                            geoLine = Line.CreateBound(st, end);

                            // PLace Wall
                            wallobj = Wall.Create(document, geoLine, newWallTypeId, LevelId, height, 0, false, true);
                            tx.Commit();
                            Thread.Sleep(250); // pause for 1 seconds
                            uidoc.RefreshActiveView(); // refresh the document
                        }
                    }
                }
                catch (Exception ex)
                {
                    string err = ex.Message;
                    tx.Dispose();
                }
            }
        }
        private static List<XYZ> DetermineeCharacterCoordinates(char character, string word)
        {
            List<XYZ> coordinates = new List<XYZ>();
            //BIM start point
            double x = 80;
            double y = 60;
            double yspacing = 30;
            double xspacing = 10;

            //Development start point
            double x_Development = 0;
            double y_Development = 0;

            switch (word)
            {
                case "BIM":
                    switch (character)
                    {
                        case 'B':
                            coordinates = new List<XYZ>()
                    {
                    new XYZ(x, y, 0),
                    new XYZ(x, y+yspacing, 0),
                    new XYZ(x+xspacing,y+yspacing, 0),
                    new XYZ(x+xspacing,y+yspacing*2/3, 0),
                    new XYZ(x, y+yspacing/2, 0),
                    new XYZ(x+xspacing,y+yspacing/3,0),
                    new XYZ(x+xspacing,y,0),
                    };
                            break;
                        case 'I':
                            coordinates = new List<XYZ>()
                    {
                    new XYZ(x+xspacing*3, y, 0),
                    new XYZ(x+xspacing*3, y+yspacing, 0),
                    };
                            break;
                        case 'M':
                            coordinates = new List<XYZ>()
                    {
                    new XYZ(x+xspacing*5, y, 0),
                    new XYZ(x+xspacing*5, y+yspacing, 0),
                    new XYZ(x+xspacing*6, y+yspacing*2/3, 0),
                    new XYZ(x+xspacing*7, y+yspacing, 0),
                    new XYZ(x+xspacing*7, y, 0),
                    };
                            break;
                    }
                    break;

                case "DEV":
                    switch (character)
                    {
                        case 'D':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development, y_Development, 0),
                                        new XYZ(x_Development, y_Development + yspacing, 0),
                                        new XYZ(x_Development + xspacing, y_Development + yspacing*2/3, 0),
                                        new XYZ(x_Development + xspacing, y_Development + yspacing*1/3, 0),
                                        };
                            break;

                        case 'E':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*3, y_Development , 0),
                                        new XYZ(x_Development + xspacing*2, y_Development , 0),
                                        new XYZ(x_Development + xspacing*2, y_Development + yspacing , 0),
                                        new XYZ(x_Development + xspacing*3, y_Development + yspacing , 0),
                                        new XYZ(x_Development + xspacing*3, y_Development + yspacing*1/2 , 0),
                                        new XYZ(x_Development + xspacing*2, y_Development + yspacing*1/2 , 0),
                                        };
                            break;
                        case 'V':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*5, y_Development + yspacing, 0),
                                        new XYZ(x_Development + xspacing*4.5, y_Development, 0),
                                        new XYZ(x_Development + xspacing*4, y_Development + yspacing , 0),
                                        };
                            break;
                    }
                    break;

                case "ELOP":
                    switch (character)
                    {
                        case 'E':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*7, y_Development , 0),
                                        new XYZ(x_Development + xspacing*6, y_Development , 0),
                                        new XYZ(x_Development + xspacing*6, y_Development + yspacing , 0),
                                        new XYZ(x_Development + xspacing*7, y_Development + yspacing , 0),
                                        new XYZ(x_Development + xspacing*7, y_Development + yspacing*1/2 , 0),
                                        new XYZ(x_Development + xspacing*6, y_Development + yspacing*1/2 , 0),
                                        };
                            break;
                        case 'L':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*9, y_Development + yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*8, y_Development+ yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*8, y_Development + yspacing*1 , 0),
                                        };
                            break;
                        case 'O':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*11, y_Development + yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*10, y_Development+ yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*10, y_Development + yspacing*1 , 0),
                                        new XYZ(x_Development + xspacing*11, y_Development + yspacing*1 , 0),
                                        };
                            break;
                        case 'P':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*12, y_Development + yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*12, y_Development+ yspacing*1, 0),
                                        new XYZ(x_Development + xspacing*13, y_Development + yspacing*1 , 0),
                                        new XYZ(x_Development + xspacing*13, y_Development + yspacing*1/2 , 0),
                                        new XYZ(x_Development + xspacing*12, y_Development+ yspacing*1/2, 0),
                                        };
                            break;
                    }
                    break;

                case "MENT":
                    switch (character)
                    {
                        case 'M':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*14, y_Development + yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*14, y_Development+ yspacing*1, 0),
                                        new XYZ(x_Development + xspacing*15, y_Development + yspacing*2/3 , 0),
                                        new XYZ(x_Development + xspacing*16, y_Development + yspacing*1 , 0),
                                        new XYZ(x_Development + xspacing*16, y_Development+ yspacing*0, 0),
                                        };
                            break;
                        case 'E':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*18, y_Development , 0),
                                        new XYZ(x_Development + xspacing*17, y_Development , 0),
                                        new XYZ(x_Development + xspacing*17, y_Development + yspacing , 0),
                                        new XYZ(x_Development + xspacing*18, y_Development + yspacing , 0),
                                        new XYZ(x_Development + xspacing*18, y_Development + yspacing*1/2 , 0),
                                        new XYZ(x_Development + xspacing*17, y_Development + yspacing*1/2 , 0),
                                        };
                            break;
                        case 'N':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*19, y_Development + yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*19, y_Development+ yspacing*1, 0),
                                        new XYZ(x_Development + xspacing*20, y_Development + yspacing*0 , 0),
                                        new XYZ(x_Development + xspacing*20, y_Development + yspacing*1 , 0),
                                        };
                            break;
                        case 'T':
                            coordinates = new List<XYZ>()
                                        {
                                        new XYZ(x_Development + xspacing*21.5, y_Development + yspacing*0, 0),
                                        new XYZ(x_Development + xspacing*21.5, y_Development+ yspacing*1, 0),
                                        new XYZ(x_Development + xspacing*21, y_Development + yspacing*1 , 0),
                                        new XYZ(x_Development + xspacing*22, y_Development + yspacing*1 , 0),
                                        };
                            break;
                    }
                    break;

            }
            return coordinates;
        }
    }
}




