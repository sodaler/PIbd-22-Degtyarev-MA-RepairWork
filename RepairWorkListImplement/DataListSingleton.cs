using RepairWorkListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Component> Ingredients { get; set; }
        public List<Order> Orders { get; set; }
        public List<Repair> Repairs { get; set; }
        private DataListSingleton()
        {
            Ingredients = new List<Component>();
            Orders = new List<Order>();
            Repairs = new List<Repair>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }

    }
}
