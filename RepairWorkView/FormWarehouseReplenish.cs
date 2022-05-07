using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RepairWorkContracts.BindingModels;
using RepairWorkContracts.BusinessLogicsContracts;
using RepairWorkContracts.ViewModels;

namespace RepairWorkView
{
    public partial class FormWarehouseReplenish : Form
    {
        private readonly IWarehouseLogic _logicW;
        private readonly IComponentLogic _logicC;
        public FormWarehouseReplenish(IWarehouseLogic logicW, IComponentLogic logicC)
        {
            InitializeComponent();
            _logicW = logicW;
            _logicC = logicC;
        }

        private void FormWarehouseReplenish_Load(object sender, EventArgs e)
        {
            try
            {
                List<WarehouseViewModel> listWarehouse = _logicW.Read(null);
                if (listWarehouse != null)
                {
                    comboBoxWarehouseName.DisplayMember = "WarehouseName";
                    comboBoxWarehouseName.ValueMember = "Id";
                    comboBoxWarehouseName.DataSource = listWarehouse;
                    comboBoxWarehouseName.SelectedItem = null;
                }
                List<ComponentViewModel> listComponent = _logicC.Read(null);
                if (listComponent != null)
                {
                    comboBoxComponentName.DisplayMember = "ComponentName";
                    comboBoxComponentName.ValueMember = "Id";
                    comboBoxComponentName.DataSource = listComponent;
                    comboBoxComponentName.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxComponentName.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxWarehouseName.SelectedValue == null)
            {
                MessageBox.Show("Выберите склад", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAmount.Text))
            {
                MessageBox.Show("Введите количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logicW.AddComponent(new WarehouseBindingModel { Id = Convert.ToInt32(comboBoxWarehouseName.SelectedValue) }, Convert.ToInt32(comboBoxComponentName.SelectedValue), Convert.ToInt32(textBoxAmount.Text));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
