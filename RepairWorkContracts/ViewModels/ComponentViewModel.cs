using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.Attributes;

namespace RepairWorkContracts.ViewModels
{
    public class ComponentViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }
        [Column(title: "Название материала", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }

    }
}
