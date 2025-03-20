namespace dbms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.trvData = new System.Windows.Forms.TreeView();
            this.contextMenuOrg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьОрганизациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьОрганизациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьОрганизациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuEmp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьСотрудникаtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСотрудникаtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьСотрудникаtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuAward = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьНаградуtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьНаградуtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьНаградуtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuOrg.SuspendLayout();
            this.contextMenuEmp.SuspendLayout();
            this.contextMenuAward.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(339, 291);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 40);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // trvData
            // 
            this.trvData.AllowDrop = true;
            this.trvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvData.Location = new System.Drawing.Point(12, 12);
            this.trvData.Name = "trvData";
            this.trvData.Size = new System.Drawing.Size(453, 269);
            this.trvData.TabIndex = 1;
            this.trvData.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvData_ItemDrag);
            this.trvData.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvData_NodeMouseClick);
            this.trvData.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvData_DragDrop);
            this.trvData.DragEnter += new System.Windows.Forms.DragEventHandler(this.trvData_DragEnter);
            // 
            // contextMenuOrg
            // 
            this.contextMenuOrg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuOrg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОрганизациюToolStripMenuItem,
            this.изменитьОрганизациюToolStripMenuItem,
            this.toolStripMenuItem1,
            this.удалитьОрганизациюToolStripMenuItem});
            this.contextMenuOrg.Name = "contextMenuOrg";
            this.contextMenuOrg.Size = new System.Drawing.Size(254, 82);
            // 
            // добавитьОрганизациюToolStripMenuItem
            // 
            this.добавитьОрганизациюToolStripMenuItem.Name = "добавитьОрганизациюToolStripMenuItem";
            this.добавитьОрганизациюToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.добавитьОрганизациюToolStripMenuItem.Text = "Добавить организацию...";
            this.добавитьОрганизациюToolStripMenuItem.Click += new System.EventHandler(this.добавитьОрганизациюToolStripMenuItem_Click);
            // 
            // изменитьОрганизациюToolStripMenuItem
            // 
            this.изменитьОрганизациюToolStripMenuItem.Name = "изменитьОрганизациюToolStripMenuItem";
            this.изменитьОрганизациюToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.изменитьОрганизациюToolStripMenuItem.Text = "Изменить...";
            this.изменитьОрганизациюToolStripMenuItem.Click += new System.EventHandler(this.изменитьОрганизациюToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // удалитьОрганизациюToolStripMenuItem
            // 
            this.удалитьОрганизациюToolStripMenuItem.Name = "удалитьОрганизациюToolStripMenuItem";
            this.удалитьОрганизациюToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.удалитьОрганизациюToolStripMenuItem.Text = "Удалить";
            this.удалитьОрганизациюToolStripMenuItem.Click += new System.EventHandler(this.удалитьОрганизациюToolStripMenuItem_Click);
            // 
            // contextMenuEmp
            // 
            this.contextMenuEmp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuEmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаtoolStripMenuItem,
            this.изменитьСотрудникаtoolStripMenuItem,
            this.toolStripSeparator1,
            this.удалитьСотрудникаtoolStripMenuItem});
            this.contextMenuEmp.Name = "contextMenuOrg";
            this.contextMenuEmp.Size = new System.Drawing.Size(238, 82);
            // 
            // добавитьСотрудникаtoolStripMenuItem
            // 
            this.добавитьСотрудникаtoolStripMenuItem.Name = "добавитьСотрудникаtoolStripMenuItem";
            this.добавитьСотрудникаtoolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.добавитьСотрудникаtoolStripMenuItem.Text = "Добавить сотрудника...";
            this.добавитьСотрудникаtoolStripMenuItem.Click += new System.EventHandler(this.добавитьСотрудникаtoolStripMenuItem_Click);
            // 
            // изменитьСотрудникаtoolStripMenuItem
            // 
            this.изменитьСотрудникаtoolStripMenuItem.Name = "изменитьСотрудникаtoolStripMenuItem";
            this.изменитьСотрудникаtoolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.изменитьСотрудникаtoolStripMenuItem.Text = "Изменить...";
            this.изменитьСотрудникаtoolStripMenuItem.Click += new System.EventHandler(this.изменитьСотрудникаtoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // удалитьСотрудникаtoolStripMenuItem
            // 
            this.удалитьСотрудникаtoolStripMenuItem.Name = "удалитьСотрудникаtoolStripMenuItem";
            this.удалитьСотрудникаtoolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.удалитьСотрудникаtoolStripMenuItem.Text = "Удалить";
            this.удалитьСотрудникаtoolStripMenuItem.Click += new System.EventHandler(this.удалитьСотрудникаtoolStripMenuItem_Click);
            // 
            // contextMenuAward
            // 
            this.contextMenuAward.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuAward.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНаградуtoolStripMenuItem,
            this.изменитьНаградуtoolStripMenuItem,
            this.toolStripSeparator2,
            this.удалитьНаградуtoolStripMenuItem});
            this.contextMenuAward.Name = "contextMenuOrg";
            this.contextMenuAward.Size = new System.Drawing.Size(214, 82);
            // 
            // добавитьНаградуtoolStripMenuItem
            // 
            this.добавитьНаградуtoolStripMenuItem.Name = "добавитьНаградуtoolStripMenuItem";
            this.добавитьНаградуtoolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.добавитьНаградуtoolStripMenuItem.Text = "Добавить награду...";
            this.добавитьНаградуtoolStripMenuItem.Click += new System.EventHandler(this.добавитьНаградуtoolStripMenuItem_Click);
            // 
            // изменитьНаградуtoolStripMenuItem
            // 
            this.изменитьНаградуtoolStripMenuItem.Name = "изменитьНаградуtoolStripMenuItem";
            this.изменитьНаградуtoolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.изменитьНаградуtoolStripMenuItem.Text = "Изменить...";
            this.изменитьНаградуtoolStripMenuItem.Click += new System.EventHandler(this.изменитьНаградуtoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // удалитьНаградуtoolStripMenuItem
            // 
            this.удалитьНаградуtoolStripMenuItem.Name = "удалитьНаградуtoolStripMenuItem";
            this.удалитьНаградуtoolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.удалитьНаградуtoolStripMenuItem.Text = "Удалить";
            this.удалитьНаградуtoolStripMenuItem.Click += new System.EventHandler(this.удалитьНаградуtoolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 343);
            this.Controls.Add(this.trvData);
            this.Controls.Add(this.btnLoad);
            this.Name = "MainForm";
            this.Text = "DBMS demo";
            this.contextMenuOrg.ResumeLayout(false);
            this.contextMenuEmp.ResumeLayout(false);
            this.contextMenuAward.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView trvData;
        private System.Windows.Forms.ContextMenuStrip contextMenuOrg;
        private System.Windows.Forms.ToolStripMenuItem добавитьОрганизациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьОрганизациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьОрганизациюToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuEmp;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСотрудникаtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem удалитьСотрудникаtoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuAward;
        private System.Windows.Forms.ToolStripMenuItem добавитьНаградуtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьНаградуtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem удалитьНаградуtoolStripMenuItem;
    }
}