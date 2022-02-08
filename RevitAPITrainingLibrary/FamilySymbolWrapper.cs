using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class FamilySymbolWrapper
    {
        public FamilySymbolWrapper(FamilySymbol familySymbol)
        {
            FamilySymbol = familySymbol;
            Name = familySymbol.Name;
        }
        public bool IsSelected { get; set; }
        public FamilySymbol FamilySymbol { get; }
        public string Name { get; }
    }
}
