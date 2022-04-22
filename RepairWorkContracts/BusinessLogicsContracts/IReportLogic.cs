using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.ViewModels;

namespace RepairWorkContracts.BusinessLogicsContracts
{
    public interface IReportLogic
    {
        List<ReportRepairComponentViewModel> GetRepairComponent();
        List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);
        void SaveRepairsToWordFile(ReportBindingModel model);
        void SaveRepairComponentToExcelFile(ReportBindingModel model);
        void SaveOrdersToPdfFile(ReportBindingModel model);
    }
}
