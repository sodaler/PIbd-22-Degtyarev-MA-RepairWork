using RepairWorkContracts.BindingModels;
using RepairWorkContracts.StoragesContracts;
using RepairWorkContracts.ViewModels;
using RepairWorkFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkFileImplement.Implements
{
    public class WarehouseStorage : IWarehouseStorage
    {
        private readonly FileDataListSingleton source;

        public WarehouseStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }

        public List<WarehouseViewModel> GetFullList()
        {
            return source.Warehouses.Select(CreateModel).ToList();
        }

        public List<WarehouseViewModel> GetFilteredList(WarehouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Warehouses.Where(rec => rec.WarehouseName.Contains(model.WarehouseName)).Select(CreateModel).ToList();
        }

        public WarehouseViewModel GetElement(WarehouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            var warehouse = source.Warehouses.FirstOrDefault(rec => rec.WarehouseName == model.WarehouseName || rec.Id == model.Id);

            return warehouse != null ? CreateModel(warehouse) : null;
        }

        public void Insert(WarehouseBindingModel model)
        {
            int maxId = source.Warehouses.Count > 0 ? source.Warehouses.Max(rec => rec.Id) : 0;

            var element = new Warehouse { Id = maxId + 1, WarehouseComponents = new Dictionary<int, int>() };
            source.Warehouses.Add(CreateModel(model, element));
        }

        public void Update(WarehouseBindingModel model)
        {
            var element = source.Warehouses.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }

            CreateModel(model, element);
        }

        public void Delete(WarehouseBindingModel model)
        {
            Warehouse element = source.Warehouses.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Warehouses.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        
        public bool CheckWriteOff(CheckComponentsCount model)
        {
            var list = GetFullList();
            var neccesary = new Dictionary<int, int>(source.Repairs.FirstOrDefault(rec => rec.Id == model.RepairId).RepairComponents);
            var available = new Dictionary<int, int>();
            neccesary.ToDictionary(kvp => neccesary[kvp.Key] *= model.Count);
            foreach (var warehouse in list)
            {
                foreach(var comp in warehouse.WarehouseComponents)
                {
                    if (available.ContainsKey(comp.Key))
                    {
                        available[comp.Key] += comp.Value.Item2;
                    }
                    else
                    {
                        available.Add(comp.Key, comp.Value.Item2);
                    }
                }
            }

            bool can = available.ToList().All(comp => comp.Value >= neccesary[comp.Key]);
            if (!can || available.Count==0)
            {
                return false;
            }

            foreach (var warehouse in list)
            {
                var warehouseComponents = warehouse.WarehouseComponents;
                foreach (var key in warehouse.WarehouseComponents.Keys)
                {
                    var value = warehouse.WarehouseComponents[key];
                    if (neccesary.ContainsKey(key))
                    {
                        if (value.Item2 > neccesary[key])
                        {
                            warehouseComponents[key] = (value.Item1, value.Item2 - neccesary[key]);
                            neccesary[key] = 0;
                        }
                        else
                        {
                            warehouseComponents[key] = (value.Item1, 0);
                            neccesary[key] -= value.Item2;
                        }
                        Update(new WarehouseBindingModel
                        {
                            Id = warehouse.Id,
                            WarehouseName = warehouse.WarehouseName,
                            ResponsiblePerson = warehouse.ResponsiblePerson,
                            DateCreate = warehouse.DateCreate,
                            WarehouseComponents = warehouseComponents
                        });
                    }
                }
            }
            return true;
        }
        
        private Warehouse CreateModel(WarehouseBindingModel model, Warehouse warehouse)
        {
            warehouse.WarehouseName = model.WarehouseName;
            warehouse.ResponsiblePerson = model.ResponsiblePerson;
            warehouse.DateCreate = model.DateCreate;
            // удаляем убранные
            foreach (var key in warehouse.WarehouseComponents.Keys.ToList())
            {
                if (!model.WarehouseComponents.ContainsKey(key))
                {
                    warehouse.WarehouseComponents.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (var component in model.WarehouseComponents)
            {
                if (warehouse.WarehouseComponents.ContainsKey(component.Key))
                {
                    warehouse.WarehouseComponents[component.Key] = model.WarehouseComponents[component.Key].Item2;
                }
                else
                {
                    warehouse.WarehouseComponents.Add(component.Key, model.WarehouseComponents[component.Key].Item2);
                }
            }

            return warehouse;
        }

        private WarehouseViewModel CreateModel(Warehouse warehouse)
        {
            return new WarehouseViewModel
            {
                Id = warehouse.Id,
                WarehouseName = warehouse.WarehouseName,
                ResponsiblePerson = warehouse.ResponsiblePerson,
                DateCreate = warehouse.DateCreate,
                WarehouseComponents = warehouse.WarehouseComponents.ToDictionary(recWI => recWI.Key, recWI =>
(source.Components.FirstOrDefault(recI => recI.Id == recWI.Key)?.ComponentName, recWI.Value))
            };
        }

        public bool CheckCounts(CheckComponentsCount model)
        {
            throw new NotImplementedException();
        }
    }
}
