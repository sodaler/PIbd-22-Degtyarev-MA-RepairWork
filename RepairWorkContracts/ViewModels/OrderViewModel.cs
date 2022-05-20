using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.Attributes;

namespace RepairWorkContracts.ViewModels
{
    public class OrderViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }
        public int? ImplementerId { get; set; }
        public int ClientId { get; set; }
        [Column(title: "Клиент", width: 200)]
        public string ClientFIO { get; set; }
        public int RepairId { get; set; }
        [Column(title: "Ремонт", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string RepairName { get; set; }
        [Column(title: "Количество", width: 80)]
        public int Count { get; set; }
        [Column(title: "Сумма", width: 70)]
        public decimal Sum { get; set; }
        [Column(title: "Исполнитель", width: 100)]
        public string ImplementerFIO { get; set; }
        [Column(title: "Статус", width: 70)]
        public string Status { get; set; }
        [Column(title: "Дата создания", width: 110)]
        public DateTime DateCreate { get; set; }
        [Column(title: "Дата выполнения", width: 110)]
        public DateTime? DateImplement { get; set; }

    }
}
