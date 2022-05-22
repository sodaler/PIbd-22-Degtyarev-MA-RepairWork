
namespace RepairShopView
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemComponent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRepairs = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonIssuedOrder = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.toolStripMenuItemWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouseReplenish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemManual,
            this.toolSrtipMenuItemWarehouseReplenish});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemManual
            // 
            this.toolStripMenuItemManual.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemComponent,
            this.toolStripMenuItemRepairs,
            this.toolStripMenuItemWarehouses});
            this.toolStripMenuItemManual.Name = "toolStripMenuItemManual";
            this.toolStripMenuItemManual.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItemManual.Text = "Справочники";
            // 
            // toolStripMenuItemComponent
            // 
            this.toolStripMenuItemComponent.Name = "toolStripMenuItemComponent";
            this.toolStripMenuItemComponent.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemComponent.Text = "Компоненты";
            this.toolStripMenuItemComponent.Click += new System.EventHandler(this.toolStripMenuItemComponent_Click);
            // 
            // toolStripMenuItemRepairs
            // 
            this.toolStripMenuItemRepairs.Name = "toolStripMenuItemRepairs";
            this.toolStripMenuItemRepairs.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemRepairs.Text = "Ремонт";
            this.toolStripMenuItemRepairs.Click += new System.EventHandler(this.toolStripMenuItemRepairs_Click);
            // 
            // toolStripMenuItemWarehouses
            // 
            this.toolStripMenuItemWarehouses.Name = "toolStripMenuItemWarehouses";
            this.toolStripMenuItemWarehouses.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemWarehouses.Text = "Склады";
            this.toolStripMenuItemWarehouses.Click += new System.EventHandler(this.toolStripMenuItemWarehouses_Click);
            // 
            // toolStripMenuItemWarehouseReplenish
            //
            this.toolStripMenuItemFillWarehouse.Name = "toolStripMenuItemWarehouseReplenish";
            this.toolStripMenuItemFillWarehouse.Size = new System.Drawing.Size(123, 18);
            this.toolStripMenuItemFillWarehouse.Text = "Пополнить склад";
            this.toolStripMenuItemFillWarehouse.Click += new System.EventHandler(this.toolStripMenuItemWarehouseReplenish_Click);
            //
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(662, 395);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(705, 44);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(164, 42);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(705, 122);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(164, 51);
            this.buttonTakeOrderInWork.TabIndex = 3;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(705, 212);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(164, 44);
            this.buttonOrderReady.TabIndex = 4;
            this.buttonOrderReady.Text = "Заказ готов";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
            // 
            // buttonIssuedOrder
            // 
            this.buttonIssuedOrder.Location = new System.Drawing.Point(705, 300);
            this.buttonIssuedOrder.Name = "buttonIssuedOrder";
            this.buttonIssuedOrder.Size = new System.Drawing.Size(164, 48);
            this.buttonIssuedOrder.TabIndex = 5;
            this.buttonIssuedOrder.Text = "Заказ выдан";
            this.buttonIssuedOrder.UseVisualStyleBackColor = true;
            this.buttonIssuedOrder.Click += new System.EventHandler(this.buttonIssuedOrder_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(705, 404);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(164, 41);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Обновить список";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 473);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonIssuedOrder);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Помещение с ремонтными работами";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemManual;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemComponent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRepairs;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonOrderReady;
        private System.Windows.Forms.Button buttonIssuedOrder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouses;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouseReplenish;
    }
}