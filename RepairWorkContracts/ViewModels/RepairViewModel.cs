using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.Attributes;

namespace RepairWorkContracts.ViewModels
{
    public class RepairViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }

        [Column(title: "Название ремонта", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string RepairName { get; set; }

        [Column(title: "Цена", width: 100)]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> RepairComponents { get; set; }
    }
}
