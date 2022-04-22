using RepairWorkContracts.Enums;
using RepairWorkFileImplement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace RepairWorkFileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string ComponentFileName = "Component.xml";
        private readonly string OrderFileName = "Order.xml";
        private readonly string RepairFileName = "Repair.xml";
        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<Repair> Repairs { get; set; }
        private FileDataListSingleton()
        {
            Components = LoadComponents();
            Orders = LoadOrders();
            Repairs = LoadRepairs();
        }
        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }
        ~FileDataListSingleton()
        {
            SaveComponents();
            SaveOrders();
            SaveRepairs();
        }
        private List<Component> LoadComponents()
        {
            var list = new List<Component>();
            if (File.Exists(ComponentFileName))
            {
                var xDocument = XDocument.Load(ComponentFileName);
                var xElements = xDocument.Root.Elements("Component").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Component
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ComponentName = elem.Element("ComponentName").Value
                    });
                }
            }
            return list;
        }
        private List<Order> LoadOrders()
        {
            var list = new List<Order>();
            if (File.Exists(OrderFileName))
            {
                XDocument xDocument = XDocument.Load(OrderFileName);
                var xElements = xDocument.Root.Elements("Order").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Order
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        RepairId = Convert.ToInt32(elem.Element("RepairId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value),
                        Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                        Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), elem.Element("Status").Value),
                        DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value),
                        DateImplement = string.IsNullOrEmpty(elem.Element("DateImplement").Value) ? (DateTime?)null :
                            Convert.ToDateTime(elem.Element("DateImplement").Value)
                    });
                }
            }
            return list;
        }
        private List<Repair> LoadRepairs()
        {
            var list = new List<Repair>();
            if (File.Exists(RepairFileName))
            {
                var xDocument = XDocument.Load(RepairFileName);
                var xElements = xDocument.Root.Elements("Repair").ToList();
                foreach (var elem in xElements)
                {
                    var repairComponents = new Dictionary<int, int>();
                    foreach (var component in
                   elem.Element("RepairComponents").Elements("RepairComponent").ToList())
                    {
                        repairComponents.Add(Convert.ToInt32(component.Element("Key").Value),
                       Convert.ToInt32(component.Element("Value").Value));
                    }
                    list.Add(new Repair
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        RepairName = elem.Element("RepairName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value),
                        RepairComponents = repairComponents
                    });
                }
            }
            return list;
        }
        private void SaveComponents()
        {
            if (Components != null)
            {
                var xElement = new XElement("Components");
                foreach (var components in Components)
                {
                    xElement.Add(new XElement("Component",
                    new XAttribute("Id", components.Id),
                    new XElement("ComponentName", components.ComponentName)));
                }
                var xDocument = new XDocument(xElement); xDocument.Save(ComponentFileName);
            }
        }
        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");

                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                    new XAttribute("Id", order.Id),
                    new XElement("RepairId", order.RepairId),
                    new XElement("Count", order.Count),
                    new XElement("Sum", order.Sum),
                    new XElement("Status", order.Status),
                    new XElement("DateCreate", order.DateCreate),
                    new XElement("DateImplement", order.DateImplement)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
        private void SaveRepairs()
        {
            if (Repairs != null)
            {
                var xElement = new XElement("Repairs");
                foreach (var repair in Repairs)
                {
                    var ingrElement = new XElement("RepairsComponents");
                    foreach (var component in repair.RepairComponents)
                    {
                        ingrElement.Add(new XElement("RepairComponent",
                        new XElement("Key", component.Key),
                        new XElement("Value", component.Value)));
                    }
                    xElement.Add(new XElement("Repair",
                     new XAttribute("Id", repair.Id),
                     new XElement("RepairName", repair.RepairName),
                     new XElement("Price", repair.Price),
                     ingrElement));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(RepairFileName);
            }
        }
        public static void Save()
        {
            GetInstance().SaveComponents();
            GetInstance().SaveOrders();
            GetInstance().SaveRepairs();
        }
    }
}
