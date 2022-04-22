using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.StoragesContracts;
using RepairWorkContracts.ViewModels;
using RepairWorkDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RepairWorkDatabaseImplement.Implements
{
    public class RepairStorage : IRepairStorage
    {
        public List<RepairViewModel> GetFullList()
        {
            using var context = new RepairWorkDatabase();
            return context.Repairs
            .Include(rec => rec.RepairComponents)
            .ThenInclude(rec => rec.Component)
            .ToList()
            .Select(CreateModel)
            .ToList();
        }
        public List<RepairViewModel> GetFilteredList(RepairBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new RepairWorkDatabase();
            return context.Repairs
                .Include(rec => rec.RepairComponents)
                .ThenInclude(rec => rec.Component)
                .Where(rec => rec.RepairName.Contains(model.RepairName))
                .ToList()
                .Select(CreateModel)
                .ToList();
        }
        public RepairViewModel GetElement(RepairBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new RepairWorkDatabase();
            var repair = context.Repairs
                .Include(rec => rec.RepairComponents)
                .ThenInclude(rec => rec.Component)
                .FirstOrDefault(rec => rec.RepairName == model.RepairName || rec.Id == model.Id);
            return repair != null ? CreateModel(repair) : null;
        }
        public void Insert(RepairBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                Repair repair = new Repair()
                {
                    RepairName = model.RepairName,
                    Price = model.Price
                }; 
                context.Repairs.Add(repair);
                context.SaveChanges();
                CreateModel(model, repair, context);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Update(RepairBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Repairs.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Delete(RepairBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            Repair element = context.Repairs.FirstOrDefault(rec => rec.Id ==
            model.Id);
            if (element != null)
            {
                context.Repairs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Repair CreateModel(RepairBindingModel model, Repair repair,
       RepairWorkDatabase context)
        {
            repair.RepairName = model.RepairName;
            repair.Price = model.Price;
            if (model.Id.HasValue)
            {
                var RepairComponents = context.RepairComponents.Where(rec => rec.RepairId == model.Id.Value).ToList();
                
                context.RepairComponents.RemoveRange(RepairComponents.Where(rec => !model.RepairComponents.ContainsKey(rec.ComponentId)).ToList());
                context.SaveChanges();
                
                foreach (var updateComponent in RepairComponents)
                {
                    updateComponent.Count = model.RepairComponents[updateComponent.ComponentId].Item2;
                    model.RepairComponents.Remove(updateComponent.ComponentId);
                }
                context.SaveChanges();
            }
            
            foreach (var rc in model.RepairComponents)
            {
                context.RepairComponents.Add(new RepairComponent
                {
                    RepairId = repair.Id,
                    ComponentId = rc.Key,
                    Count = rc.Value.Item2
                });
                context.SaveChanges();
            }
            return repair;
        }
        private static RepairViewModel CreateModel(Repair repair)
        {
            return new RepairViewModel
            {
                Id = repair.Id,
                RepairName = repair.RepairName,
                Price = repair.Price,
                RepairComponents = repair.RepairComponents.ToDictionary(recPC => recPC.ComponentId, recPC => (recPC.Component?.ComponentName, recPC.Count))
            };
        }
    }
}
