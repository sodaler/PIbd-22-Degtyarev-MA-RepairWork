using RepairWorkContracts.BindingModels;
using RepairWorkContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepairWorkContracts.BusinessLogicsContracts
{
    public interface IImplementerLogic
    {
        List<ImplementerViewModel> Read(ImplementerBindingModel model);
        void CreateOrUpdate(ImplementerBindingModel model);
        void Delete(ImplementerBindingModel model);
    }
}
