
namespace Shnorr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.s
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileBox = new System.Windows.Forms.TextBox();
            this.fileBoxLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSign = new System.Windows.Forms.TabPage();
            this.eyLabel = new System.Windows.Forms.Label();
            this.ClearSignTab = new System.Windows.Forms.Button();
            this.ComputeSignTab = new System.Windows.Forms.Button();
            this.GenSignTab = new System.Windows.Forms.Button();
            this.vBoxLabel = new System.Windows.Forms.Label();
            this.rBoxLabel = new System.Windows.Forms.Label();
            this.vBox = new System.Windows.Forms.TextBox();
            this.rBox = new System.Windows.Forms.TextBox();
            this.eBox = new System.Windows.Forms.TextBox();
            this.xBoxLabel = new System.Windows.Forms.Label();
            this.yBoxLabel = new System.Windows.Forms.Label();
            this.eBoxLabel = new System.Windows.Forms.Label();
            this.sBoxLabel = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.sBox = new System.Windows.Forms.TextBox();
            this.tabVerify = new System.Windows.Forms.TabPage();
            this.Copy = new System.Windows.Forms.Button();
            this.signLabel = new System.Windows.Forms.Label();
            this.v_BoxLabel = new System.Windows.Forms.Label();
            this.v_Box = new System.Windows.Forms.TextBox();
            this.ClearVerifyTab = new System.Windows.Forms.Button();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.ySignBox = new System.Windows.Forms.TextBox();
            this.ySignLabel = new System.Windows.Forms.Label();
            this.ComputeVerifyTab = new System.Windows.Forms.Button();
            this.e_Box = new System.Windows.Forms.TextBox();
            this.x_Box = new System.Windows.Forms.TextBox();
            this.x_BoxLabel = new System.Windows.Forms.Label();
            this.eSignBox = new System.Windows.Forms.TextBox();
            this.eSignLabel = new System.Windows.Forms.Label();
            this.e_BoxLabel = new System.Windows.Forms.Label();
            this.aBoxLabel = new System.Windows.Forms.Label();
            this.qBoxLabel = new System.Windows.Forms.Label();
            this.pBoxLabel = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.TextBox();
            this.qBox = new System.Windows.Forms.TextBox();
            this.SelectFileEDS = new System.Windows.Forms.Button();
            this.GenFormButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearForm = new System.Windows.Forms.Button();
            this.aBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabSign.SuspendLayout();
            this.tabVerify.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(29, 68);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(673, 29);
            this.FileBox.TabIndex = 1;
            // 
            // fileBoxLabel
            // 
            this.fileBoxLabel.AutoSize = true;
            this.fileBoxLabel.Location = new System.Drawing.Point(29, 44);
            this.fileBoxLabel.Name = "fileBoxLabel";
            this.fileBoxLabel.Size = new System.Drawing.Size(189, 21);
            this.fileBoxLabel.TabIndex = 11;
            this.fileBoxLabel.Text = "Выберите файл для ЭЦП:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSign);
            this.tabControl1.Controls.Add(this.tabVerify);
            this.tabControl1.Location = new System.Drawing.Point(29, 227);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 320);
            this.tabControl1.TabIndex = 20;
            // 
            // tabSign
            // 
            this.tabSign.Controls.Add(this.eyLabel);
            this.tabSign.Controls.Add(this.ClearSignTab);
            this.tabSign.Controls.Add(this.ComputeSignTab);
            this.tabSign.Controls.Add(this.GenSignTab);
            this.tabSign.Controls.Add(this.vBoxLabel);
            this.tabSign.Controls.Add(this.rBoxLabel);
            this.tabSign.Controls.Add(this.vBox);
            this.tabSign.Controls.Add(this.rBox);
            this.tabSign.Controls.Add(this.eBox);
            this.tabSign.Controls.Add(this.xBoxLabel);
            this.tabSign.Controls.Add(this.yBoxLabel);
            this.tabSign.Controls.Add(this.eBoxLabel);
            this.tabSign.Controls.Add(this.sBoxLabel);
            this.tabSign.Controls.Add(this.yBox);
            this.tabSign.Controls.Add(this.xBox);
            this.tabSign.Controls.Add(this.sBox);
            this.tabSign.Location = new System.Drawing.Point(4, 30);
            this.tabSign.Name = "tabSign";
            this.tabSign.Padding = new System.Windows.Forms.Padding(3);
            this.tabSign.Size = new System.Drawing.Size(792, 286);
            this.tabSign.TabIndex = 0;
            this.tabSign.Text = "Поставить подпись";
            this.tabSign.UseVisualStyleBackColor = true;
            // 
            // eyLabel
            // 
            this.eyLabel.AutoSize = true;
            this.eyLabel.Location = new System.Drawing.Point(228, 139);
            this.eyLabel.Name = "eyLabel";
            this.eyLabel.Size = new System.Drawing.Size(184, 21);
            this.eyLabel.TabIndex = 54;
            this.eyLabel.Text = "Значение подписи (е, y):";
            this.eyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClearSignTab
            // 
            this.ClearSignTab.Location = new System.Drawing.Point(324, 249);
            this.ClearSignTab.Name = "ClearSignTab";
            this.ClearSignTab.Size = new System.Drawing.Size(121, 28);
            this.ClearSignTab.TabIndex = 44;
            this.ClearSignTab.Text = "Очистить";
            this.ClearSignTab.UseVisualStyleBackColor = true;
            this.ClearSignTab.Click += new System.EventHandler(this.ClearSignTab_Click);
            // 
            // ComputeSignTab
            // 
            this.ComputeSignTab.Location = new System.Drawing.Point(665, 249);
            this.ComputeSignTab.Name = "ComputeSignTab";
            this.ComputeSignTab.Size = new System.Drawing.Size(121, 28);
            this.ComputeSignTab.TabIndex = 43;
            this.ComputeSignTab.Text = "Вычислить";
            this.ComputeSignTab.UseVisualStyleBackColor = true;
            this.ComputeSignTab.Click += new System.EventHandler(this.ComputeSignTab_Click);
            // 
            // GenSignTab
            // 
            this.GenSignTab.Location = new System.Drawing.Point(5, 252);
            this.GenSignTab.Name = "GenSignTab";
            this.GenSignTab.Size = new System.Drawing.Size(121, 28);
            this.GenSignTab.TabIndex = 42;
            this.GenSignTab.Text = "Заполнить";
            this.GenSignTab.UseVisualStyleBackColor = true;
            this.GenSignTab.Click += new System.EventHandler(this.GenSignTab_Click);
            // 
            // vBoxLabel
            // 
            this.vBoxLabel.AutoSize = true;
            this.vBoxLabel.Location = new System.Drawing.Point(403, 25);
            this.vBoxLabel.Name = "vBoxLabel";
            this.vBoxLabel.Size = new System.Drawing.Size(145, 42);
            this.vBoxLabel.TabIndex = 29;
            this.vBoxLabel.Text = "Открытый ключ v\r\nv = a^(q - s) mod p";
            this.vBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rBoxLabel
            // 
            this.rBoxLabel.AutoSize = true;
            this.rBoxLabel.Location = new System.Drawing.Point(17, 80);
            this.rBoxLabel.Name = "rBoxLabel";
            this.rBoxLabel.Size = new System.Drawing.Size(109, 42);
            this.rBoxLabel.TabIndex = 41;
            this.rBoxLabel.Text = "Число r\r\n1 <= r <= q-1";
            this.rBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vBox
            // 
            this.vBox.Location = new System.Drawing.Point(547, 38);
            this.vBox.Name = "vBox";
            this.vBox.Size = new System.Drawing.Size(224, 29);
            this.vBox.TabIndex = 28;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(161, 93);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(224, 29);
            this.rBox.TabIndex = 40;
            // 
            // eBox
            // 
            this.eBox.Location = new System.Drawing.Point(370, 168);
            this.eBox.Multiline = true;
            this.eBox.Name = "eBox";
            this.eBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eBox.Size = new System.Drawing.Size(224, 29);
            this.eBox.TabIndex = 39;
            // 
            // xBoxLabel
            // 
            this.xBoxLabel.AutoSize = true;
            this.xBoxLabel.Location = new System.Drawing.Point(405, 93);
            this.xBoxLabel.Name = "xBoxLabel";
            this.xBoxLabel.Size = new System.Drawing.Size(110, 21);
            this.xBoxLabel.TabIndex = 38;
            this.xBoxLabel.Text = "x = a^r mod p";
            this.xBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yBoxLabel
            // 
            this.yBoxLabel.AutoSize = true;
            this.yBoxLabel.Location = new System.Drawing.Point(228, 206);
            this.yBoxLabel.Name = "yBoxLabel";
            this.yBoxLabel.Size = new System.Drawing.Size(136, 21);
            this.yBoxLabel.TabIndex = 37;
            this.yBoxLabel.Text = "y = (r + se) mod q";
            this.yBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eBoxLabel
            // 
            this.eBoxLabel.AutoSize = true;
            this.eBoxLabel.Location = new System.Drawing.Point(228, 171);
            this.eBoxLabel.Name = "eBoxLabel";
            this.eBoxLabel.Size = new System.Drawing.Size(86, 21);
            this.eBoxLabel.TabIndex = 36;
            this.eBoxLabel.Text = "e = H(M, x)";
            this.eBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sBoxLabel
            // 
            this.sBoxLabel.AutoSize = true;
            this.sBoxLabel.Location = new System.Drawing.Point(13, 25);
            this.sBoxLabel.Name = "sBoxLabel";
            this.sBoxLabel.Size = new System.Drawing.Size(142, 42);
            this.sBoxLabel.TabIndex = 24;
            this.sBoxLabel.Text = "Секретный ключ s\r\n1 <= s <= q-1";
            this.sBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(370, 203);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(224, 29);
            this.yBox.TabIndex = 22;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(547, 90);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(224, 29);
            this.xBox.TabIndex = 21;
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(161, 38);
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(224, 29);
            this.sBox.TabIndex = 20;
            // 
            // tabVerify
            // 
            this.tabVerify.Controls.Add(this.Copy);
            this.tabVerify.Controls.Add(this.signLabel);
            this.tabVerify.Controls.Add(this.v_BoxLabel);
            this.tabVerify.Controls.Add(this.v_Box);
            this.tabVerify.Controls.Add(this.ClearVerifyTab);
            this.tabVerify.Controls.Add(this.publicKeyLabel);
            this.tabVerify.Controls.Add(this.ySignBox);
            this.tabVerify.Controls.Add(this.ySignLabel);
            this.tabVerify.Controls.Add(this.ComputeVerifyTab);
            this.tabVerify.Controls.Add(this.e_Box);
            this.tabVerify.Controls.Add(this.x_Box);
            this.tabVerify.Controls.Add(this.x_BoxLabel);
            this.tabVerify.Controls.Add(this.eSignBox);
            this.tabVerify.Controls.Add(this.eSignLabel);
            this.tabVerify.Controls.Add(this.e_BoxLabel);
            this.tabVerify.Location = new System.Drawing.Point(4, 30);
            this.tabVerify.Name = "tabVerify";
            this.tabVerify.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerify.Size = new System.Drawing.Size(792, 286);
            this.tabVerify.TabIndex = 1;
            this.tabVerify.Text = "Проверить подпись";
            this.tabVerify.UseVisualStyleBackColor = true;
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(6, 252);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(121, 28);
            this.Copy.TabIndex = 55;
            this.Copy.Text = "Заполнить";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // signLabel
            // 
            this.signLabel.AutoSize = true;
            this.signLabel.Location = new System.Drawing.Point(27, 123);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(244, 21);
            this.signLabel.TabIndex = 54;
            this.signLabel.Text = "Введите значение подписи (е, y):";
            this.signLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_BoxLabel
            // 
            this.v_BoxLabel.AutoSize = true;
            this.v_BoxLabel.Location = new System.Drawing.Point(240, 73);
            this.v_BoxLabel.Name = "v_BoxLabel";
            this.v_BoxLabel.Size = new System.Drawing.Size(18, 21);
            this.v_BoxLabel.TabIndex = 48;
            this.v_BoxLabel.Text = "v";
            this.v_BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_Box
            // 
            this.v_Box.Location = new System.Drawing.Point(278, 70);
            this.v_Box.Name = "v_Box";
            this.v_Box.Size = new System.Drawing.Size(224, 29);
            this.v_Box.TabIndex = 47;
            // 
            // ClearVerifyTab
            // 
            this.ClearVerifyTab.Location = new System.Drawing.Point(324, 252);
            this.ClearVerifyTab.Name = "ClearVerifyTab";
            this.ClearVerifyTab.Size = new System.Drawing.Size(121, 28);
            this.ClearVerifyTab.TabIndex = 45;
            this.ClearVerifyTab.Text = "Очистить";
            this.ClearVerifyTab.UseVisualStyleBackColor = true;
            this.ClearVerifyTab.Click += new System.EventHandler(this.ClearVerifyTab_Click);
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(234, 35);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(271, 21);
            this.publicKeyLabel.TabIndex = 53;
            this.publicKeyLabel.Text = "Введите значение открытого ключа:";
            this.publicKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ySignBox
            // 
            this.ySignBox.Location = new System.Drawing.Point(65, 195);
            this.ySignBox.Name = "ySignBox";
            this.ySignBox.Size = new System.Drawing.Size(224, 29);
            this.ySignBox.TabIndex = 51;
            // 
            // ySignLabel
            // 
            this.ySignLabel.AutoSize = true;
            this.ySignLabel.Location = new System.Drawing.Point(27, 198);
            this.ySignLabel.Name = "ySignLabel";
            this.ySignLabel.Size = new System.Drawing.Size(18, 21);
            this.ySignLabel.TabIndex = 52;
            this.ySignLabel.Text = "y";
            this.ySignLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ComputeVerifyTab
            // 
            this.ComputeVerifyTab.Location = new System.Drawing.Point(665, 252);
            this.ComputeVerifyTab.Name = "ComputeVerifyTab";
            this.ComputeVerifyTab.Size = new System.Drawing.Size(121, 28);
            this.ComputeVerifyTab.TabIndex = 50;
            this.ComputeVerifyTab.Text = "Проверить";
            this.ComputeVerifyTab.UseVisualStyleBackColor = true;
            this.ComputeVerifyTab.Click += new System.EventHandler(this.ComputeVerifyTab_Click);
            // 
            // e_Box
            // 
            this.e_Box.Location = new System.Drawing.Point(543, 195);
            this.e_Box.Multiline = true;
            this.e_Box.Name = "e_Box";
            this.e_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.e_Box.Size = new System.Drawing.Size(224, 29);
            this.e_Box.TabIndex = 49;
            // 
            // x_Box
            // 
            this.x_Box.Location = new System.Drawing.Point(543, 160);
            this.x_Box.Name = "x_Box";
            this.x_Box.Size = new System.Drawing.Size(224, 29);
            this.x_Box.TabIndex = 44;
            // 
            // x_BoxLabel
            // 
            this.x_BoxLabel.AutoSize = true;
            this.x_BoxLabel.Location = new System.Drawing.Point(384, 163);
            this.x_BoxLabel.Name = "x_BoxLabel";
            this.x_BoxLabel.Size = new System.Drawing.Size(147, 21);
            this.x_BoxLabel.TabIndex = 48;
            this.x_BoxLabel.Text = "x\' = a^y v^e mod p\r\n";
            this.x_BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eSignBox
            // 
            this.eSignBox.Location = new System.Drawing.Point(65, 160);
            this.eSignBox.Multiline = true;
            this.eSignBox.Name = "eSignBox";
            this.eSignBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eSignBox.Size = new System.Drawing.Size(224, 29);
            this.eSignBox.TabIndex = 45;
            // 
            // eSignLabel
            // 
            this.eSignLabel.AutoSize = true;
            this.eSignLabel.Location = new System.Drawing.Point(27, 163);
            this.eSignLabel.Name = "eSignLabel";
            this.eSignLabel.Size = new System.Drawing.Size(18, 21);
            this.eSignLabel.TabIndex = 47;
            this.eSignLabel.Text = "e";
            this.eSignLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // e_BoxLabel
            // 
            this.e_BoxLabel.AutoSize = true;
            this.e_BoxLabel.Location = new System.Drawing.Point(408, 198);
            this.e_BoxLabel.Name = "e_BoxLabel";
            this.e_BoxLabel.Size = new System.Drawing.Size(94, 21);
            this.e_BoxLabel.TabIndex = 46;
            this.e_BoxLabel.Text = "e\' = H(M, x\')";
            this.e_BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aBoxLabel
            // 
            this.aBoxLabel.AutoSize = true;
            this.aBoxLabel.Location = new System.Drawing.Point(466, 115);
            this.aBoxLabel.Name = "aBoxLabel";
            this.aBoxLabel.Size = new System.Drawing.Size(115, 42);
            this.aBoxLabel.TabIndex = 27;
            this.aBoxLabel.Text = "Число a\r\na^q = 1 mod p";
            this.aBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // qBoxLabel
            // 
            this.qBoxLabel.AutoSize = true;
            this.qBoxLabel.Location = new System.Drawing.Point(237, 115);
            this.qBoxLabel.Name = "qBoxLabel";
            this.qBoxLabel.Size = new System.Drawing.Size(132, 42);
            this.qBoxLabel.TabIndex = 26;
            this.qBoxLabel.Text = "Простое число q\r\nделитель для p-1";
            this.qBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pBoxLabel
            // 
            this.pBoxLabel.AutoSize = true;
            this.pBoxLabel.Location = new System.Drawing.Point(71, 136);
            this.pBoxLabel.Name = "pBoxLabel";
            this.pBoxLabel.Size = new System.Drawing.Size(129, 21);
            this.pBoxLabel.TabIndex = 25;
            this.pBoxLabel.Text = "Простое число p";
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(71, 160);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(129, 29);
            this.pBox.TabIndex = 22;
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(237, 160);
            this.qBox.Name = "qBox";
            this.qBox.Size = new System.Drawing.Size(129, 29);
            this.qBox.TabIndex = 21;
            // 
            // SelectFileEDS
            // 
            this.SelectFileEDS.Location = new System.Drawing.Point(714, 68);
            this.SelectFileEDS.Name = "SelectFileEDS";
            this.SelectFileEDS.Size = new System.Drawing.Size(115, 28);
            this.SelectFileEDS.TabIndex = 31;
            this.SelectFileEDS.Text = "Выбрать";
            this.SelectFileEDS.UseVisualStyleBackColor = true;
            this.SelectFileEDS.Click += new System.EventHandler(this.SelectFileEDS_Click);
            // 
            // GenFormButton
            // 
            this.GenFormButton.Location = new System.Drawing.Point(714, 159);
            this.GenFormButton.Name = "GenFormButton";
            this.GenFormButton.Size = new System.Drawing.Size(115, 28);
            this.GenFormButton.TabIndex = 33;
            this.GenFormButton.Text = "Заполнить";
            this.GenFormButton.UseVisualStyleBackColor = true;
            this.GenFormButton.Click += new System.EventHandler(this.GenFormButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 29);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ResetMenuItem
            // 
            this.ResetMenuItem.Name = "ResetMenuItem";
            this.ResetMenuItem.Size = new System.Drawing.Size(138, 26);
            this.ResetMenuItem.Text = "Сброс";
            this.ResetMenuItem.Click += new System.EventHandler(this.ResetMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(138, 26);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.HelpToolStripMenuItem.Text = "Помощь";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(189, 26);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // ClearForm
            // 
            this.ClearForm.Location = new System.Drawing.Point(714, 193);
            this.ClearForm.Name = "ClearForm";
            this.ClearForm.Size = new System.Drawing.Size(115, 28);
            this.ClearForm.TabIndex = 46;
            this.ClearForm.Text = "Очистить";
            this.ClearForm.UseVisualStyleBackColor = true;
            this.ClearForm.Click += new System.EventHandler(this.ClearForm_Click);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(416, 160);
            this.aBox.Multiline = true;
            this.aBox.Name = "aBox";
            this.aBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aBox.Size = new System.Drawing.Size(224, 29);
            this.aBox.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 559);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.ClearForm);
            this.Controls.Add(this.GenFormButton);
            this.Controls.Add(this.SelectFileEDS);
            this.Controls.Add(this.aBoxLabel);
            this.Controls.Add(this.qBoxLabel);
            this.Controls.Add(this.pBoxLabel);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fileBoxLabel);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(876, 604);
            this.MinimumSize = new System.Drawing.Size(876, 604);
            this.Name = "Form1";
            this.Text = "Протокол ЭЦП Шнорра";
            this.tabControl1.ResumeLayout(false);
            this.tabSign.ResumeLayout(false);
            this.tabSign.PerformLayout();
            this.tabVerify.ResumeLayout(false);
            this.tabVerify.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Label fileBoxLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSign;
        private System.Windows.Forms.Label sBoxLabel;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TabPage tabVerify;
        private System.Windows.Forms.Label aBoxLabel;
        private System.Windows.Forms.Label qBoxLabel;
        private System.Windows.Forms.Label pBoxLabel;
        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.TextBox qBox;
        private System.Windows.Forms.Label vBoxLabel;
        private System.Windows.Forms.Button ComputeSignTab;
        private System.Windows.Forms.Button GenSignTab;
        private System.Windows.Forms.Label rBoxLabel;
        private System.Windows.Forms.TextBox eBox;
        private System.Windows.Forms.Label xBoxLabel;
        private System.Windows.Forms.Label yBoxLabel;
        private System.Windows.Forms.Label eBoxLabel;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.TextBox ySignBox;
        private System.Windows.Forms.Label ySignLabel;
        private System.Windows.Forms.Button ComputeVerifyTab;
        private System.Windows.Forms.TextBox e_Box;
        private System.Windows.Forms.TextBox x_Box;
        private System.Windows.Forms.Label x_BoxLabel;
        private System.Windows.Forms.TextBox eSignBox;
        private System.Windows.Forms.Label eSignLabel;
        private System.Windows.Forms.Label e_BoxLabel;
        private System.Windows.Forms.Button SelectFileEDS;
        private System.Windows.Forms.Button GenFormButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Button ClearSignTab;
        private System.Windows.Forms.Button ClearVerifyTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.Button ClearForm;
        private System.Windows.Forms.Label v_BoxLabel;
        private System.Windows.Forms.TextBox v_Box;
        private System.Windows.Forms.Label eyLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.TextBox vBox;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.TextBox sBox;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.TextBox aBox;
    }
}

