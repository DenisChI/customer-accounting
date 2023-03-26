namespace PresentationLayer.Views.AdminViews.InsertViews
{
    partial class InsertProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertProductView));
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            this.labelProviderName = new System.Windows.Forms.Label();
            this.numericUpDownSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProviderName = new System.Windows.Forms.ComboBox();
            this.labelProductNamingError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(26, 32);
            this.textBoxProductName.MaxLength = 30;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(213, 23);
            this.textBoxProductName.TabIndex = 1;
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoSize = true;
            this.labelSellingPrice.Location = new System.Drawing.Point(25, 86);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(63, 15);
            this.labelSellingPrice.TabIndex = 6;
            this.labelSellingPrice.Text = "Цена за кг";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(25, 14);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(99, 15);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Название товара";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(25, 187);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(214, 23);
            this.buttonAddOrEdit.TabIndex = 6;
            this.buttonAddOrEdit.Text = "Добавить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelProviderName
            // 
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.Location = new System.Drawing.Point(25, 140);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(70, 15);
            this.labelProviderName.TabIndex = 4;
            this.labelProviderName.Text = "Поставщик";
            // 
            // numericUpDownSellingPrice
            // 
            this.numericUpDownSellingPrice.DecimalPlaces = 2;
            this.numericUpDownSellingPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSellingPrice.Location = new System.Drawing.Point(25, 104);
            this.numericUpDownSellingPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSellingPrice.Name = "numericUpDownSellingPrice";
            this.numericUpDownSellingPrice.Size = new System.Drawing.Size(214, 23);
            this.numericUpDownSellingPrice.TabIndex = 2;
            // 
            // comboBoxProviderName
            // 
            this.comboBoxProviderName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProviderName.FormattingEnabled = true;
            this.comboBoxProviderName.Location = new System.Drawing.Point(25, 158);
            this.comboBoxProviderName.Name = "comboBoxProviderName";
            this.comboBoxProviderName.Size = new System.Drawing.Size(214, 23);
            this.comboBoxProviderName.TabIndex = 5;
            // 
            // labelProductNamingError
            // 
            this.labelProductNamingError.AutoSize = true;
            this.labelProductNamingError.Location = new System.Drawing.Point(25, 62);
            this.labelProductNamingError.Name = "labelProductNamingError";
            this.labelProductNamingError.Size = new System.Drawing.Size(0, 15);
            this.labelProductNamingError.TabIndex = 8;
            // 
            // InsertProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 246);
            this.Controls.Add(this.labelProductNamingError);
            this.Controls.Add(this.comboBoxProviderName);
            this.Controls.Add(this.numericUpDownSellingPrice);
            this.Controls.Add(this.labelProviderName);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelSellingPrice);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddOrEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод информации о товаре";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSellingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelSellingPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddOrEdit;
        private System.Windows.Forms.Label labelProviderName;
        private System.Windows.Forms.NumericUpDown numericUpDownSellingPrice;
        private System.Windows.Forms.ComboBox comboBoxProviderName;
        private System.Windows.Forms.Label labelProductNamingError;
    }
}