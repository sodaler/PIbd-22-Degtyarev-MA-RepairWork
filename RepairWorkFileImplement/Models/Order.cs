﻿using RepairWorkContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkFileImplement.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public int ClientId { get; set; }
        public int RepairId { get; set; }
        public int? ImplementerId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }
}
