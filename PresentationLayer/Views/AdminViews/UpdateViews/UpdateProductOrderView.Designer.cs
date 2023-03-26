
namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    partial class UpdateProductOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductOrderView));
            this.comboBoxDiscounts = new System.Windows.Forms.ComboBox();
            this.comboBoxClientFullName = new System.Windows.Forms.ComboBox();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.numericUpDownProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelProductQuantity = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxOrderState = new System.Windows.Forms.ComboBox();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.labelOrderState = new System.Windows.Forms.Label();
            this.labelPaymentType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDiscountPercent = new System.Windows.Forms.Label();
            this.labelClientFullName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDiscounts
            // 
            this.comboBoxDiscounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscounts.FormattingEnabled = true;
            this.comboBoxDiscounts.Location = new System.Drawing.Point(166, 270);
            this.comboBoxDiscounts.Name = "comboBoxDiscounts";
            this.comboBoxDiscounts.Size = new System.Drawing.Size(195, 23);
            this.comboBoxDiscounts.TabIndex = 37;
            // 
            // comboBoxClientFullName
            // 
            this.comboBoxClientFullName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientFullName.FormattingEnabled = true;
            this.comboBoxClientFullName.Location = new System.Drawing.Point(166, 69);
            this.comboBoxClientFullName.Name = "comboBoxClientFullName";
            this.comboBoxClientFullName.Size = new System.Drawing.Size(195, 23);
            this.comboBoxClientFullName.TabIndex = 33;
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(166, 20);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(195, 23);
            this.comboBoxProductName.TabIndex = 48;
            // 
            // numericUpDownProductQuantity
            // 
            this.numericUpDownProductQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownProductQuantity.Location = new System.Drawing.Point(166, 119);
            this.numericUpDownProductQuantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProductQuantity.Name = "numericUpDownProductQuantity";
            this.numericUpDownProductQuantity.Size = new System.Drawing.Size(195, 23);
            this.numericUpDownProductQuantity.TabIndex = 34;
            this.numericUpDownProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelProductQuantity
            // 
            this.labelProductQuantity.AutoSize = true;
            this.labelProductQuantity.Location = new System.Drawing.Point(23, 127);
            this.labelProductQuantity.Name = "labelProductQuantity";
            this.labelProductQuantity.Size = new System.Drawing.Size(112, 15);
            this.labelProductQuantity.TabIndex = 47;
            this.labelProductQuantity.Text = "Количество товара";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(166, 325);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 23);
            this.dateTimePicker.TabIndex = 38;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(23, 325);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(32, 15);
            this.labelDate.TabIndex = 46;
            this.labelDate.Text = "Дата";
            // 
            // comboBoxOrderState
            // 
            this.comboBoxOrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderState.FormattingEnabled = true;
            this.comboBoxOrderState.Items.AddRange(new object[] {
            "Подтверждён",
            "Возвращён",
            "В процессе доставки",
            "Завершён"});
            this.comboBoxOrderState.Location = new System.Drawing.Point(166, 220);
            this.comboBoxOrderState.Name = "comboBoxOrderState";
            this.comboBoxOrderState.Size = new System.Drawing.Size(197, 23);
            this.comboBoxOrderState.TabIndex = 36;
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Наличными",
            "Картой"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(166, 170);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(197, 23);
            this.comboBoxPaymentType.TabIndex = 35;
            // 
            // labelOrderState
            // 
            this.labelOrderState.AutoSize = true;
            this.labelOrderState.Location = new System.Drawing.Point(23, 220);
            this.labelOrderState.Name = "labelOrderState";
            this.labelOrderState.Size = new System.Drawing.Size(103, 15);
            this.labelOrderState.TabIndex = 40;
            this.labelOrderState.Text = "Состояние заказа";
            // 
            // labelPaymentType
            // 
            this.labelPaymentType.AutoSize = true;
            this.labelPaymentType.Location = new System.Drawing.Point(23, 170);
            this.labelPaymentType.Name = "labelPaymentType";
            this.labelPaymentType.Size = new System.Drawing.Size(71, 15);
            this.labelPaymentType.TabIndex = 41;
            this.labelPaymentType.Text = "Тип оплаты";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(23, 377);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(82, 15);
            this.labelPrice.TabIndex = 42;
            this.labelPrice.Text = "Сумма заказа";
            // 
            // labelDiscountPercent
            // 
            this.labelDiscountPercent.AutoSize = true;
            this.labelDiscountPercent.Location = new System.Drawing.Point(23, 270);
            this.labelDiscountPercent.Name = "labelDiscountPercent";
            this.labelDiscountPercent.Size = new System.Drawing.Size(96, 15);
            this.labelDiscountPercent.TabIndex = 43;
            this.labelDiscountPercent.Text = "Процент скидки";
            // 
            // labelClientFullName
            // 
            this.labelClientFullName.AutoSize = true;
            this.labelClientFullName.Location = new System.Drawing.Point(23, 72);
            this.labelClientFullName.Name = "labelClientFullName";
            this.labelClientFullName.Size = new System.Drawing.Size(81, 15);
            this.labelClientFullName.TabIndex = 44;
            this.labelClientFullName.Text = "ФИО клиента";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(23, 20);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(99, 15);
            this.labelProductName.TabIndex = 45;
            this.labelProductName.Text = "Название товара";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(25, 437);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(340, 23);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(25, 406);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(338, 23);
            this.buttonAddOrEdit.TabIndex = 49;
            this.buttonAddOrEdit.Text = "Изменить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPrice.Location = new System.Drawing.Point(166, 369);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(195, 23);
            this.numericUpDownPrice.TabIndex = 34;
            // 
            // UpdateProductOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 464);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOrEdit);
            this.Controls.Add(this.comboBoxDiscounts);
            this.Controls.Add(this.comboBoxClientFullName);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownProductQuantity);
            this.Controls.Add(this.labelProductQuantity);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxOrderState);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Controls.Add(this.labelOrderState);
            this.Controls.Add(this.labelPaymentType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDiscountPercent);
            this.Controls.Add(this.labelClientFullName);
            this.Controls.Add(this.labelProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateProductOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о заказе";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiscounts;
        private System.Windows.Forms.ComboBox comboBoxClientFullName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.NumericUpDown numericUpDownProductQuantity;
        private System.Windows.Forms.Label labelProductQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxOrderState;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label labelOrderState;
        private System.Windows.Forms.Label labelPaymentType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDiscountPercent;
        private System.Windows.Forms.Label labelClientFullName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddOrEdit;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
    }
}