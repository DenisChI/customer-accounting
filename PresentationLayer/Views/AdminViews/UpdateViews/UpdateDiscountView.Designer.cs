namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    partial class UpdataDataDiscountView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdataDataDiscountView));
            this.labelDiscountNameError = new System.Windows.Forms.Label();
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.textBoxDiscountName = new System.Windows.Forms.TextBox();
            this.labelDiscountName = new System.Windows.Forms.Label();
            this.labelDiscountPercent = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDiscountNameError
            // 
            this.labelDiscountNameError.AutoSize = true;
            this.labelDiscountNameError.Location = new System.Drawing.Point(29, 67);
            this.labelDiscountNameError.Name = "labelDiscountNameError";
            this.labelDiscountNameError.Size = new System.Drawing.Size(0, 15);
            this.labelDiscountNameError.TabIndex = 25;
            // 
            // numericUpDownPercentage
            // 
            this.numericUpDownPercentage.DecimalPlaces = 2;
            this.numericUpDownPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPercentage.Location = new System.Drawing.Point(29, 119);
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            this.numericUpDownPercentage.Size = new System.Drawing.Size(228, 23);
            this.numericUpDownPercentage.TabIndex = 20;
            this.numericUpDownPercentage.Tag = "2";
            // 
            // textBoxDiscountName
            // 
            this.textBoxDiscountName.Location = new System.Drawing.Point(29, 41);
            this.textBoxDiscountName.MaxLength = 30;
            this.textBoxDiscountName.Name = "textBoxDiscountName";
            this.textBoxDiscountName.Size = new System.Drawing.Size(228, 23);
            this.textBoxDiscountName.TabIndex = 19;
            // 
            // labelDiscountName
            // 
            this.labelDiscountName.AutoSize = true;
            this.labelDiscountName.Location = new System.Drawing.Point(29, 23);
            this.labelDiscountName.Name = "labelDiscountName";
            this.labelDiscountName.Size = new System.Drawing.Size(100, 15);
            this.labelDiscountName.TabIndex = 23;
            this.labelDiscountName.Text = "Название скидки";
            // 
            // labelDiscountPercent
            // 
            this.labelDiscountPercent.AutoSize = true;
            this.labelDiscountPercent.Location = new System.Drawing.Point(29, 101);
            this.labelDiscountPercent.Name = "labelDiscountPercent";
            this.labelDiscountPercent.Size = new System.Drawing.Size(96, 15);
            this.labelDiscountPercent.TabIndex = 24;
            this.labelDiscountPercent.Text = "Процент скидки";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(29, 206);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(228, 23);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(29, 177);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(228, 23);
            this.buttonAddOrEdit.TabIndex = 21;
            this.buttonAddOrEdit.Text = "Изменить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // UpdataDataDiscountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 240);
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
            this.Name = "UpdataDataDiscountView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о скидке";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDiscountNameError;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        private System.Windows.Forms.TextBox textBoxDiscountName;
        private System.Windows.Forms.Label labelDiscountName;
        private System.Windows.Forms.Label labelDiscountPercent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddOrEdit;
    }
}