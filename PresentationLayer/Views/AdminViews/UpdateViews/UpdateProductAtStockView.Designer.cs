
namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    partial class UpdateProductAtStockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductAtStockView));
            this.comboBoxWarehouseName = new System.Windows.Forms.ComboBox();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelWarehouseName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxWarehouseName
            // 
            this.comboBoxWarehouseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouseName.FormattingEnabled = true;
            this.comboBoxWarehouseName.Location = new System.Drawing.Point(44, 88);
            this.comboBoxWarehouseName.Name = "comboBoxWarehouseName";
            this.comboBoxWarehouseName.Size = new System.Drawing.Size(217, 23);
            this.comboBoxWarehouseName.TabIndex = 9;
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(44, 29);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(217, 23);
            this.comboBoxProductName.TabIndex = 8;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownQuantity.Location = new System.Drawing.Point(44, 148);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(217, 23);
            this.numericUpDownQuantity.TabIndex = 10;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(44, 209);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 23);
            this.dateTimePicker.TabIndex = 11;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(44, 191);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(32, 15);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Дата";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(44, 130);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(168, 15);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Количество товара на складе";
            // 
            // labelWarehouseName
            // 
            this.labelWarehouseName.AutoSize = true;
            this.labelWarehouseName.Location = new System.Drawing.Point(44, 70);
            this.labelWarehouseName.Name = "labelWarehouseName";
            this.labelWarehouseName.Size = new System.Drawing.Size(99, 15);
            this.labelWarehouseName.TabIndex = 15;
            this.labelWarehouseName.Text = "Название склада";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(44, 11);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(99, 15);
            this.labelProductName.TabIndex = 17;
            this.labelProductName.Text = "Название товара";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(44, 267);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(217, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(44, 238);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(217, 23);
            this.buttonAddOrEdit.TabIndex = 14;
            this.buttonAddOrEdit.Text = "Изменить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // UpdateProductAtStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 298);
            this.Controls.Add(this.comboBoxWarehouseName);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelWarehouseName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOrEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateProductAtStockView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о товаре на складе";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWarehouseName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelWarehouseName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddOrEdit;
    }
}