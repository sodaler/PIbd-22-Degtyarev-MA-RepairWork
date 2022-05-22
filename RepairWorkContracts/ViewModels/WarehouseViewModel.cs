using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace RepairWorkContracts.ViewModels
{
    public class WarehouseViewModel
    {
        public int Id { get; set; }
        
        [DisplayName("Название склада")]
        public string WarehouseName { get; set; }

        [DisplayName("ФИО ответственного лица")]
        public string ResponsiblePerson { get; set; }
        
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        public Dictionary<int, (string, int)> WarehouseComponents { get; set; }
    }
}
