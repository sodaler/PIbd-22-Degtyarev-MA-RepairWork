﻿using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.StoragesContracts;
using RepairWorkContracts.ViewModels;
using RepairWorkDatabaseImplement.Models;
using System.Linq;

namespace RepairWorkDatabaseImplement.Implements
{
    public class ComponentStorage : IComponentStorage
    {
        public List<ComponentViewModel> GetFullList()
        {
            using var context = new RepairWorkDatabase();
            return context.Components.Select(CreateModel).ToList();
            
        }
        public List<ComponentViewModel> GetFilteredList(ComponentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new RepairWorkDatabase();
            return context.Components.Where(rec => rec.ComponentName.Contains(model.ComponentName)).Select(CreateModel).ToList();
        }
        public ComponentViewModel GetElement(ComponentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new RepairWorkDatabase();
            var component = context.Components.FirstOrDefault(rec => rec.ComponentName == model.ComponentName || rec.Id == model.Id);
            return component != null ? CreateModel(component) : null;
        }
        public void Insert(ComponentBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            context.Components.Add(CreateModel(model, new Component()));
            context.SaveChanges();
        }
        public void Update(ComponentBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            var element = context.Components.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(ComponentBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            Component element = context.Components.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Components.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Component CreateModel(ComponentBindingModel model, Component component)
        {
            component.ComponentName = model.ComponentName;
            return component;
        }

        private static ComponentViewModel CreateModel(Component component)
        {
            return new ComponentViewModel
            {
                Id = component.Id,
                ComponentName = component.ComponentName
            };
        }
    }
}
