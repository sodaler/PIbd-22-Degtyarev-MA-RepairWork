using RepairWorkContracts.BindingModels;
using RepairWorkContracts.StorageContracts;
using RepairWorkContracts.ViewModels;
using RepairWorkFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairWorkFileImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly FileDataListSingleton source;

        public OrderStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public void Delete(OrderBindingModel model)
        {
            Order order = source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (order != null)
            {
                source.Orders.Remove(order);
            }
            else
            {
                throw new Exception("Заказ не найден");
            }
        }
        public List<OrderViewModel> GetFullList()
        {
            return source.Orders.Select(CreateModel).ToList();
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Orders
               .Where(rec => (!model.DateFrom.HasValue && !model.DateTo.HasValue
                && rec.DateCreate.Date == model.DateCreate.Date) ||
                (model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate.Date >= model.DateFrom.Value.Date && rec.DateCreate.Date <= model.DateTo.Value.Date) ||
                (model.ClientId.HasValue && rec.ClientId == model.ClientId)).Select(CreateModel).ToList();
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            var order = source.Orders.FirstOrDefault(rec => rec.RepairId == model.RepairId || rec.Id == model.Id);

            return order != null ? CreateModel(order) : null;
        }

        public void Insert(OrderBindingModel model)
        {
            int maxId = (int)(source.Orders.Count > 0 ? source.Orders.Max(rec => rec.Id) : 0);

            var order = new Order { Id = maxId + 1 };
            source.Orders.Add(CreateModel(model, order));
        }

        public void Update(OrderBindingModel model)
        {
            var order = source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (order == null)
            {
                throw new Exception("Заказ не найден");
            }

            CreateModel(model, order);
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.RepairId = model.RepairId;
            order.ClientId = (int)model.ClientId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }

        private OrderViewModel CreateModel(Order order)
        {
            Repair repair = source.Repairs.FirstOrDefault(x => x.Id == order.RepairId);
            if (repair == null)
            {
                throw new Exception("Ремонт не найден");
            }
            return new OrderViewModel
            {
                Id = (int)order.Id,
                ClientId = order.ClientId,
                ClientFIO = source.Clients.FirstOrDefault(clientFIO => clientFIO.Id == order.ClientId)?.ClientFIO,
                RepairId = order.RepairId,
                RepairName = repair.RepairName,
                Count = order.Count,
                Sum = order.Sum,
                Status = Enum.GetName(order.Status),
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
