namespace UCFHelper {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSwitch = new System.Windows.Forms.TextBox();
            this.textBoxLed = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示样例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExample1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExample2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认管脚列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artix7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xC7A100TToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fGG484ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.配置管脚顺序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管脚文件类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.作者shaoyyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailshaoyysakuragamingcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.可解决360误报希望能联系我ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxButton = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSeg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxClk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFalse = new System.Windows.Forms.TextBox();
            this.menuItemExample3 = new System.Windows.Forms.ToolStripMenuItem();
            this.codeTypeUcfMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeTypeXdcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入(开关)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "输出(LED)：";
            // 
            // textBoxSwitch
            // 
            this.textBoxSwitch.Location = new System.Drawing.Point(157, 103);
            this.textBoxSwitch.Name = "textBoxSwitch";
            this.textBoxSwitch.Size = new System.Drawing.Size(298, 25);
            this.textBoxSwitch.TabIndex = 2;
            this.textBoxSwitch.TextChanged += new System.EventHandler(this.OnInputOutputTextBoxChanged);
            // 
            // textBoxLed
            // 
            this.textBoxLed.Location = new System.Drawing.Point(157, 147);
            this.textBoxLed.Name = "textBoxLed";
            this.textBoxLed.Size = new System.Drawing.Size(298, 25);
            this.textBoxLed.TabIndex = 3;
            this.textBoxLed.TextChanged += new System.EventHandler(this.OnInputOutputTextBoxChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(491, 36);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(445, 452);
            this.textBoxResult.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.编辑ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(970, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示样例ToolStripMenuItem,
            this.menuItemExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem1.Text = "文件";
            // 
            // 显示样例ToolStripMenuItem
            // 
            this.显示样例ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExample1,
            this.menuItemExample2,
            this.menuItemExample3});
            this.显示样例ToolStripMenuItem.Name = "显示样例ToolStripMenuItem";
            this.显示样例ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.显示样例ToolStripMenuItem.Text = "显示样例";
            // 
            // menuItemExample1
            // 
            this.menuItemExample1.Name = "menuItemExample1";
            this.menuItemExample1.Size = new System.Drawing.Size(216, 26);
            this.menuItemExample1.Text = "样例1";
            this.menuItemExample1.Click += new System.EventHandler(this.OnExampleMenuItemDown);
            // 
            // menuItemExample2
            // 
            this.menuItemExample2.Name = "menuItemExample2";
            this.menuItemExample2.Size = new System.Drawing.Size(216, 26);
            this.menuItemExample2.Text = "样例2";
            this.menuItemExample2.Click += new System.EventHandler(this.OnExampleMenuItemDown);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(216, 26);
            this.menuItemExit.Text = "退出";
            this.menuItemExit.Click += new System.EventHandler(this.OnExitMenuItemDown);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认管脚列表ToolStripMenuItem,
            this.配置管脚顺序ToolStripMenuItem,
            this.管脚文件类型ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 默认管脚列表ToolStripMenuItem
            // 
            this.默认管脚列表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artix7ToolStripMenuItem});
            this.默认管脚列表ToolStripMenuItem.Name = "默认管脚列表ToolStripMenuItem";
            this.默认管脚列表ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.默认管脚列表ToolStripMenuItem.Text = "默认管脚：";
            // 
            // artix7ToolStripMenuItem
            // 
            this.artix7ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xC7A100TToolStripMenuItem1});
            this.artix7ToolStripMenuItem.Name = "artix7ToolStripMenuItem";
            this.artix7ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.artix7ToolStripMenuItem.Text = "Artix7";
            // 
            // xC7A100TToolStripMenuItem1
            // 
            this.xC7A100TToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fGG484ToolStripMenuItem1});
            this.xC7A100TToolStripMenuItem1.Name = "xC7A100TToolStripMenuItem1";
            this.xC7A100TToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.xC7A100TToolStripMenuItem1.Text = "XC7A100T";
            // 
            // fGG484ToolStripMenuItem1
            // 
            this.fGG484ToolStripMenuItem1.Name = "fGG484ToolStripMenuItem1";
            this.fGG484ToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.fGG484ToolStripMenuItem1.Text = "FGG484";
            // 
            // 配置管脚顺序ToolStripMenuItem
            // 
            this.配置管脚顺序ToolStripMenuItem.Name = "配置管脚顺序ToolStripMenuItem";
            this.配置管脚顺序ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.配置管脚顺序ToolStripMenuItem.Text = "//配置管脚顺序";
            // 
            // 管脚文件类型ToolStripMenuItem
            // 
            this.管脚文件类型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeTypeUcfMenuItem,
            this.codeTypeXdcMenuItem});
            this.管脚文件类型ToolStripMenuItem.Name = "管脚文件类型ToolStripMenuItem";
            this.管脚文件类型ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.管脚文件类型ToolStripMenuItem.Text = "管脚文件类型";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemVersion,
            this.作者shaoyyToolStripMenuItem,
            this.mailshaoyysakuragamingcomToolStripMenuItem,
            this.可解决360误报希望能联系我ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // menuItemVersion
            // 
            this.menuItemVersion.Name = "menuItemVersion";
            this.menuItemVersion.Size = new System.Drawing.Size(321, 26);
            this.menuItemVersion.Text = "Version:";
            // 
            // 作者shaoyyToolStripMenuItem
            // 
            this.作者shaoyyToolStripMenuItem.Name = "作者shaoyyToolStripMenuItem";
            this.作者shaoyyToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.作者shaoyyToolStripMenuItem.Text = "Auther:shaoyy";
            // 
            // mailshaoyysakuragamingcomToolStripMenuItem
            // 
            this.mailshaoyysakuragamingcomToolStripMenuItem.Name = "mailshaoyysakuragamingcomToolStripMenuItem";
            this.mailshaoyysakuragamingcomToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mailshaoyysakuragamingcomToolStripMenuItem.Text = "Mail:shaoyy@sakuragaming.org";
            // 
            // 可解决360误报希望能联系我ToolStripMenuItem
            // 
            this.可解决360误报希望能联系我ToolStripMenuItem.Name = "可解决360误报希望能联系我ToolStripMenuItem";
            this.可解决360误报希望能联系我ToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.可解决360误报希望能联系我ToolStripMenuItem.Text = "可解决360误报希望能联系我";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "输入(按钮)：";
            // 
            // textBoxButton
            // 
            this.textBoxButton.Location = new System.Drawing.Point(157, 191);
            this.textBoxButton.Name = "textBoxButton";
            this.textBoxButton.Size = new System.Drawing.Size(298, 25);
            this.textBoxButton.TabIndex = 7;
            this.textBoxButton.TextChanged += new System.EventHandler(this.OnInputOutputTextBoxChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "输出(数码管)：";
            // 
            // textBoxSeg
            // 
            this.textBoxSeg.Location = new System.Drawing.Point(157, 236);
            this.textBoxSeg.Name = "textBoxSeg";
            this.textBoxSeg.Size = new System.Drawing.Size(298, 25);
            this.textBoxSeg.TabIndex = 9;
            this.textBoxSeg.TextChanged += new System.EventHandler(this.OnInputOutputTextBoxChanged);
            this.textBoxSeg.DoubleClick += new System.EventHandler(this.textBoxSeg_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "系统(时钟)：";
            // 
            // textBoxClk
            // 
            this.textBoxClk.Location = new System.Drawing.Point(157, 292);
            this.textBoxClk.Name = "textBoxClk";
            this.textBoxClk.Size = new System.Drawing.Size(149, 25);
            this.textBoxClk.TabIndex = 11;
            this.textBoxClk.TextChanged += new System.EventHandler(this.OnInputOutputTextBoxChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "CLOCK_DEDICATED_ROUTE FALSE:";
            // 
            // textBoxFalse
            // 
            this.textBoxFalse.Location = new System.Drawing.Point(44, 377);
            this.textBoxFalse.Name = "textBoxFalse";
            this.textBoxFalse.Size = new System.Drawing.Size(411, 25);
            this.textBoxFalse.TabIndex = 13;
            this.textBoxFalse.TextChanged += new System.EventHandler(this.OnInputOutputTextBoxChanged);
            // 
            // menuItemExample3
            // 
            this.menuItemExample3.Name = "menuItemExample3";
            this.menuItemExample3.Size = new System.Drawing.Size(216, 26);
            this.menuItemExample3.Text = "样例3";
            this.menuItemExample3.Click += new System.EventHandler(this.OnExampleMenuItemDown);
            // 
            // codeTypeUcfMenuItem
            // 
            this.codeTypeUcfMenuItem.Name = "codeTypeUcfMenuItem";
            this.codeTypeUcfMenuItem.Size = new System.Drawing.Size(216, 26);
            this.codeTypeUcfMenuItem.Text = "ucf(ISE)";
            this.codeTypeUcfMenuItem.Click += new System.EventHandler(this.codeTypeMenuItem_Click);
            // 
            // codeTypeXdcMenuItem
            // 
            this.codeTypeXdcMenuItem.Name = "codeTypeXdcMenuItem";
            this.codeTypeXdcMenuItem.Size = new System.Drawing.Size(216, 26);
            this.codeTypeXdcMenuItem.Text = "xdc(Vivado)";
            this.codeTypeXdcMenuItem.Click += new System.EventHandler(this.codeTypeMenuItem_Click);
            // 
            // compressCheckBox
            // 
            this.compressCheckBox.AutoSize = true;
            this.compressCheckBox.Checked = true;
            this.compressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compressCheckBox.Location = new System.Drawing.Point(375, 294);
            this.compressCheckBox.Name = "compressCheckBox";
            this.compressCheckBox.Size = new System.Drawing.Size(59, 19);
            this.compressCheckBox.TabIndex = 14;
            this.compressCheckBox.Text = "压缩";
            this.compressCheckBox.UseVisualStyleBackColor = true;
            this.compressCheckBox.CheckedChanged += new System.EventHandler(this.compressCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 532);
            this.Controls.Add(this.compressCheckBox);
            this.Controls.Add(this.textBoxFalse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxClk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSeg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxLed);
            this.Controls.Add(this.textBoxSwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "UCFHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSwitch;
        private System.Windows.Forms.TextBox textBoxLed;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 显示样例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认管脚列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artix7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xC7A100TToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 配置管脚顺序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemVersion;
        private System.Windows.Forms.ToolStripMenuItem 作者shaoyyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExample1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExample2;
        private System.Windows.Forms.ToolStripMenuItem fGG484ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mailshaoyysakuragamingcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 可解决360误报希望能联系我ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管脚文件类型ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFalse;
        private System.Windows.Forms.ToolStripMenuItem menuItemExample3;
        private System.Windows.Forms.ToolStripMenuItem codeTypeUcfMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeTypeXdcMenuItem;
        private System.Windows.Forms.CheckBox compressCheckBox;
    }
}

