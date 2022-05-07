using System;
using System.Collections.Generic;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.ViewModels;
using System.Text;

namespace RepairWorkContracts.StoragesContracts
{
    public interface IMessageInfoStorage
    {
        List<MessageInfoViewModel> GetFullList();
        List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model);
        void Insert(MessageInfoBindingModel model);
    }
}
