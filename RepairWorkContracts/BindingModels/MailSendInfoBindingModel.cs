using System;
using System.Collections.Generic;
using System.Text;

namespace RepairWorkContracts.BindingModels
{
    public class MailSendInfoBindingModel
    {
        public string MailAddress { get; set; }

        public string Subject { get; set; }
        public string Text { get; set; }
    }
}
