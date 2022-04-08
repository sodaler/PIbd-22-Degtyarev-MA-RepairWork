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
    public class ComponentStorage : IComponentStorage
    {
        private readonly DataListSingleton source;
        public ComponentStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<ComponentViewModel> GetFullList()
        {
            var result = new List<ComponentViewModel>();
            foreach (var ingredient in source.Ingredients)
            {
                result.Add(CreateModel(ingredient));
            }
            return result;
        }
        public List<ComponentViewModel> GetFilteredList(ComponentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var result = new List<ComponentViewModel>();
            foreach (var ingredient in source.Ingredients)
            {
                if (ingredient.ComponentName.Contains(model.ComponentName))
                {
                    result.Add(CreateModel(ingredient));
                }
            }
            return result;
        }
        public ComponentViewModel GetElement(ComponentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var ingredient in source.Ingredients)
            {
                if (ingredient.Id == model.Id || ingredient.ComponentName ==
               model.ComponentName)
                {
                    return CreateModel(ingredient);
                }
            }
            return null;
        }
        public void Insert(ComponentBindingModel model)
        {
            var tempComponent = new Component { Id = 1 };
            foreach (var ingredient in source.Ingredients)
            {
                if (ingredient.Id >= tempComponent.Id)
                {
                    tempComponent.Id = ingredient.Id + 1;
                }
            }
            source.Ingredients.Add(CreateModel(model, tempComponent));
        }
        public void Update(ComponentBindingModel model)
        {
            Component tempIngredient = null;
            foreach (var ingredient in source.Ingredients)
            {
                if (ingredient.Id == model.Id)
                {
                    tempIngredient = ingredient;
                }
            }
            if (tempIngredient == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempIngredient);
        }
        public void Delete(ComponentBindingModel model)
        {
            for (int i = 0; i < source.Ingredients.Count; ++i)
            {
                if (source.Ingredients[i].Id == model.Id.Value)
                {
                    source.Ingredients.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
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
                IngredientName = component.ComponentName
            };
        }
    }
}
