using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.Attributes;

namespace RepairWorkContracts.ViewModels
{
    public class ClientViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }

        [Column(title: "Клиент", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ClientFIO { get; set; }

        [Column(title: "Логин", width: 150)]
        public string Email { get; set; }

        [Column(title: "Пароль", width: 100)]
        public string Password { get; set; }
    }
}
