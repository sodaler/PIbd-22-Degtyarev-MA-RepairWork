using RepairWorkContracts.BindingModels;
using RepairWorkContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkContracts.BusinessLogicsContracts
{
    public interface IRepairLogic
    {
        List<RepairViewModel> Read(RepairBindingModel model);
        void CreateOrUpdate(RepairBindingModel model);
        void Delete(RepairBindingModel model);

    }
}
