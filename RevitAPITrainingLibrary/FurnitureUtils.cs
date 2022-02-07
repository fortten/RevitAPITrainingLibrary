using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class  FurnitureUtils
    {
        public static List<FamilySymbol> GetFurniture(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            List<FamilySymbol> furniture = new FilteredElementCollector(doc)
                                                .OfClass(typeof(FamilySymbol))
                                                .OfCategory(BuiltInCategory.OST_Furniture)
                                                .Cast<FamilySymbol>()
                                                .ToList();
            return furniture;
        }
    }
}
