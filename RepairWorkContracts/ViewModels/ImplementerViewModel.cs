using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepairWorkContracts.Attributes;

namespace RepairWorkContracts.ViewModels
{
    public class ImplementerViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }

        [Column(title: "ФИО", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ImplementerFIO { get; set; }

        [Column(title: "Время на заказ", width: 110)]
        public int WorkingTime { get; set; }

        [Column(title: "Время на перерыв", width: 110)]
        public int PauseTime { get; set; }
    }
}
