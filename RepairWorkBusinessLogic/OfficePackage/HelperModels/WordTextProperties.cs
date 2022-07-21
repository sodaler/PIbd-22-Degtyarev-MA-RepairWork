using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkBusinessLogic.OfficePackage.HelperEnums;

namespace RepairWorkBusinessLogic.OfficePackage.HelperModels
{
    public class WordTextProperties
    {
        public string Size { get; set; }
        public bool Bold { get; set; }
        public WordJustificationType JustificationType { get; set; }
    }
}
