using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.ViewModels;

namespace RepairWorkContracts.BusinessLogicsContracts
{
    public interface IWarehouseLogic
    {
        List<WarehouseViewModel> Read(WarehouseBindingModel model);
        void CreateOrUpdate(WarehouseBindingModel model);
        void Delete(WarehouseBindingModel model);
        void AddComponent(WarehouseBindingModel model, int componentId, int amount);
    }
}
