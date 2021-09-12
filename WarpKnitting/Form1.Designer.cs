namespace WarpKnitting
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.买丝入库ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.染厂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.染厂出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.常用型号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.染厂ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.买丝入库ToolStripMenuItem1,
            this.toolStripSeparator2,
            this.出库ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.查询ToolStripMenuItem,
            this.报表ToolStripMenuItem});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.ToolStripMenuItem.Text = "本厂";
            // 
            // 买丝入库ToolStripMenuItem1
            // 
            this.买丝入库ToolStripMenuItem1.Name = "买丝入库ToolStripMenuItem1";
            this.买丝入库ToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.买丝入库ToolStripMenuItem1.Text = "买丝入库";
            this.买丝入库ToolStripMenuItem1.Click += new System.EventHandler(this.买丝入库);
            // 
            // 出库ToolStripMenuItem
            // 
            this.出库ToolStripMenuItem.Name = "出库ToolStripMenuItem";
            this.出库ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.出库ToolStripMenuItem.Text = "卖白坯布出厂";
            this.出库ToolStripMenuItem.Click += new System.EventHandler(this.卖白坯布出厂);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem1.Text = "货交染厂出厂";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.货交染厂出厂);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.本厂查询);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // 染厂ToolStripMenuItem
            // 
            this.染厂ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.染厂出库ToolStripMenuItem,
            this.toolStripSeparator3,
            this.查询ToolStripMenuItem1,
            this.报表ToolStripMenuItem1});
            this.染厂ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.染厂ToolStripMenuItem.Name = "染厂ToolStripMenuItem";
            this.染厂ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.染厂ToolStripMenuItem.Text = "染厂";
            // 
            // 染厂出库ToolStripMenuItem
            // 
            this.染厂出库ToolStripMenuItem.Name = "染厂出库ToolStripMenuItem";
            this.染厂出库ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.染厂出库ToolStripMenuItem.Text = "染厂出厂";
            this.染厂出库ToolStripMenuItem.Click += new System.EventHandler(this.染厂出库);
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.查询ToolStripMenuItem1.Text = "染厂查询";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.染厂查询);
            // 
            // 报表ToolStripMenuItem1
            // 
            this.报表ToolStripMenuItem1.Name = "报表ToolStripMenuItem1";
            this.报表ToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.报表ToolStripMenuItem1.Text = "报表";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户ToolStripMenuItem,
            this.常用型号ToolStripMenuItem});
            this.设置ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 客户ToolStripMenuItem
            // 
            this.客户ToolStripMenuItem.Name = "客户ToolStripMenuItem";
            this.客户ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.客户ToolStripMenuItem.Text = "客户清单";
            this.客户ToolStripMenuItem.Click += new System.EventHandler(this.客户);
            // 
            // 常用型号ToolStripMenuItem
            // 
            this.常用型号ToolStripMenuItem.Name = "常用型号ToolStripMenuItem";
            this.常用型号ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.常用型号ToolStripMenuItem.Text = "常用型号";
            this.常用型号ToolStripMenuItem.Click += new System.EventHandler(this.常用型号);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WarpKnitting.Properties.Resources.timg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "经编管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 买丝入库ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 染厂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 染厂出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 常用型号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

