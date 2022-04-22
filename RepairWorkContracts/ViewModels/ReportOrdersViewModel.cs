using System;
using System.Collections.Generic;
using System.Text;

namespace RepairWorkContracts.ViewModels
{
    public class ReportOrdersViewModel
    {   
        public DateTime DateCreate { get; set; }
        public string RepairName { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public string Status { get; set; }
    }
}
