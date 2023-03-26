
namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    partial class UpdateProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductView));
            this.labelProductNameError = new System.Windows.Forms.Label();
            this.comboBoxProviderName = new System.Windows.Forms.ComboBox();
            this.numericUpDownSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.labelProviderName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductNameError
            // 
            this.labelProductNameError.AutoSize = true;
            this.labelProductNameError.Location = new System.Drawing.Point(25, 61);
            this.labelProductNameError.Name = "labelProductNameError";
            this.labelProductNameError.Size = new System.Drawing.Size(0, 15);
            this.labelProductNameError.TabIndex = 17;
            // 
            // comboBoxProviderName
            // 
            this.comboBoxProviderName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProviderName.FormattingEnabled = true;
            this.comboBoxProviderName.Location = new System.Drawing.Point(25, 160);
            this.comboBoxProviderName.Name = "comboBoxProviderName";
            this.comboBoxProviderName.Size = new System.Drawing.Size(214, 23);
            this.comboBoxProviderName.TabIndex = 12;
            // 
            // numericUpDownSellingPrice
            // 
            this.numericUpDownSellingPrice.DecimalPlaces = 2;
            this.numericUpDownSellingPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSellingPrice.Location = new System.Drawing.Point(25, 101);
            this.numericUpDownSellingPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSellingPrice.Name = "numericUpDownSellingPrice";
            this.numericUpDownSellingPrice.Size = new System.Drawing.Size(214, 23);
            this.numericUpDownSellingPrice.TabIndex = 10;
            // 
            // labelProviderName
            // 
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.Location = new System.Drawing.Point(25, 142);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(70, 15);
            this.labelProviderName.TabIndex = 11;
            this.labelProviderName.Text = "Поставщик";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(26, 31);
            this.textBoxProductName.MaxLength = 30;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(213, 23);
            this.textBoxProductName.TabIndex = 9;
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoSize = true;
            this.labelSellingPrice.Location = new System.Drawing.Point(25, 83);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(63, 15);
            this.labelSellingPrice.TabIndex = 13;
            this.labelSellingPrice.Text = "Цена за кг";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(25, 13);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(99, 15);
            this.labelProductName.TabIndex = 15;
            this.labelProductName.Text = "Название товара";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(25, 189);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(214, 23);
            this.buttonAddOrEdit.TabIndex = 14;
            this.buttonAddOrEdit.Text = "Изменить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // UpdateProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 251);
            this.Controls.Add(this.labelProductNameError);
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
            this.Name = "UpdateProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о товаре";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSellingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductNameError;
        private System.Windows.Forms.ComboBox comboBoxProviderName;
        private System.Windows.Forms.NumericUpDown numericUpDownSellingPrice;
        private System.Windows.Forms.Label labelProviderName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelSellingPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddOrEdit;
    }
}