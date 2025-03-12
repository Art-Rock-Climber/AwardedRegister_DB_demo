namespace dbms
{
    partial class EmployeeForm
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
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.Label();
            this.textBoxMidName = new System.Windows.Forms.TextBox();
            this.txtMidName = new System.Windows.Forms.Label();
            this.txtOrg = new System.Windows.Forms.Label();
            this.comboBoxOrg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(149, 30);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(243, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(38, 33);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(66, 16);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Text = "Фамилия";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(149, 66);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(243, 22);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(38, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(33, 16);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Text = "Имя";
            // 
            // textBoxMidName
            // 
            this.textBoxMidName.Location = new System.Drawing.Point(149, 103);
            this.textBoxMidName.Name = "textBoxMidName";
            this.textBoxMidName.Size = new System.Drawing.Size(243, 22);
            this.textBoxMidName.TabIndex = 9;
            // 
            // txtMidName
            // 
            this.txtMidName.AutoSize = true;
            this.txtMidName.Location = new System.Drawing.Point(38, 106);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.Size = new System.Drawing.Size(70, 16);
            this.txtMidName.TabIndex = 8;
            this.txtMidName.Text = "Отчество";
            // 
            // txtOrg
            // 
            this.txtOrg.AutoSize = true;
            this.txtOrg.Location = new System.Drawing.Point(38, 145);
            this.txtOrg.Name = "txtOrg";
            this.txtOrg.Size = new System.Drawing.Size(94, 16);
            this.txtOrg.TabIndex = 10;
            this.txtOrg.Text = "Организация";
            // 
            // comboBoxOrg
            // 
            this.comboBoxOrg.FormattingEnabled = true;
            this.comboBoxOrg.Location = new System.Drawing.Point(149, 142);
            this.comboBoxOrg.Name = "comboBoxOrg";
            this.comboBoxOrg.Size = new System.Drawing.Size(243, 24);
            this.comboBoxOrg.TabIndex = 11;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.comboBoxOrg);
            this.Controls.Add(this.txtOrg);
            this.Controls.Add(this.textBoxMidName);
            this.Controls.Add(this.txtMidName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.txtLastName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.textBoxLastName, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.textBoxFirstName, 0);
            this.Controls.SetChildIndex(this.txtMidName, 0);
            this.Controls.SetChildIndex(this.textBoxMidName, 0);
            this.Controls.SetChildIndex(this.txtOrg, 0);
            this.Controls.SetChildIndex(this.comboBoxOrg, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label txtFirstName;
        private System.Windows.Forms.TextBox textBoxMidName;
        private System.Windows.Forms.Label txtMidName;
        private System.Windows.Forms.Label txtOrg;
        private System.Windows.Forms.ComboBox comboBoxOrg;
    }
}