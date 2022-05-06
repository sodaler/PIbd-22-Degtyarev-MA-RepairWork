﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkContracts.ViewModels
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int RepairId { get; set; }
        public int ClientId { get; set; }
        [DisplayName("Клиент")]
        public string ClientFIO { get; set; }
        [DisplayName("Изделие")]
        public string RepairName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }
    }
}
