using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkContracts.BindingModels
{
    public class CheckComponentsCount
    {
        public int RepairId { get; set; }
        public int Count { get; set; }
    }
}
