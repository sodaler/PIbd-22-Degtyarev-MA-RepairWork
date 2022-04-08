using RepairWorkContracts.BindingModels;
using RepairWorkContracts.BusinessLogicsContracts;
using RepairWorkContracts.StorageContracts;
using RepairWorkContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkBusinessLogic.BusinessLogics
{
    public class RepairLogic : IRepairLogic
    {
        private readonly IRepairStorage _repairStorage;
        public RepairLogic(IRepairStorage repairStorage)
        {
            _repairStorage = repairStorage;
        }
        public void CreateOrUpdate(RepairBindingModel model)
        {
            var repair = _repairStorage.GetElement(new RepairBindingModel { RepairName = model.RepairName });
            if (repair != null && repair.Id != model.Id)
            {
                throw new Exception("Такой ремонт уже есть");
            }
            if (model.Id.HasValue)
            {
                _repairStorage.Update(model);
            }
            else
            {
                _repairStorage.Insert(model);
            }
        }

        public void Delete(RepairBindingModel model)
        {
            var element = _repairStorage.GetElement(new RepairBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _repairStorage.Delete(model);
        }

        public List<RepairViewModel> Read(RepairBindingModel model)
        {
            if (model == null)
            {
                return _repairStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<RepairViewModel> { _repairStorage.GetElement(model) };
            }
            return _repairStorage.GetFilteredList(model);
        }
    }
}
