
namespace RepairWorkView
{
    partial class FormWarehouse
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelResponsiblePerson = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxResponsiblePerson = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnCompName,
            this.ColumnCompAmount});
            this.dataGridView.Location = new System.Drawing.Point(36, 154);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(710, 548);
            this.dataGridView.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(36, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(153, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название склада:";
            // 
            // labelResponsiblePerson
            // 
            this.labelResponsiblePerson.AutoSize = true;
            this.labelResponsiblePerson.Location = new System.Drawing.Point(36, 84);
            this.labelResponsiblePerson.Name = "labelResponsiblePerson";
            this.labelResponsiblePerson.Size = new System.Drawing.Size(232, 25);
            this.labelResponsiblePerson.TabIndex = 2;
            this.labelResponsiblePerson.Text = "ФИО ответственного лица:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(274, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(472, 31);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxResponsiblePerson
            // 
            this.textBoxResponsiblePerson.Location = new System.Drawing.Point(274, 78);
            this.textBoxResponsiblePerson.Name = "textBoxResponsiblePerson";
            this.textBoxResponsiblePerson.Size = new System.Drawing.Size(472, 31);
            this.textBoxResponsiblePerson.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(466, 742);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(280, 44);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(36, 736);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(280, 44);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 150;
            // 
            // ColumnCompName
            // 
            this.ColumnCompName.HeaderText = "Имя компонента";
            this.ColumnCompName.MinimumWidth = 8;
            this.ColumnCompName.Name = "ColumnCompName";
            this.ColumnCompName.Width = 500;
            // 
            // ColumnCompAmount
            // 
            this.ColumnCompAmount.HeaderText = "Количество";
            this.ColumnCompAmount.MinimumWidth = 8;
            this.ColumnCompAmount.Name = "ColumnCompAmount";
            this.ColumnCompAmount.Width = 150;
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 798);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxResponsiblePerson);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelResponsiblePerson);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormWarehouse";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelResponsiblePerson;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxResponsiblePerson;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompAmount;
    }
}