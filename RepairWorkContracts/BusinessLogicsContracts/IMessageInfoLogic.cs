using System;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.ViewModels;
using System.Collections.Generic;
using System.Text;

namespace RepairWorkContracts.BusinessLogicsContracts
{
    public interface IMessageInfoLogic
    {
        List<MessageInfoViewModel> Read(MessageInfoBindingModel model);
        void CreateOrUpdate(MessageInfoBindingModel model);

    }
}
