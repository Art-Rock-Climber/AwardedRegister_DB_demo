namespace dbms
{
    partial class EditForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCNL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(213, 204);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 37);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Ок";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCNL
            // 
            this.btnCNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCNL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCNL.Location = new System.Drawing.Point(323, 204);
            this.btnCNL.Name = "btnCNL";
            this.btnCNL.Size = new System.Drawing.Size(97, 37);
            this.btnCNL.TabIndex = 1;
            this.btnCNL.Text = "Отмена";
            this.btnCNL.UseVisualStyleBackColor = true;
            this.btnCNL.Click += new System.EventHandler(this.btnCNL_Click);
            // 
            // EditForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCNL;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.btnCNL);
            this.Controls.Add(this.btnOK);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCNL;
    }
}