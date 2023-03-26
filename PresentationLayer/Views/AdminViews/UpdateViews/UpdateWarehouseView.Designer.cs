
namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    partial class UpdateWarehouseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWarehouseView));
            this.labelWarehouserFullNameError = new System.Windows.Forms.Label();
            this.labelWarehouseNameError = new System.Windows.Forms.Label();
            this.textBoxWarehouserFullName = new System.Windows.Forms.TextBox();
            this.textBoxWarehouseName = new System.Windows.Forms.TextBox();
            this.labelWarehouserFullName = new System.Windows.Forms.Label();
            this.labelWarehouseName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddOrEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWarehouserFullNameError
            // 
            this.labelWarehouserFullNameError.AutoSize = true;
            this.labelWarehouserFullNameError.Location = new System.Drawing.Point(40, 139);
            this.labelWarehouserFullNameError.Name = "labelWarehouserFullNameError";
            this.labelWarehouserFullNameError.Size = new System.Drawing.Size(0, 15);
            this.labelWarehouserFullNameError.TabIndex = 15;
            // 
            // labelWarehouseNameError
            // 
            this.labelWarehouseNameError.AutoSize = true;
            this.labelWarehouseNameError.Location = new System.Drawing.Point(40, 76);
            this.labelWarehouseNameError.Name = "labelWarehouseNameError";
            this.labelWarehouseNameError.Size = new System.Drawing.Size(0, 15);
            this.labelWarehouseNameError.TabIndex = 16;
            // 
            // textBoxWarehouserFullName
            // 
            this.textBoxWarehouserFullName.Location = new System.Drawing.Point(40, 113);
            this.textBoxWarehouserFullName.MaxLength = 50;
            this.textBoxWarehouserFullName.Name = "textBoxWarehouserFullName";
            this.textBoxWarehouserFullName.Size = new System.Drawing.Size(245, 23);
            this.textBoxWarehouserFullName.TabIndex = 10;
            this.textBoxWarehouserFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWarehouserFullName_KeyPress);
            // 
            // textBoxWarehouseName
            // 
            this.textBoxWarehouseName.Location = new System.Drawing.Point(40, 46);
            this.textBoxWarehouseName.MaxLength = 50;
            this.textBoxWarehouseName.Name = "textBoxWarehouseName";
            this.textBoxWarehouseName.Size = new System.Drawing.Size(245, 23);
            this.textBoxWarehouseName.TabIndex = 9;
            // 
            // labelWarehouserFullName
            // 
            this.labelWarehouserFullName.AutoSize = true;
            this.labelWarehouserFullName.Location = new System.Drawing.Point(40, 95);
            this.labelWarehouserFullName.Name = "labelWarehouserFullName";
            this.labelWarehouserFullName.Size = new System.Drawing.Size(105, 15);
            this.labelWarehouserFullName.TabIndex = 13;
            this.labelWarehouserFullName.Text = "ФИО кладовщика";
            // 
            // labelWarehouseName
            // 
            this.labelWarehouseName.AutoSize = true;
            this.labelWarehouseName.Location = new System.Drawing.Point(40, 28);
            this.labelWarehouseName.Name = "labelWarehouseName";
            this.labelWarehouseName.Size = new System.Drawing.Size(99, 15);
            this.labelWarehouseName.TabIndex = 14;
            this.labelWarehouseName.Text = "Название склада";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(40, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(245, 21);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddOrEdit
            // 
            this.buttonAddOrEdit.Location = new System.Drawing.Point(40, 173);
            this.buttonAddOrEdit.Name = "buttonAddOrEdit";
            this.buttonAddOrEdit.Size = new System.Drawing.Size(245, 25);
            this.buttonAddOrEdit.TabIndex = 11;
            this.buttonAddOrEdit.Text = "Изменить";
            this.buttonAddOrEdit.UseVisualStyleBackColor = true;
            this.buttonAddOrEdit.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // UpdateWarehouseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 237);
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
            this.Name = "UpdateWarehouseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о складе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWarehouserFullNameError;
        private System.Windows.Forms.Label labelWarehouseNameError;
        private System.Windows.Forms.TextBox textBoxWarehouserFullName;
        private System.Windows.Forms.TextBox textBoxWarehouseName;
        private System.Windows.Forms.Label labelWarehouserFullName;
        private System.Windows.Forms.Label labelWarehouseName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddOrEdit;
    }
}