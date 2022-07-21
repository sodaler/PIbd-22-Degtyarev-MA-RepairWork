using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairWorkContracts.BusinessLogicsContracts;

namespace RepairWorkView
{
    public partial class FormMessages : Form
    {
        private readonly IMessageInfoLogic _logic;
        public FormMessages(IMessageInfoLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }
        private void FormMessages_Load(object sender, EventArgs e)
        {
            Program.ConfigGrid(_logic.Read(null), dataGridView);
        }

    }
}
