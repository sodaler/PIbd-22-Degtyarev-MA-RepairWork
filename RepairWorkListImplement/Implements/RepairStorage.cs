using RepairWorkContracts.BindingModels;
using RepairWorkContracts.StorageContracts;
using RepairWorkContracts.ViewModels;
using RepairWorkListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkListImplement.Implements
{
    public class RepairStorage : IRepairStorage 
    {
        private readonly DataListSingleton source;
        public RepairStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<RepairViewModel> GetFullList()
        {
            var result = new List<RepairViewModel>();
            foreach (var repair in source.Repairs)
            {
                result.Add(CreateModel(repair));
            }
            return result;
        }
        public List<RepairViewModel> GetFilteredList(RepairBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var result = new List<RepairViewModel>();
            foreach (var repair in source.Repairs)
            {
                if (repair.RepairName.Contains(model.RepairName))
                {
                    result.Add(CreateModel(repair));
                }
            }
            return result;
        }
        public RepairViewModel GetElement(RepairBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var repair in source.Repairs)
            {
                if (repair.Id == model.Id || repair.RepairName ==
                model.RepairName)
                {
                    return CreateModel(repair);
                }
            }
            return null;
        }
        public void Insert(RepairBindingModel model)
        {
            var tempRepair = new Repair
            {
                Id = 1,
                RepairComponents = new
            Dictionary<int, int>()
            };
            foreach (var repair in source.Repairs)
            {
                if (repair.Id >= tempRepair.Id)
                {
                    tempRepair.Id = repair.Id + 1;
                }
            }
            source.Repairs.Add(CreateModel(model, tempRepair));
        }
        public void Update(RepairBindingModel model)
        {
            Repair tempRepair = null;
            foreach (var repair in source.Repairs)
            {
                if (repair.Id == model.Id)
                {
                    tempRepair = repair;
                }
            }
            if (tempRepair == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempRepair);
        }
        public void Delete(RepairBindingModel model)
        {
            for (int i = 0; i < source.Repairs.Count; ++i)
            {
                if (source.Repairs[i].Id == model.Id)
                {
                    source.Repairs.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private static Repair CreateModel(RepairBindingModel model, Repair
        repair)
        {
            repair.RepairName = model.RepairName;
            repair.Price = model.Price;
            // удаляем убранные
            foreach (var key in repair.RepairComponents.Keys.ToList())
            {
                if (!model.RepairComponents.ContainsKey(key))
                {
                    repair.RepairComponents.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (var ingredient in model.RepairComponents)
            {
                if (repair.RepairComponents.ContainsKey(ingredient.Key))
                {
                    repair.RepairComponents[ingredient.Key] =
                    model.RepairComponents[ingredient.Key].Item2;
                }
                else
                {
                    repair.RepairComponents.Add(ingredient.Key,
                    model.RepairComponents[ingredient.Key].Item2);
                }
            }
            return repair;
        }
        private RepairViewModel CreateModel(Repair repair)
        {
         
        var repairComponents = new Dictionary<int, (string, int)>();
            foreach (var ii in repair.RepairComponents)
            {
                string ingredientName = string.Empty;
                foreach (var ingredient in source.Ingredients)
                {
                    if (ii.Key == ingredient.Id)
                    {
                        ingredientName = ingredient.ComponentName;
                        break;
                    }
                }
                repairComponents.Add(ii.Key, (ingredientName, ii.Value));
            }
            return new RepairViewModel
            {
                Id = repair.Id,
                RepairName = repair.RepairName,
                Price = repair.Price,
                RepairComponents = repairComponents
            };
        }
    }
}
