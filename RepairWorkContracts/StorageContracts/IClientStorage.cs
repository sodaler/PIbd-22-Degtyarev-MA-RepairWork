﻿using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.ViewModels;

namespace RepairWorkContracts.StoragesContracts
{
    public interface IClientStorage
    {
        List<ClientViewModel> GetFullList();

        List<ClientViewModel> GetFilteredList(ClientBindingModel model);

        ClientViewModel GetElement(ClientBindingModel model);

        void Insert(ClientBindingModel model);

        void Update(ClientBindingModel model);

        void Delete(ClientBindingModel model);
    }
}
