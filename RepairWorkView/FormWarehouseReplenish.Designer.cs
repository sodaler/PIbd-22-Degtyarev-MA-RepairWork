
namespace RepairWorkView
{
    partial class FormWarehouseReplenish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxWarehouseName = new System.Windows.Forms.ComboBox();
            this.comboBoxComponentName = new System.Windows.Forms.ComboBox();
            this.labelWarehouseName = new System.Windows.Forms.Label();
            this.labelComponent = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxWarehouseName
            // 
            this.comboBoxWarehouseName.FormattingEnabled = true;
            this.comboBoxWarehouseName.Location = new System.Drawing.Point(171, 28);
            this.comboBoxWarehouseName.Name = "comboBoxWarehouseName";
            this.comboBoxWarehouseName.Size = new System.Drawing.Size(321, 33);
            this.comboBoxWarehouseName.TabIndex = 0;
            // 
            // comboBoxComponentName
            // 
            this.comboBoxComponentName.FormattingEnabled = true;
            this.comboBoxComponentName.Location = new System.Drawing.Point(171, 82);
            this.comboBoxComponentName.Name = "comboBoxComponentName";
            this.comboBoxComponentName.Size = new System.Drawing.Size(321, 33);
            this.comboBoxComponentName.TabIndex = 1;
            // 
            // labelWarehouseName
            // 
            this.labelWarehouseName.AutoSize = true;
            this.labelWarehouseName.Location = new System.Drawing.Point(12, 36);
            this.labelWarehouseName.Name = "labelWarehouseName";
            this.labelWarehouseName.Size = new System.Drawing.Size(153, 25);
            this.labelWarehouseName.TabIndex = 2;
            this.labelWarehouseName.Text = "Название склада:";
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Location = new System.Drawing.Point(12, 90);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(107, 25);
            this.labelComponent.TabIndex = 3;
            this.labelComponent.Text = "Компонент:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 146);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(111, 25);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Количество:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(171, 140);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(321, 31);
            this.textBoxAmount.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 227);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(189, 51);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(303, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(189, 51);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormWarehouseReplenish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 307);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelComponent);
            this.Controls.Add(this.labelWarehouseName);
            this.Controls.Add(this.comboBoxComponentName);
            this.Controls.Add(this.comboBoxWarehouseName);
            this.Name = "FormWarehouseReplenish";
            this.Text = "Пополнение склада";
            this.Load += new System.EventHandler(this.FormWarehouseReplenish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWarehouseName;
        private System.Windows.Forms.ComboBox comboBoxComponentName;
        private System.Windows.Forms.Label labelWarehouseName;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}