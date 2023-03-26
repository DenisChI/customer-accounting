namespace PresentationLayer.Views.AdminViews.InsertViews
{
    partial class InsertDiscountView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertDiscountView));
            this.textBoxDiscountName = new System.Windows.Forms.TextBox();
            this.labelDiscountName = new System.Windows.Forms.Label();
            this.labelDiscountPercent = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.labelDiscountNameError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDiscountName
            // 
            this.textBoxDiscountName.Location = new System.Drawing.Point(30, 30);
            this.textBoxDiscountName.MaxLength = 30;
            this.textBoxDiscountName.Name = "textBoxDiscountName";
            this.textBoxDiscountName.Size = new System.Drawing.Size(228, 23);
            this.textBoxDiscountName.TabIndex = 1;
            // 
            // labelDiscountName
            // 
            this.labelDiscountName.AutoSize = true;
            this.labelDiscountName.Location = new System.Drawing.Point(30, 12);
            this.labelDiscountName.Name = "labelDiscountName";
            this.labelDiscountName.Size = new System.Drawing.Size(100, 15);
            this.labelDiscountName.TabIndex = 16;
            this.labelDiscountName.Text = "Название скидки";
            // 
            // labelDiscountPercent
            // 
            this.labelDiscountPercent.AutoSize = true;
            this.labelDiscountPercent.Location = new System.Drawing.Point(30, 90);
            this.labelDiscountPercent.Name = "labelDiscountPercent";
            this.labelDiscountPercent.Size = new System.Drawing.Size(96, 15);
            this.labelDiscountPercent.TabIndex = 17;
            this.labelDiscountPercent.Text = "Процент скидки";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(30, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(228, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(30, 166);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(228, 23);
            this.buttonAddOrEdit.TabIndex = 3;
            this.buttonAddOrEdit.Text = "Добавить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // numericUpDownPercentage
            // 
            this.numericUpDownPercentage.DecimalPlaces = 2;
            this.numericUpDownPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPercentage.Location = new System.Drawing.Point(30, 108);
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            this.numericUpDownPercentage.Size = new System.Drawing.Size(228, 23);
            this.numericUpDownPercentage.TabIndex = 2;
            this.numericUpDownPercentage.Tag = "2";
            // 
            // labelDiscountNameError
            // 
            this.labelDiscountNameError.AutoSize = true;
            this.labelDiscountNameError.Location = new System.Drawing.Point(30, 56);
            this.labelDiscountNameError.Name = "labelDiscountNameError";
            this.labelDiscountNameError.Size = new System.Drawing.Size(0, 15);
            this.labelDiscountNameError.TabIndex = 18;
            // 
            // InsertDiscountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 228);
            this.Controls.Add(this.labelDiscountNameError);
            this.Controls.Add(this.numericUpDownPercentage);
            this.Controls.Add(this.textBoxDiscountName);
            this.Controls.Add(this.labelDiscountName);
            this.Controls.Add(this.labelDiscountPercent);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOrEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertDiscountView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод информации о скидке";
            this.Click += new System.EventHandler(this.ButtonAdd_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDiscountName;
        private System.Windows.Forms.Label labelDiscountName;
        private System.Windows.Forms.Label labelDiscountPercent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddOrEdit;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        private System.Windows.Forms.Label labelDiscountNameError;
    }
}