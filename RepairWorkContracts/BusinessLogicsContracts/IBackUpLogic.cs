using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RepairWorkContracts.BindingModels;

namespace RepairWorkContracts.BusinessLogicsContracts
{
    public interface IBackUpLogic
    {
        void CreateBackUp(BackUpSaveBinidngModel model);
    }
}
