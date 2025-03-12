namespace dbms.editForms
{
    partial class AwardForm
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
            this.txtDate = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAwarded = new System.Windows.Forms.Label();
            this.comboBoxAwarded = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(45, 89);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(39, 16);
            this.txtDate.TabIndex = 10;
            this.txtDate.Text = "Дата";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(162, 40);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(220, 22);
            this.textBoxReason.TabIndex = 9;
            // 
            // txtReason
            // 
            this.txtReason.AutoSize = true;
            this.txtReason.Location = new System.Drawing.Point(45, 43);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(80, 16);
            this.txtReason.TabIndex = 8;
            this.txtReason.Text = "Основание";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(162, 83);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Value = new System.DateTime(2025, 3, 12, 16, 4, 43, 0);
            // 
            // txtAwarded
            // 
            this.txtAwarded.AutoSize = true;
            this.txtAwarded.Location = new System.Drawing.Point(45, 130);
            this.txtAwarded.Name = "txtAwarded";
            this.txtAwarded.Size = new System.Drawing.Size(105, 16);
            this.txtAwarded.TabIndex = 13;
            this.txtAwarded.Text = "Награждённый";
            // 
            // comboBoxAwarded
            // 
            this.comboBoxAwarded.FormattingEnabled = true;
            this.comboBoxAwarded.Location = new System.Drawing.Point(162, 127);
            this.comboBoxAwarded.Name = "comboBoxAwarded";
            this.comboBoxAwarded.Size = new System.Drawing.Size(220, 24);
            this.comboBoxAwarded.TabIndex = 15;
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.comboBoxAwarded);
            this.Controls.Add(this.txtAwarded);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.txtReason);
            this.Name = "AwardForm";
            this.Text = "AwardForm";
            this.Controls.SetChildIndex(this.txtReason, 0);
            this.Controls.SetChildIndex(this.textBoxReason, 0);
            this.Controls.SetChildIndex(this.txtDate, 0);
            this.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.Controls.SetChildIndex(this.txtAwarded, 0);
            this.Controls.SetChildIndex(this.comboBoxAwarded, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label txtReason;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label txtAwarded;
        private System.Windows.Forms.ComboBox comboBoxAwarded;
    }
}