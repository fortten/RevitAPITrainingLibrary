using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class ViewsUtils
    {
        public static List<ViewPlan> GetFloorPlanViews(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;
            var views
               = new FilteredElementCollector(doc)
                   .OfClass(typeof(ViewPlan))
                   .Cast<ViewPlan>()
                   .Where(p => p.ViewType == ViewType.FloorPlan)
                   .ToList();
            return views;
        }
        public static List<ViewSection> GetViews(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;
            var views
               = new FilteredElementCollector(doc)
                   .OfClass(typeof(ViewSection))
                   .OfCategory(BuiltInCategory.OST_Views)
                   .Cast<ViewSection>()
                   .ToList();
            return views;
        }
    }
}
