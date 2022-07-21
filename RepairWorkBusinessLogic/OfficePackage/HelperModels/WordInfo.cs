using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.ViewModels;

namespace RepairWorkBusinessLogic.OfficePackage.HelperModels
{
    public class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<RepairViewModel> Repairs { get; set; }
    }
}
