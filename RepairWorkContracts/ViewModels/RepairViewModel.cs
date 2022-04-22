using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkContracts.ViewModels
{
    /// <summary>
    /// Ремонт
    /// </summary>
    public class RepairViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название ремонтной работы")]
        public string RepairName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> RepairComponents { get; set; }

    }
}
