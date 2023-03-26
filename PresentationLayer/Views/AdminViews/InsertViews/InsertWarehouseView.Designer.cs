
namespace PresentationLayer.Views.AdminViews.InsertViews
{
    partial class InsertWarehouseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertWarehouseView));
            this.textBoxWarehouserFullName = new System.Windows.Forms.TextBox();
            this.textBoxWarehouseName = new System.Windows.Forms.TextBox();
            this.labelWarehouserFullName = new System.Windows.Forms.Label();
            this.labelWarehouseName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            this.labelWarehouseNameError = new System.Windows.Forms.Label();
            this.labelWarehouserFullNameError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxWarehouserFullName
            // 
            this.textBoxWarehouserFullName.Location = new System.Drawing.Point(32, 100);
            this.textBoxWarehouserFullName.MaxLength = 50;
            this.textBoxWarehouserFullName.Name = "textBoxWarehouserFullName";
            this.textBoxWarehouserFullName.Size = new System.Drawing.Size(245, 23);
            this.textBoxWarehouserFullName.TabIndex = 2;
            this.textBoxWarehouserFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWarehouserFullName_KeyPress);
            // 
            // textBoxWarehouseName
            // 
            this.textBoxWarehouseName.Location = new System.Drawing.Point(32, 33);
            this.textBoxWarehouseName.MaxLength = 50;
            this.textBoxWarehouseName.Name = "textBoxWarehouseName";
            this.textBoxWarehouseName.Size = new System.Drawing.Size(245, 23);
            this.textBoxWarehouseName.TabIndex = 1;
            // 
            // labelWarehouserFullName
            // 
            this.labelWarehouserFullName.AutoSize = true;
            this.labelWarehouserFullName.Location = new System.Drawing.Point(32, 82);
            this.labelWarehouserFullName.Name = "labelWarehouserFullName";
            this.labelWarehouserFullName.Size = new System.Drawing.Size(105, 15);
            this.labelWarehouserFullName.TabIndex = 6;
            this.labelWarehouserFullName.Text = "ФИО кладовщика";
            // 
            // labelWarehouseName
            // 
            this.labelWarehouseName.AutoSize = true;
            this.labelWarehouseName.Location = new System.Drawing.Point(32, 15);
            this.labelWarehouseName.Name = "labelWarehouseName";
            this.labelWarehouseName.Size = new System.Drawing.Size(99, 15);
            this.labelWarehouseName.TabIndex = 7;
            this.labelWarehouseName.Text = "Название склада";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(32, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(245, 21);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(32, 160);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(245, 25);
            this.buttonAddOrEdit.TabIndex = 3;
            this.buttonAddOrEdit.Text = "Добавить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelWarehouseNameError
            // 
            this.labelWarehouseNameError.AutoSize = true;
            this.labelWarehouseNameError.Location = new System.Drawing.Point(32, 63);
            this.labelWarehouseNameError.Name = "labelWarehouseNameError";
            this.labelWarehouseNameError.Size = new System.Drawing.Size(0, 15);
            this.labelWarehouseNameError.TabIndex = 8;
            // 
            // labelWarehouserFullNameError
            // 
            this.labelWarehouserFullNameError.AutoSize = true;
            this.labelWarehouserFullNameError.Location = new System.Drawing.Point(32, 126);
            this.labelWarehouserFullNameError.Name = "labelWarehouserFullNameError";
            this.labelWarehouserFullNameError.Size = new System.Drawing.Size(0, 15);
            this.labelWarehouserFullNameError.TabIndex = 8;
            // 
            // InsertWarehouseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 223);
            this.Controls.Add(this.labelWarehouserFullNameError);
            this.Controls.Add(this.labelWarehouseNameError);
            this.Controls.Add(this.textBoxWarehouserFullName);
            this.Controls.Add(this.textBoxWarehouseName);
            this.Controls.Add(this.labelWarehouserFullName);
            this.Controls.Add(this.labelWarehouseName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOrEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertWarehouseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод информации о складе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWarehouserFullName;
        private System.Windows.Forms.TextBox textBoxWarehouseName;
        private System.Windows.Forms.Label labelWarehouserFullName;
        private System.Windows.Forms.Label labelWarehouseName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddOrEdit;
        private System.Windows.Forms.Label labelWarehouseNameError;
        private System.Windows.Forms.Label labelWarehouserFullNameError;
    }
}