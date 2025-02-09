﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkContracts.BindingModels
{
    /// <summary>
    /// Данные от клиента, для создания заказа
    /// </summary>
    public class CreateOrderBindingModel
    {
        public int RepairId { get; set; }
        public int Count { get; set; }
        public int ClientId { get; set; }
        public decimal Sum { get; set; }
    }
}
