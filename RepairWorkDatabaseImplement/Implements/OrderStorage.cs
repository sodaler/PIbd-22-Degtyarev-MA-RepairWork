using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.StoragesContracts;
using RepairWorkContracts.ViewModels;
using RepairWorkDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using RepairWorkContracts.Enums;
using System.Linq;

namespace RepairWorkDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using var context = new RepairWorkDatabase();
            return context.Orders.Select(CreateModel).ToList();
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new RepairWorkDatabase();
            return context.Orders.Where(rec => rec.Id.Equals(model.Id)).Select(CreateModel).ToList();

        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new RepairWorkDatabase();
            var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            return order != null ? CreateModel(order) : null;
        }
        public void Insert(OrderBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            context.Orders.Add(CreateModel(model, new Order()));
            context.SaveChanges();
        }
        public void Update(OrderBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(OrderBindingModel model)
        {
            using var context = new RepairWorkDatabase();
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Orders.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Order CreateModel(OrderBindingModel model, Order order)
        {
            order.RepairId = model.RepairId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        private static OrderViewModel CreateModel(Order order)
        {
            using var context = new RepairWorkDatabase();
            return new OrderViewModel
            {
                Id = order.Id,
                RepairId = order.RepairId,
                RepairName = order.Repair.RepairName,
                Count = order.Count,
                Sum = order.Sum,
                Status = Enum.GetName(typeof(OrderStatus), order.Status),
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
