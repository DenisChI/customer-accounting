
namespace PresentationLayer.Views.AdminViews
{
    partial class AdminMainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainView));
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonProvider = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonProductOrder = new System.Windows.Forms.Button();
            this.buttonProductAtStock = new System.Windows.Forms.Button();
            this.contextMenuStripOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxReport = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.системаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.contextMenuStripOptions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(133, 30);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.RowTemplate.Height = 25;
            this.dataGridViewTable.Size = new System.Drawing.Size(1003, 308);
            this.dataGridViewTable.TabIndex = 0;
            this.dataGridViewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTableCellContentClick);
            this.dataGridViewTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTableCellMouseEnter);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(8, 30);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(119, 23);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиенты";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // buttonProvider
            // 
            this.buttonProvider.Location = new System.Drawing.Point(8, 59);
            this.buttonProvider.Name = "buttonProvider";
            this.buttonProvider.Size = new System.Drawing.Size(119, 23);
            this.buttonProvider.TabIndex = 2;
            this.buttonProvider.Text = "Поставщики";
            this.buttonProvider.UseVisualStyleBackColor = true;
            this.buttonProvider.Click += new System.EventHandler(this.ProviderButton_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.Location = new System.Drawing.Point(8, 88);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(119, 23);
            this.buttonWarehouse.TabIndex = 3;
            this.buttonWarehouse.Text = "Склады";
            this.buttonWarehouse.UseVisualStyleBackColor = true;
            this.buttonWarehouse.Click += new System.EventHandler(this.WarehouseButton_Click);
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.Location = new System.Drawing.Point(8, 117);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(119, 23);
            this.buttonDiscount.TabIndex = 4;
            this.buttonDiscount.Text = "Скидки";
            this.buttonDiscount.UseVisualStyleBackColor = true;
            this.buttonDiscount.Click += new System.EventHandler(this.DiscountButton_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(8, 146);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(119, 23);
            this.buttonProduct.TabIndex = 5;
            this.buttonProduct.Text = "Товары";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // buttonProductOrder
            // 
            this.buttonProductOrder.Location = new System.Drawing.Point(8, 175);
            this.buttonProductOrder.Name = "buttonProductOrder";
            this.buttonProductOrder.Size = new System.Drawing.Size(119, 23);
            this.buttonProductOrder.TabIndex = 6;
            this.buttonProductOrder.Text = "Заказы";
            this.buttonProductOrder.UseVisualStyleBackColor = true;
            this.buttonProductOrder.Click += new System.EventHandler(this.ProductOrderButton_Click);
            // 
            // buttonProductAtStock
            // 
            this.buttonProductAtStock.Location = new System.Drawing.Point(8, 204);
            this.buttonProductAtStock.Name = "buttonProductAtStock";
            this.buttonProductAtStock.Size = new System.Drawing.Size(119, 23);
            this.buttonProductAtStock.TabIndex = 7;
            this.buttonProductAtStock.Text = "Товары в наличии";
            this.buttonProductAtStock.UseVisualStyleBackColor = true;
            this.buttonProductAtStock.Click += new System.EventHandler(this.ProductAtStockButton_Click);
            // 
            // contextMenuStripOptions
            // 
            this.contextMenuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStripOptions.Name = "contextMenuStripOptions";
            this.contextMenuStripOptions.Size = new System.Drawing.Size(129, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.green_plus_24;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.edit_24;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.perfect_red_minus_24_long;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // comboBoxReport
            // 
            this.comboBoxReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReport.FormattingEnabled = true;
            this.comboBoxReport.Location = new System.Drawing.Point(8, 344);
            this.comboBoxReport.Name = "comboBoxReport";
            this.comboBoxReport.Size = new System.Drawing.Size(276, 23);
            this.comboBoxReport.TabIndex = 8;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(290, 344);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(130, 23);
            this.buttonSelect.TabIndex = 9;
            this.buttonSelect.Text = "Просмотреть отчёт";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Отчёты:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // системаToolStripMenuItem
            // 
            this.системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            this.системаToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.системаToolStripMenuItem.Text = "Выйти";
            this.системаToolStripMenuItem.Click += new System.EventHandler(this.системаToolStripMenuItem_Click);
            // 
            // AdminMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 369);
            this.ContextMenuStrip = this.contextMenuStripOptions;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.comboBoxReport);
            this.Controls.Add(this.buttonProductAtStock);
            this.Controls.Add(this.buttonProductOrder);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonDiscount);
            this.Controls.Add(this.buttonWarehouse);
            this.Controls.Add(this.buttonProvider);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.dataGridViewTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.contextMenuStripOptions.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonProvider;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button buttonDiscount;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonProductOrder;
        private System.Windows.Forms.Button buttonProductAtStock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxReport;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem;
    }
}