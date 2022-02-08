using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class TitleBlocksUtils
    {
        public static List<FamilySymbol> GetTitleBlocks(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            var titleBlocks
               = new FilteredElementCollector(doc)
                 .OfClass(typeof(FamilySymbol))
                   .OfCategory(BuiltInCategory.OST_TitleBlocks)
                   .Cast<FamilySymbol>()
                   .ToList();
            return titleBlocks;
        }
    }
}
