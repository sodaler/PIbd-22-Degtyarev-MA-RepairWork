using System;
using System.Collections.Generic;
using System.Text;

namespace RepairWorkContracts.BusinessLogicsContracts
{
    public interface IWorkProcess
    {
        void DoWork(IImplementerLogic implementerLogic, IOrderLogic orderLogic);
    }
}
