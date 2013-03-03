﻿namespace SpellWork.Forms
{
    sealed partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._dbConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this._status = new System.Windows.Forms.ToolStripStatusLabel();
            this._ProcStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this._Connected = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._ilPro = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this._tpCompare = new System.Windows.Forms.TabPage();
            this._scCompareRoot = new System.Windows.Forms.SplitContainer();
            this._bCompareSearch1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this._tbCompareFilterSpell1 = new System.Windows.Forms.TextBox();
            this._rtbCompareSpell1 = new System.Windows.Forms.RichTextBox();
            this._bCompareSearch2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this._rtbCompareSpell2 = new System.Windows.Forms.RichTextBox();
            this._tbCompareFilterSpell2 = new System.Windows.Forms.TextBox();
            this._tpSpellInfo = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._rtSpellInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lvSpellList = new System.Windows.Forms.ListView();
            this.chSpellID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpellName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._gSpellFilter = new System.Windows.Forms.GroupBox();
            this._gbAdvansedSearch = new System.Windows.Forms.GroupBox();
            this._cbAdvancedFilter2CompareType = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1CompareType = new System.Windows.Forms.ComboBox();
            this._tbAdvancedFilter2Val = new System.Windows.Forms.TextBox();
            this._tbAdvancedFilter1Val = new System.Windows.Forms.TextBox();
            this._cbAdvancedFilter2 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1 = new System.Windows.Forms.ComboBox();
            this._cbTarget2 = new System.Windows.Forms.ComboBox();
            this._cbTarget1 = new System.Windows.Forms.ComboBox();
            this._cbSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbSpellAura = new System.Windows.Forms.ComboBox();
            this._cbSpellFamilyName = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._bSearch = new System.Windows.Forms.Button();
            this._tbSearchAttributes = new System.Windows.Forms.TextBox();
            this._tbSearchIcon = new System.Windows.Forms.TextBox();
            this._tbSearchId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._tpSpellProcInfo = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._tpSqlData = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lvProcAdditionalInfo = new System.Windows.Forms.ListView();
            this._chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this._cbProcSpellFamilyName = new System.Windows.Forms.ComboBox();
            this._cbProcSpellAura = new System.Windows.Forms.ComboBox();
            this._cbProcSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbProcTarget1 = new System.Windows.Forms.ComboBox();
            this._cbProcTarget2 = new System.Windows.Forms.ComboBox();
            this._tbProcSeach = new System.Windows.Forms.TextBox();
            this._bProcSearch = new System.Windows.Forms.Button();
            this._lvProcSpellList = new System.Windows.Forms.ListView();
            this._chProcID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chProcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._rtbProcSpellInfo = new System.Windows.Forms.RichTextBox();
            this._tvFamilyTree = new System.Windows.Forms.TreeView();
            this._cbProcSpellFamilyTree = new System.Windows.Forms.ComboBox();
            this._gSpellProcEvent = new System.Windows.Forms.GroupBox();
            this._tbCooldown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbChance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbPPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._cbProcFitstSpellFamily = new System.Windows.Forms.ComboBox();
            this._clbSchools = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._clbProcFlagEx = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._clbProcFlags = new System.Windows.Forms.CheckedListBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this._bSqlSave = new System.Windows.Forms.Button();
            this._bSqlToBase = new System.Windows.Forms.Button();
            this._rtbSqlLog = new System.Windows.Forms.RichTextBox();
            this._lvDataList = new System.Windows.Forms.ListView();
            this.entry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolmask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilyname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procflag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procEx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppmRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customchance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cooldown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._bSelect = new System.Windows.Forms.Button();
            this._cbSqlSpellFamily = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._tbSqlSchool = new System.Windows.Forms.TextBox();
            this._tbSqlProc = new System.Windows.Forms.TextBox();
            this._tbSqlProcEx = new System.Windows.Forms.TextBox();
            this._bSqlSchool = new System.Windows.Forms.Button();
            this._bSqlProc = new System.Windows.Forms.Button();
            this._bSqlProcEx = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._tbSqlManual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._cbBinaryCompare = new System.Windows.Forms.CheckBox();
            this._cbProcFlag = new System.Windows.Forms.CheckBox();
            this._bWrite = new System.Windows.Forms.Button();
            this._bLevelScaling = new System.Windows.Forms.Button();
            this._cbEffectFilterCompareType = new System.Windows.Forms.ComboBox();
            this._tbEffectFilterVal = new System.Windows.Forms.TextBox();
            this._cbEffectFilter = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this._tpCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scCompareRoot)).BeginInit();
            this._scCompareRoot.Panel1.SuspendLayout();
            this._scCompareRoot.Panel2.SuspendLayout();
            this._scCompareRoot.SuspendLayout();
            this._tpSpellInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._gSpellFilter.SuspendLayout();
            this._gbAdvansedSearch.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._tpSpellProcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this._tpSqlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._dbConnect,
            this._status,
            this._ProcStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _dbConnect
            // 
            this._dbConnect.Name = "_dbConnect";
            this._dbConnect.Size = new System.Drawing.Size(0, 17);
            // 
            // _status
            // 
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(0, 17);
            // 
            // _ProcStatus
            // 
            this._ProcStatus.Name = "_ProcStatus";
            this._ProcStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmFile,
            this._tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _tsmFile
            // 
            this._tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Connected,
            this._tsmSettings,
            this._tsmExit});
            this._tsmFile.Name = "_tsmFile";
            this._tsmFile.Size = new System.Drawing.Size(37, 20);
            this._tsmFile.Text = "File";
            // 
            // _Connected
            // 
            this._Connected.Name = "_Connected";
            this._Connected.Size = new System.Drawing.Size(132, 22);
            this._Connected.Text = "Connected";
            this._Connected.Click += new System.EventHandler(this.ConnectedClick);
            // 
            // _tsmSettings
            // 
            this._tsmSettings.Name = "_tsmSettings";
            this._tsmSettings.Size = new System.Drawing.Size(132, 22);
            this._tsmSettings.Text = "Setting";
            this._tsmSettings.Click += new System.EventHandler(this.SettingsClick);
            // 
            // _tsmExit
            // 
            this._tsmExit.Name = "_tsmExit";
            this._tsmExit.Size = new System.Drawing.Size(132, 22);
            this._tsmExit.Text = "Exit";
            this._tsmExit.Click += new System.EventHandler(ExitClick);
            // 
            // _tsmHelp
            // 
            this._tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmAbout});
            this._tsmHelp.Name = "_tsmHelp";
            this._tsmHelp.Size = new System.Drawing.Size(44, 20);
            this._tsmHelp.Text = "Help";
            // 
            // _tsmAbout
            // 
            this._tsmAbout.Name = "_tsmAbout";
            this._tsmAbout.Size = new System.Drawing.Size(113, 22);
            this._tsmAbout.Text = "About..";
            this._tsmAbout.Click += new System.EventHandler(AboutClick);
            // 
            // _ilPro
            // 
            this._ilPro.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilPro.ImageStream")));
            this._ilPro.TransparentColor = System.Drawing.Color.Transparent;
            this._ilPro.Images.SetKeyName(0, "info.ico");
            this._ilPro.Images.SetKeyName(1, "ok.ico");
            this._ilPro.Images.SetKeyName(2, "drop.ico");
            this._ilPro.Images.SetKeyName(3, "plus.ico");
            this._ilPro.Images.SetKeyName(4, "family.ico");
            this._ilPro.Images.SetKeyName(5, "munus.ico");
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            this.splitContainer7.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer7.Size = new System.Drawing.Size(858, 429);
            this.splitContainer7.SplitterDistance = 424;
            this.splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.textBox2);
            this.splitContainer8.Size = new System.Drawing.Size(424, 429);
            this.splitContainer8.SplitterDistance = 209;
            this.splitContainer8.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 429);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(430, 429);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // _tpCompare
            // 
            this._tpCompare.Controls.Add(this._scCompareRoot);
            this._tpCompare.Location = new System.Drawing.Point(4, 22);
            this._tpCompare.Name = "_tpCompare";
            this._tpCompare.Padding = new System.Windows.Forms.Padding(3);
            this._tpCompare.Size = new System.Drawing.Size(864, 557);
            this._tpCompare.TabIndex = 4;
            this._tpCompare.Text = "Compare Spells";
            this._tpCompare.UseVisualStyleBackColor = true;
            // 
            // _scCompareRoot
            // 
            this._scCompareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scCompareRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._scCompareRoot.Location = new System.Drawing.Point(3, 3);
            this._scCompareRoot.Name = "_scCompareRoot";
            // 
            // _scCompareRoot.Panel1
            // 
            this._scCompareRoot.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel1.Controls.Add(this._bCompareSearch1);
            this._scCompareRoot.Panel1.Controls.Add(this.label13);
            this._scCompareRoot.Panel1.Controls.Add(this._tbCompareFilterSpell1);
            this._scCompareRoot.Panel1.Controls.Add(this._rtbCompareSpell1);
            // 
            // _scCompareRoot.Panel2
            // 
            this._scCompareRoot.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel2.Controls.Add(this._bCompareSearch2);
            this._scCompareRoot.Panel2.Controls.Add(this.label14);
            this._scCompareRoot.Panel2.Controls.Add(this._rtbCompareSpell2);
            this._scCompareRoot.Panel2.Controls.Add(this._tbCompareFilterSpell2);
            this._scCompareRoot.Size = new System.Drawing.Size(858, 551);
            this._scCompareRoot.SplitterDistance = 426;
            this._scCompareRoot.TabIndex = 0;
            // 
            // _bCompareSearch1
            // 
            this._bCompareSearch1.Location = new System.Drawing.Point(238, 1);
            this._bCompareSearch1.Name = "_bCompareSearch1";
            this._bCompareSearch1.Size = new System.Drawing.Size(51, 23);
            this._bCompareSearch1.TabIndex = 3;
            this._bCompareSearch1.Text = "Search";
            this._bCompareSearch1.UseVisualStyleBackColor = true;
            this._bCompareSearch1.Click += new System.EventHandler(this.CompareSearch1Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "ID or Name";
            // 
            // _tbCompareFilterSpell1
            // 
            this._tbCompareFilterSpell1.Location = new System.Drawing.Point(86, 3);
            this._tbCompareFilterSpell1.Name = "_tbCompareFilterSpell1";
            this._tbCompareFilterSpell1.Size = new System.Drawing.Size(146, 20);
            this._tbCompareFilterSpell1.TabIndex = 1;
            this._tbCompareFilterSpell1.TextChanged += new System.EventHandler(this.CompareFilterSpellTextChanged);
            // 
            // _rtbCompareSpell1
            // 
            this._rtbCompareSpell1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell1.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell1.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this._rtbCompareSpell1.Location = new System.Drawing.Point(0, 29);
            this._rtbCompareSpell1.Name = "_rtbCompareSpell1";
            this._rtbCompareSpell1.Size = new System.Drawing.Size(423, 522);
            this._rtbCompareSpell1.TabIndex = 0;
            this._rtbCompareSpell1.Text = "";
            // 
            // _bCompareSearch2
            // 
            this._bCompareSearch2.Location = new System.Drawing.Point(243, 1);
            this._bCompareSearch2.Name = "_bCompareSearch2";
            this._bCompareSearch2.Size = new System.Drawing.Size(51, 23);
            this._bCompareSearch2.TabIndex = 3;
            this._bCompareSearch2.Text = "Search";
            this._bCompareSearch2.UseVisualStyleBackColor = true;
            this._bCompareSearch2.Click += new System.EventHandler(this.CompareSearch2Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID or Name";
            // 
            // _rtbCompareSpell2
            // 
            this._rtbCompareSpell2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell2.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell2.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this._rtbCompareSpell2.Location = new System.Drawing.Point(3, 29);
            this._rtbCompareSpell2.Name = "_rtbCompareSpell2";
            this._rtbCompareSpell2.Size = new System.Drawing.Size(425, 522);
            this._rtbCompareSpell2.TabIndex = 0;
            this._rtbCompareSpell2.Text = "";
            // 
            // _tbCompareFilterSpell2
            // 
            this._tbCompareFilterSpell2.Location = new System.Drawing.Point(91, 3);
            this._tbCompareFilterSpell2.Name = "_tbCompareFilterSpell2";
            this._tbCompareFilterSpell2.Size = new System.Drawing.Size(146, 20);
            this._tbCompareFilterSpell2.TabIndex = 1;
            this._tbCompareFilterSpell2.TextChanged += new System.EventHandler(this.CompareFilterSpellTextChanged);
            // 
            // _tpSpellInfo
            // 
            this._tpSpellInfo.Controls.Add(this.splitContainer1);
            this._tpSpellInfo.Location = new System.Drawing.Point(4, 22);
            this._tpSpellInfo.Name = "_tpSpellInfo";
            this._tpSpellInfo.Padding = new System.Windows.Forms.Padding(3);
            this._tpSpellInfo.Size = new System.Drawing.Size(864, 557);
            this._tpSpellInfo.TabIndex = 0;
            this._tpSpellInfo.Text = "Spell Info";
            this._tpSpellInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._rtSpellInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(858, 551);
            this.splitContainer1.SplitterDistance = 543;
            this.splitContainer1.TabIndex = 0;
            // 
            // _rtSpellInfo
            // 
            this._rtSpellInfo.BackColor = System.Drawing.Color.Gainsboro;
            this._rtSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtSpellInfo.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rtSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtSpellInfo.Name = "_rtSpellInfo";
            this._rtSpellInfo.ReadOnly = true;
            this._rtSpellInfo.Size = new System.Drawing.Size(543, 551);
            this._rtSpellInfo.TabIndex = 0;
            this._rtSpellInfo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lvSpellList);
            this.groupBox1.Controls.Add(this._gSpellFilter);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // _lvSpellList
            // 
            this._lvSpellList.AllowColumnReorder = true;
            this._lvSpellList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSpellID,
            this.chSpellName});
            this._lvSpellList.FullRowSelect = true;
            this._lvSpellList.GridLines = true;
            this._lvSpellList.HideSelection = false;
            this._lvSpellList.Location = new System.Drawing.Point(6, 326);
            this._lvSpellList.MultiSelect = false;
            this._lvSpellList.Name = "_lvSpellList";
            this._lvSpellList.Size = new System.Drawing.Size(302, 219);
            this._lvSpellList.TabIndex = 7;
            this._lvSpellList.UseCompatibleStateImageBehavior = false;
            this._lvSpellList.View = System.Windows.Forms.View.Details;
            this._lvSpellList.VirtualMode = true;
            this._lvSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvSpellListRetrieveVirtualItem);
            this._lvSpellList.SelectedIndexChanged += new System.EventHandler(this.LvSpellListSelectedIndexChanged);
            // 
            // chSpellID
            // 
            this.chSpellID.Text = "ID";
            this.chSpellID.Width = 48;
            // 
            // chSpellName
            // 
            this.chSpellName.Text = "Name";
            this.chSpellName.Width = 250;
            // 
            // _gSpellFilter
            // 
            this._gSpellFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gSpellFilter.BackColor = System.Drawing.Color.LightGray;
            this._gSpellFilter.Controls.Add(this._gbAdvansedSearch);
            this._gSpellFilter.Controls.Add(this._cbTarget2);
            this._gSpellFilter.Controls.Add(this._cbTarget1);
            this._gSpellFilter.Controls.Add(this._cbSpellEffect);
            this._gSpellFilter.Controls.Add(this._cbSpellAura);
            this._gSpellFilter.Controls.Add(this._cbSpellFamilyName);
            this._gSpellFilter.Location = new System.Drawing.Point(2, 81);
            this._gSpellFilter.Name = "_gSpellFilter";
            this._gSpellFilter.Size = new System.Drawing.Size(309, 239);
            this._gSpellFilter.TabIndex = 8;
            this._gSpellFilter.TabStop = false;
            this._gSpellFilter.Text = "Spell Filter";
            // 
            // _gbAdvansedSearch
            // 
            this._gbAdvansedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbAdvansedSearch.Controls.Add(this._cbEffectFilterCompareType);
            this._gbAdvansedSearch.Controls.Add(this._tbEffectFilterVal);
            this._gbAdvansedSearch.Controls.Add(this._cbEffectFilter);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2CompareType);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1CompareType);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter2Val);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter1Val);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1);
            this._gbAdvansedSearch.Location = new System.Drawing.Point(3, 135);
            this._gbAdvansedSearch.Name = "_gbAdvansedSearch";
            this._gbAdvansedSearch.Size = new System.Drawing.Size(300, 98);
            this._gbAdvansedSearch.TabIndex = 6;
            this._gbAdvansedSearch.TabStop = false;
            this._gbAdvansedSearch.Text = "Advanced Filter";
            // 
            // _cbAdvancedFilter2CompareType
            // 
            this._cbAdvancedFilter2CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter2CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter2CompareType.Location = new System.Drawing.Point(127, 41);
            this._cbAdvancedFilter2CompareType.Name = "_cbAdvancedFilter2CompareType";
            this._cbAdvancedFilter2CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedFilter2CompareType.TabIndex = 3;
            // 
            // _cbAdvancedFilter1CompareType
            // 
            this._cbAdvancedFilter1CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter1CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter1CompareType.Location = new System.Drawing.Point(127, 15);
            this._cbAdvancedFilter1CompareType.Name = "_cbAdvancedFilter1CompareType";
            this._cbAdvancedFilter1CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedFilter1CompareType.TabIndex = 2;
            // 
            // _cbEffectFilterCompareType
            // 
            this._cbEffectFilterCompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbEffectFilterCompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbEffectFilterCompareType.DropDownWidth = 160;
            this._cbEffectFilterCompareType.FormattingEnabled = true;
            this._cbEffectFilterCompareType.Location = new System.Drawing.Point(128, 68);
            this._cbEffectFilterCompareType.Name = "_cbEffectFilterCompareType";
            this._cbEffectFilterCompareType.Size = new System.Drawing.Size(76, 21);
            this._cbEffectFilterCompareType.TabIndex = 6;
            // 
            // _tbAdvancedFilter2Val
            // 
            this._tbAdvancedFilter2Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter2Val.Location = new System.Drawing.Point(210, 42);
            this._tbAdvancedFilter2Val.Name = "_tbAdvancedFilter2Val";
            this._tbAdvancedFilter2Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedFilter2Val.TabIndex = 1;
            this._tbAdvancedFilter2Val.Text = "0";
            this._tbAdvancedFilter2Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _tbAdvancedFilter1Val
            // 
            this._tbAdvancedFilter1Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter1Val.Location = new System.Drawing.Point(209, 15);
            this._tbAdvancedFilter1Val.Name = "_tbAdvancedFilter1Val";
            this._tbAdvancedFilter1Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedFilter1Val.TabIndex = 1;
            this._tbAdvancedFilter1Val.Text = "0";
            this._tbAdvancedFilter1Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _tbEffectFilterVal
            // 
            this._tbEffectFilterVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbEffectFilterVal.Location = new System.Drawing.Point(211, 69);
            this._tbEffectFilterVal.Name = "_tbEffectFilterVal";
            this._tbEffectFilterVal.Size = new System.Drawing.Size(85, 20);
            this._tbEffectFilterVal.TabIndex = 5;
            this._tbEffectFilterVal.Text = "0";
            this._tbEffectFilterVal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _cbAdvancedFilter2
            // 
            this._cbAdvancedFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2.DropDownHeight = 500;
            this._cbAdvancedFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2.FormattingEnabled = true;
            this._cbAdvancedFilter2.IntegralHeight = false;
            this._cbAdvancedFilter2.Location = new System.Drawing.Point(1, 42);
            this._cbAdvancedFilter2.Name = "_cbAdvancedFilter2";
            this._cbAdvancedFilter2.Size = new System.Drawing.Size(120, 21);
            this._cbAdvancedFilter2.TabIndex = 0;
            // 
            // _cbAdvancedFilter1
            // 
            this._cbAdvancedFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1.DropDownHeight = 500;
            this._cbAdvancedFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1.FormattingEnabled = true;
            this._cbAdvancedFilter1.IntegralHeight = false;
            this._cbAdvancedFilter1.Location = new System.Drawing.Point(1, 15);
            this._cbAdvancedFilter1.Name = "_cbAdvancedFilter1";
            this._cbAdvancedFilter1.Size = new System.Drawing.Size(120, 21);
            this._cbAdvancedFilter1.TabIndex = 0;
            // 
            // _cbEffectFilter
            // 
            this._cbEffectFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbEffectFilter.DropDownHeight = 500;
            this._cbEffectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbEffectFilter.FormattingEnabled = true;
            this._cbEffectFilter.IntegralHeight = false;
            this._cbEffectFilter.Location = new System.Drawing.Point(2, 69);
            this._cbEffectFilter.Name = "_cbEffectFilter";
            this._cbEffectFilter.Size = new System.Drawing.Size(120, 21);
            this._cbEffectFilter.TabIndex = 4;
            // 
            // _cbTarget2
            // 
            this._cbTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget2.DropDownHeight = 500;
            this._cbTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget2.DropDownWidth = 302;
            this._cbTarget2.FormattingEnabled = true;
            this._cbTarget2.IntegralHeight = false;
            this._cbTarget2.Location = new System.Drawing.Point(4, 111);
            this._cbTarget2.Name = "_cbTarget2";
            this._cbTarget2.Size = new System.Drawing.Size(302, 21);
            this._cbTarget2.TabIndex = 5;
            this._cbTarget2.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbTarget1
            // 
            this._cbTarget1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget1.DropDownHeight = 500;
            this._cbTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget1.DropDownWidth = 302;
            this._cbTarget1.FormattingEnabled = true;
            this._cbTarget1.IntegralHeight = false;
            this._cbTarget1.Location = new System.Drawing.Point(4, 87);
            this._cbTarget1.Name = "_cbTarget1";
            this._cbTarget1.Size = new System.Drawing.Size(302, 21);
            this._cbTarget1.TabIndex = 5;
            this._cbTarget1.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellEffect
            // 
            this._cbSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellEffect.DropDownHeight = 500;
            this._cbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellEffect.DropDownWidth = 302;
            this._cbSpellEffect.FormattingEnabled = true;
            this._cbSpellEffect.IntegralHeight = false;
            this._cbSpellEffect.Location = new System.Drawing.Point(4, 62);
            this._cbSpellEffect.Name = "_cbSpellEffect";
            this._cbSpellEffect.Size = new System.Drawing.Size(302, 21);
            this._cbSpellEffect.TabIndex = 4;
            this._cbSpellEffect.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellAura
            // 
            this._cbSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellAura.DropDownHeight = 500;
            this._cbSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellAura.DropDownWidth = 302;
            this._cbSpellAura.FormattingEnabled = true;
            this._cbSpellAura.IntegralHeight = false;
            this._cbSpellAura.Location = new System.Drawing.Point(4, 38);
            this._cbSpellAura.Name = "_cbSpellAura";
            this._cbSpellAura.Size = new System.Drawing.Size(302, 21);
            this._cbSpellAura.TabIndex = 3;
            this._cbSpellAura.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellFamilyName
            // 
            this._cbSpellFamilyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellFamilyName.DropDownHeight = 500;
            this._cbSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellFamilyName.DropDownWidth = 302;
            this._cbSpellFamilyName.FormattingEnabled = true;
            this._cbSpellFamilyName.IntegralHeight = false;
            this._cbSpellFamilyName.ItemHeight = 13;
            this._cbSpellFamilyName.Location = new System.Drawing.Point(4, 14);
            this._cbSpellFamilyName.Name = "_cbSpellFamilyName";
            this._cbSpellFamilyName.Size = new System.Drawing.Size(302, 21);
            this._cbSpellFamilyName.TabIndex = 2;
            this._cbSpellFamilyName.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.LightGray;
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this._bSearch);
            this.groupBox7.Controls.Add(this._tbSearchAttributes);
            this.groupBox7.Controls.Add(this._tbSearchIcon);
            this.groupBox7.Controls.Add(this._tbSearchId);
            this.groupBox7.Location = new System.Drawing.Point(0, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(309, 89);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Spell Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attributes&&X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Icon ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID or Name:";
            // 
            // _bSearch
            // 
            this._bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSearch.Location = new System.Drawing.Point(258, 11);
            this._bSearch.Name = "_bSearch";
            this._bSearch.Size = new System.Drawing.Size(50, 23);
            this._bSearch.TabIndex = 1;
            this._bSearch.Text = "Search";
            this._bSearch.UseVisualStyleBackColor = true;
            this._bSearch.Click += new System.EventHandler(this.BSearchClick);
            // 
            // _tbSearchAttributes
            // 
            this._tbSearchAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchAttributes.Location = new System.Drawing.Point(73, 57);
            this._tbSearchAttributes.Name = "_tbSearchAttributes";
            this._tbSearchAttributes.Size = new System.Drawing.Size(180, 20);
            this._tbSearchAttributes.TabIndex = 0;
            this._tbSearchAttributes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // _tbSearchIcon
            // 
            this._tbSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchIcon.Location = new System.Drawing.Point(73, 35);
            this._tbSearchIcon.Name = "_tbSearchIcon";
            this._tbSearchIcon.Size = new System.Drawing.Size(180, 20);
            this._tbSearchIcon.TabIndex = 0;
            this._tbSearchIcon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // _tbSearchId
            // 
            this._tbSearchId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchId.Location = new System.Drawing.Point(73, 13);
            this._tbSearchId.Name = "_tbSearchId";
            this._tbSearchId.Size = new System.Drawing.Size(180, 20);
            this._tbSearchId.TabIndex = 0;
            this._tbSearchId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._tpSpellInfo);
            this.tabControl1.Controls.Add(this._tpSpellProcInfo);
            this.tabControl1.Controls.Add(this._tpCompare);
            this.tabControl1.Controls.Add(this._tpSqlData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 583);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
            // 
            // _tpSpellProcInfo
            // 
            this._tpSpellProcInfo.Controls.Add(this.splitContainer2);
            this._tpSpellProcInfo.Location = new System.Drawing.Point(4, 22);
            this._tpSpellProcInfo.Name = "_tpSpellProcInfo";
            this._tpSpellProcInfo.Size = new System.Drawing.Size(864, 557);
            this._tpSpellProcInfo.TabIndex = 2;
            this._tpSpellProcInfo.Text = "Spell Proc Event";
            this._tpSpellProcInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Size = new System.Drawing.Size(864, 557);
            this.splitContainer2.SplitterDistance = 489;
            this.splitContainer2.TabIndex = 0;
            // 
            // _tpSqlData
            // 
            this._tpSqlData.Controls.Add(this.groupBox3);
            this._tpSqlData.Controls.Add(this.groupBox2);
            this._tpSqlData.Location = new System.Drawing.Point(4, 22);
            this._tpSqlData.Name = "_tpSqlData";
            this._tpSqlData.Size = new System.Drawing.Size(864, 557);
            this._tpSqlData.TabIndex = 3;
            this._tpSqlData.Text = "Sql Data";
            this._tpSqlData.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 85);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(0, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 463);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // _lvProcAdditionalInfo
            // 
            this._lvProcAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvProcAdditionalInfo.FullRowSelect = true;
            this._lvProcAdditionalInfo.GridLines = true;
            this._lvProcAdditionalInfo.Location = new System.Drawing.Point(0, 0);
            this._lvProcAdditionalInfo.Name = "_lvProcAdditionalInfo";
            this._lvProcAdditionalInfo.Size = new System.Drawing.Size(864, 64);
            this._lvProcAdditionalInfo.TabIndex = 0;
            this._lvProcAdditionalInfo.UseCompatibleStateImageBehavior = false;
            this._lvProcAdditionalInfo.View = System.Windows.Forms.View.Details;
            this._lvProcAdditionalInfo.SelectedIndexChanged += new System.EventHandler(this.LvProcAdditionalInfoSelectedIndexChanged);
            // 
            // _chID
            // 
            this._chID.DisplayIndex = 0;
            this._chID.Text = "Entry";
            this._chID.Width = 100;
            // 
            // _chName
            // 
            this._chName.DisplayIndex = 1;
            this._chName.Text = "Name";
            this._chName.Width = 685;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Size = new System.Drawing.Size(864, 489);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer4.Size = new System.Drawing.Size(864, 244);
            this.splitContainer4.SplitterDistance = 260;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer5.Size = new System.Drawing.Size(600, 244);
            this.splitContainer5.SplitterDistance = 330;
            this.splitContainer5.TabIndex = 0;
            // 
            // _cbProcSpellFamilyName
            // 
            this._cbProcSpellFamilyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellFamilyName.DropDownHeight = 500;
            this._cbProcSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellFamilyName.FormattingEnabled = true;
            this._cbProcSpellFamilyName.IntegralHeight = false;
            this._cbProcSpellFamilyName.Location = new System.Drawing.Point(3, 24);
            this._cbProcSpellFamilyName.Name = "_cbProcSpellFamilyName";
            this._cbProcSpellFamilyName.Size = new System.Drawing.Size(260, 21);
            this._cbProcSpellFamilyName.TabIndex = 1;
            this._cbProcSpellFamilyName.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellAura
            // 
            this._cbProcSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellAura.DropDownHeight = 500;
            this._cbProcSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellAura.FormattingEnabled = true;
            this._cbProcSpellAura.IntegralHeight = false;
            this._cbProcSpellAura.Location = new System.Drawing.Point(3, 46);
            this._cbProcSpellAura.Name = "_cbProcSpellAura";
            this._cbProcSpellAura.Size = new System.Drawing.Size(260, 21);
            this._cbProcSpellAura.TabIndex = 2;
            this._cbProcSpellAura.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellEffect
            // 
            this._cbProcSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellEffect.DropDownHeight = 500;
            this._cbProcSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellEffect.FormattingEnabled = true;
            this._cbProcSpellEffect.IntegralHeight = false;
            this._cbProcSpellEffect.Location = new System.Drawing.Point(3, 68);
            this._cbProcSpellEffect.Name = "_cbProcSpellEffect";
            this._cbProcSpellEffect.Size = new System.Drawing.Size(260, 21);
            this._cbProcSpellEffect.TabIndex = 3;
            this._cbProcSpellEffect.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcTarget1
            // 
            this._cbProcTarget1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcTarget1.DropDownHeight = 500;
            this._cbProcTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcTarget1.FormattingEnabled = true;
            this._cbProcTarget1.IntegralHeight = false;
            this._cbProcTarget1.Location = new System.Drawing.Point(3, 90);
            this._cbProcTarget1.Name = "_cbProcTarget1";
            this._cbProcTarget1.Size = new System.Drawing.Size(122, 21);
            this._cbProcTarget1.TabIndex = 3;
            this._cbProcTarget1.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcTarget2
            // 
            this._cbProcTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcTarget2.DropDownHeight = 500;
            this._cbProcTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcTarget2.FormattingEnabled = true;
            this._cbProcTarget2.IntegralHeight = false;
            this._cbProcTarget2.Location = new System.Drawing.Point(144, 90);
            this._cbProcTarget2.Name = "_cbProcTarget2";
            this._cbProcTarget2.Size = new System.Drawing.Size(119, 21);
            this._cbProcTarget2.TabIndex = 3;
            this._cbProcTarget2.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _tbProcSeach
            // 
            this._tbProcSeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbProcSeach.Location = new System.Drawing.Point(3, 3);
            this._tbProcSeach.Name = "_tbProcSeach";
            this._tbProcSeach.Size = new System.Drawing.Size(207, 20);
            this._tbProcSeach.TabIndex = 4;
            this._tbProcSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchKeyDown);
            // 
            // _bProcSearch
            // 
            this._bProcSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bProcSearch.Location = new System.Drawing.Point(215, 3);
            this._bProcSearch.Name = "_bProcSearch";
            this._bProcSearch.Size = new System.Drawing.Size(48, 20);
            this._bProcSearch.TabIndex = 5;
            this._bProcSearch.Text = "Search";
            this._bProcSearch.UseVisualStyleBackColor = true;
            this._bProcSearch.Click += new System.EventHandler(this.BProcSearchClick);
            // 
            // _lvProcSpellList
            // 
            this._lvProcSpellList.AllowColumnReorder = true;
            this._lvProcSpellList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvProcSpellList.FullRowSelect = true;
            this._lvProcSpellList.GridLines = true;
            this._lvProcSpellList.HideSelection = false;
            this._lvProcSpellList.Location = new System.Drawing.Point(2, 117);
            this._lvProcSpellList.MultiSelect = false;
            this._lvProcSpellList.Name = "_lvProcSpellList";
            this._lvProcSpellList.ShowItemToolTips = true;
            this._lvProcSpellList.Size = new System.Drawing.Size(261, 124);
            this._lvProcSpellList.TabIndex = 0;
            this._lvProcSpellList.UseCompatibleStateImageBehavior = false;
            this._lvProcSpellList.View = System.Windows.Forms.View.Details;
            this._lvProcSpellList.VirtualMode = true;
            this._lvProcSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvProcSpellListRetrieveVirtualItem);
            this._lvProcSpellList.SelectedIndexChanged += new System.EventHandler(this.LvProcSpellListSelectedIndexChanged);
            // 
            // _chProcID
            // 
            this._chProcID.DisplayIndex = 0;
            this._chProcID.Text = "ID";
            this._chProcID.Width = 45;
            // 
            // _chProcName
            // 
            this._chProcName.DisplayIndex = 1;
            this._chProcName.Text = "Name";
            this._chProcName.Width = 210;
            // 
            // _rtbProcSpellInfo
            // 
            this._rtbProcSpellInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this._rtbProcSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbProcSpellInfo.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this._rtbProcSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtbProcSpellInfo.Name = "_rtbProcSpellInfo";
            this._rtbProcSpellInfo.Size = new System.Drawing.Size(330, 244);
            this._rtbProcSpellInfo.TabIndex = 0;
            this._rtbProcSpellInfo.Text = "";
            // 
            // _tvFamilyTree
            // 
            this._tvFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tvFamilyTree.CheckBoxes = true;
            this._tvFamilyTree.LineColor = System.Drawing.Color.Empty;
            this._tvFamilyTree.Location = new System.Drawing.Point(1, 23);
            this._tvFamilyTree.Name = "_tvFamilyTree";
            this._tvFamilyTree.ShowNodeToolTips = true;
            this._tvFamilyTree.Size = new System.Drawing.Size(258, 219);
            this._tvFamilyTree.TabIndex = 0;
            this._tvFamilyTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.FamilyTreeAfterCheck);
            this._tvFamilyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvFamilyTreeAfterSelect);
            // 
            // _cbProcSpellFamilyTree
            // 
            this._cbProcSpellFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellFamilyTree.DropDownHeight = 500;
            this._cbProcSpellFamilyTree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellFamilyTree.FormattingEnabled = true;
            this._cbProcSpellFamilyTree.IntegralHeight = false;
            this._cbProcSpellFamilyTree.Location = new System.Drawing.Point(1, 2);
            this._cbProcSpellFamilyTree.Name = "_cbProcSpellFamilyTree";
            this._cbProcSpellFamilyTree.Size = new System.Drawing.Size(258, 21);
            this._cbProcSpellFamilyTree.TabIndex = 1;
            this._cbProcSpellFamilyTree.SelectedIndexChanged += new System.EventHandler(this.TvFamilyTreeSelectedIndexChanged);
            // 
            // _gSpellProcEvent
            // 
            this._gSpellProcEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gSpellProcEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gSpellProcEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._gSpellProcEvent.Location = new System.Drawing.Point(4, 0);
            this._gSpellProcEvent.Name = "_gSpellProcEvent";
            this._gSpellProcEvent.Size = new System.Drawing.Size(857, 63);
            this._gSpellProcEvent.TabIndex = 8;
            this._gSpellProcEvent.TabStop = false;
            // 
            // _tbCooldown
            // 
            this._tbCooldown.Location = new System.Drawing.Point(285, 38);
            this._tbCooldown.MaxLength = 10;
            this._tbCooldown.Name = "_tbCooldown";
            this._tbCooldown.Size = new System.Drawing.Size(60, 20);
            this._tbCooldown.TabIndex = 7;
            this._tbCooldown.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbCooldown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TextBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            // 
            // _tbChance
            // 
            this._tbChance.Location = new System.Drawing.Point(155, 38);
            this._tbChance.MaxLength = 10;
            this._tbChance.Name = "_tbChance";
            this._tbChance.Size = new System.Drawing.Size(60, 20);
            this._tbChance.TabIndex = 7;
            this._tbChance.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbChance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TextBoxKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            // 
            // _tbPPM
            // 
            this._tbPPM.Location = new System.Drawing.Point(39, 38);
            this._tbPPM.MaxLength = 10;
            this._tbPPM.Name = "_tbPPM";
            this._tbPPM.Size = new System.Drawing.Size(60, 20);
            this._tbPPM.TabIndex = 7;
            this._tbPPM.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbPPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TextBoxKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            // 
            // _cbProcFitstSpellFamily
            // 
            this._cbProcFitstSpellFamily.DropDownHeight = 500;
            this._cbProcFitstSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcFitstSpellFamily.FormattingEnabled = true;
            this._cbProcFitstSpellFamily.IntegralHeight = false;
            this._cbProcFitstSpellFamily.Location = new System.Drawing.Point(3, 14);
            this._cbProcFitstSpellFamily.Name = "_cbProcFitstSpellFamily";
            this._cbProcFitstSpellFamily.Size = new System.Drawing.Size(342, 21);
            this._cbProcFitstSpellFamily.TabIndex = 4;
            this._cbProcFitstSpellFamily.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _clbSchools
            // 
            this._clbSchools.CheckOnClick = true;
            this._clbSchools.ColumnWidth = 100;
            this._clbSchools.Dock = System.Windows.Forms.DockStyle.Right;
            this._clbSchools.FormattingEnabled = true;
            this._clbSchools.Location = new System.Drawing.Point(391, 16);
            this._clbSchools.MultiColumn = true;
            this._clbSchools.Name = "_clbSchools";
            this._clbSchools.Size = new System.Drawing.Size(463, 44);
            this._clbSchools.TabIndex = 5;
            this._clbSchools.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Location = new System.Drawing.Point(3, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(858, 75);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // _clbProcFlagEx
            // 
            this._clbProcFlagEx.CheckOnClick = true;
            this._clbProcFlagEx.ColumnWidth = 120;
            this._clbProcFlagEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlagEx.FormattingEnabled = true;
            this._clbProcFlagEx.Location = new System.Drawing.Point(3, 16);
            this._clbProcFlagEx.MultiColumn = true;
            this._clbProcFlagEx.Name = "_clbProcFlagEx";
            this._clbProcFlagEx.Size = new System.Drawing.Size(852, 56);
            this._clbProcFlagEx.TabIndex = 3;
            this._clbProcFlagEx.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(3, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(858, 115);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // _clbProcFlags
            // 
            this._clbProcFlags.CheckOnClick = true;
            this._clbProcFlags.ColumnWidth = 170;
            this._clbProcFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlags.FormattingEnabled = true;
            this._clbProcFlags.Location = new System.Drawing.Point(3, 16);
            this._clbProcFlags.MultiColumn = true;
            this._clbProcFlags.Name = "_clbProcFlags";
            this._clbProcFlags.Size = new System.Drawing.Size(852, 96);
            this._clbProcFlags.TabIndex = 0;
            this._clbProcFlags.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 16);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer6.Size = new System.Drawing.Size(858, 444);
            this.splitContainer6.SplitterDistance = 229;
            this.splitContainer6.TabIndex = 0;
            // 
            // _bSqlSave
            // 
            this._bSqlSave.Location = new System.Drawing.Point(3, 3);
            this._bSqlSave.Name = "_bSqlSave";
            this._bSqlSave.Size = new System.Drawing.Size(75, 23);
            this._bSqlSave.TabIndex = 1;
            this._bSqlSave.Text = "Save";
            this._bSqlSave.UseVisualStyleBackColor = true;
            this._bSqlSave.Click += new System.EventHandler(this.SqlSaveClick);
            // 
            // _bSqlToBase
            // 
            this._bSqlToBase.Location = new System.Drawing.Point(84, 3);
            this._bSqlToBase.Name = "_bSqlToBase";
            this._bSqlToBase.Size = new System.Drawing.Size(75, 23);
            this._bSqlToBase.TabIndex = 2;
            this._bSqlToBase.Text = "To DB";
            this._bSqlToBase.UseVisualStyleBackColor = true;
            this._bSqlToBase.Click += new System.EventHandler(this.SqlToBaseClick);
            // 
            // _rtbSqlLog
            // 
            this._rtbSqlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbSqlLog.Location = new System.Drawing.Point(0, 32);
            this._rtbSqlLog.Name = "_rtbSqlLog";
            this._rtbSqlLog.Size = new System.Drawing.Size(858, 182);
            this._rtbSqlLog.TabIndex = 3;
            this._rtbSqlLog.Text = "";
            // 
            // _lvDataList
            // 
            this._lvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvDataList.FullRowSelect = true;
            this._lvDataList.GridLines = true;
            this._lvDataList.HideSelection = false;
            this._lvDataList.Location = new System.Drawing.Point(0, 0);
            this._lvDataList.MultiSelect = false;
            this._lvDataList.Name = "_lvDataList";
            this._lvDataList.Size = new System.Drawing.Size(858, 229);
            this._lvDataList.TabIndex = 0;
            this._lvDataList.UseCompatibleStateImageBehavior = false;
            this._lvDataList.View = System.Windows.Forms.View.Details;
            this._lvDataList.VirtualMode = true;
            this._lvDataList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(LvSqlDataRetrieveVirtualItem);
            this._lvDataList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SqlDataListKeyDown);
            this._lvDataList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SqlDataListMouseDoubleClick);
            // 
            // entry
            // 
            this.entry.DisplayIndex = 0;
            this.entry.Text = "Entry";
            this.entry.Width = 56;
            // 
            // spellname
            // 
            this.spellname.DisplayIndex = 1;
            this.spellname.Text = "Spell Name";
            this.spellname.Width = 300;
            // 
            // schoolmask
            // 
            this.schoolmask.DisplayIndex = 2;
            this.schoolmask.Text = "School Mask";
            this.schoolmask.Width = 78;
            // 
            // spellfamilyname
            // 
            this.spellfamilyname.DisplayIndex = 3;
            this.spellfamilyname.Text = "Spell Family Name";
            this.spellfamilyname.Width = 103;
            // 
            // spellfamilymask0
            // 
            this.spellfamilymask0.DisplayIndex = 4;
            this.spellfamilymask0.Text = "Spell Family Mask 0";
            this.spellfamilymask0.Width = 110;
            // 
            // spellfamilymask1
            // 
            this.spellfamilymask1.DisplayIndex = 5;
            this.spellfamilymask1.Text = "Spell Family Mask 1";
            this.spellfamilymask1.Width = 110;
            // 
            // spellfamilymask2
            // 
            this.spellfamilymask2.DisplayIndex = 6;
            this.spellfamilymask2.Text = "Spell Family Mask 2";
            this.spellfamilymask2.Width = 110;
            // 
            // procflag
            // 
            this.procflag.DisplayIndex = 7;
            this.procflag.Text = "Proc Flags";
            this.procflag.Width = 80;
            // 
            // procEx
            // 
            this.procEx.DisplayIndex = 8;
            this.procEx.Text = "Proc Ex";
            this.procEx.Width = 80;
            // 
            // ppmRate
            // 
            this.ppmRate.DisplayIndex = 9;
            this.ppmRate.Text = "PPM Rate";
            this.ppmRate.Width = 67;
            // 
            // customchance
            // 
            this.customchance.DisplayIndex = 10;
            this.customchance.Text = "Custom Chance";
            this.customchance.Width = 93;
            // 
            // cooldown
            // 
            this.cooldown.DisplayIndex = 11;
            this.cooldown.Text = "Colldown";
            // 
            // _bSelect
            // 
            this._bSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSelect.Location = new System.Drawing.Point(775, 10);
            this._bSelect.Name = "_bSelect";
            this._bSelect.Size = new System.Drawing.Size(75, 23);
            this._bSelect.TabIndex = 0;
            this._bSelect.Text = "Select";
            this._bSelect.UseVisualStyleBackColor = true;
            this._bSelect.Click += new System.EventHandler(this.SelectClick);
            // 
            // _cbSqlSpellFamily
            // 
            this._cbSqlSpellFamily.DropDownHeight = 500;
            this._cbSqlSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSqlSpellFamily.FormattingEnabled = true;
            this._cbSqlSpellFamily.IntegralHeight = false;
            this._cbSqlSpellFamily.Location = new System.Drawing.Point(81, 17);
            this._cbSqlSpellFamily.Name = "_cbSqlSpellFamily";
            this._cbSqlSpellFamily.Size = new System.Drawing.Size(272, 21);
            this._cbSqlSpellFamily.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // _tbSqlSchool
            // 
            this._tbSqlSchool.Location = new System.Drawing.Point(620, 17);
            this._tbSqlSchool.Name = "_tbSqlSchool";
            this._tbSqlSchool.Size = new System.Drawing.Size(92, 20);
            this._tbSqlSchool.TabIndex = 3;
            // 
            // _tbSqlProc
            // 
            this._tbSqlProc.Location = new System.Drawing.Point(429, 53);
            this._tbSqlProc.Name = "_tbSqlProc";
            this._tbSqlProc.Size = new System.Drawing.Size(100, 20);
            this._tbSqlProc.TabIndex = 3;
            // 
            // _tbSqlProcEx
            // 
            this._tbSqlProcEx.Location = new System.Drawing.Point(620, 53);
            this._tbSqlProcEx.Name = "_tbSqlProcEx";
            this._tbSqlProcEx.Size = new System.Drawing.Size(92, 20);
            this._tbSqlProcEx.TabIndex = 3;
            // 
            // _bSqlSchool
            // 
            this._bSqlSchool.Location = new System.Drawing.Point(718, 15);
            this._bSqlSchool.Name = "_bSqlSchool";
            this._bSqlSchool.Size = new System.Drawing.Size(28, 23);
            this._bSqlSchool.TabIndex = 4;
            this._bSqlSchool.Text = "...";
            this._bSqlSchool.UseVisualStyleBackColor = true;
            this._bSqlSchool.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _bSqlProc
            // 
            this._bSqlProc.Location = new System.Drawing.Point(535, 51);
            this._bSqlProc.Name = "_bSqlProc";
            this._bSqlProc.Size = new System.Drawing.Size(28, 23);
            this._bSqlProc.TabIndex = 4;
            this._bSqlProc.Text = "...";
            this._bSqlProc.UseVisualStyleBackColor = true;
            this._bSqlProc.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _bSqlProcEx
            // 
            this._bSqlProcEx.Location = new System.Drawing.Point(718, 51);
            this._bSqlProcEx.Name = "_bSqlProcEx";
            this._bSqlProcEx.Size = new System.Drawing.Size(28, 23);
            this._bSqlProcEx.TabIndex = 4;
            this._bSqlProcEx.Text = "...";
            this._bSqlProcEx.UseVisualStyleBackColor = true;
            this._bSqlProcEx.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 5;
            // 
            // _tbSqlManual
            // 
            this._tbSqlManual.Location = new System.Drawing.Point(81, 53);
            this._tbSqlManual.Name = "_tbSqlManual";
            this._tbSqlManual.Size = new System.Drawing.Size(272, 20);
            this._tbSqlManual.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            // 
            // _cbBinaryCompare
            // 
            this._cbBinaryCompare.AutoSize = true;
            this._cbBinaryCompare.Location = new System.Drawing.Point(752, 55);
            this._cbBinaryCompare.Name = "_cbBinaryCompare";
            this._cbBinaryCompare.Size = new System.Drawing.Size(100, 17);
            this._cbBinaryCompare.TabIndex = 8;
            this._cbBinaryCompare.Text = "Binary Compare";
            this._cbBinaryCompare.UseVisualStyleBackColor = true;
            // 
            // _cbProcFlag
            // 
            this._cbProcFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this._cbProcFlag.AutoSize = true;
            this._cbProcFlag.Location = new System.Drawing.Point(743, 1);
            this._cbProcFlag.Name = "_cbProcFlag";
            this._cbProcFlag.Size = new System.Drawing.Size(59, 23);
            this._cbProcFlag.TabIndex = 2;
            this._cbProcFlag.Text = "ProcFlag";
            this._cbProcFlag.UseVisualStyleBackColor = true;
            this._cbProcFlag.Visible = false;
            this._cbProcFlag.CheckedChanged += new System.EventHandler(this.CbProcFlagCheckedChanged);
            // 
            // _bWrite
            // 
            this._bWrite.Enabled = false;
            this._bWrite.Location = new System.Drawing.Point(686, 1);
            this._bWrite.Name = "_bWrite";
            this._bWrite.Size = new System.Drawing.Size(51, 23);
            this._bWrite.TabIndex = 3;
            this._bWrite.Text = "Write";
            this._bWrite.UseVisualStyleBackColor = true;
            this._bWrite.Visible = false;
            this._bWrite.Click += new System.EventHandler(this.WriteClick);
            // 
            // _bLevelScaling
            // 
            this._bLevelScaling.Location = new System.Drawing.Point(808, 1);
            this._bLevelScaling.Name = "_bLevelScaling";
            this._bLevelScaling.Size = new System.Drawing.Size(60, 23);
            this._bLevelScaling.TabIndex = 4;
            this._bLevelScaling.Text = "Scaling";
            this._bLevelScaling.UseVisualStyleBackColor = true;
            this._bLevelScaling.Click += new System.EventHandler(this.LevelScalingClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this._bLevelScaling);
            this.Controls.Add(this._bWrite);
            this.Controls.Add(this._cbProcFlag);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(880, 585);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Resize += new System.EventHandler(this.FormMainResize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this._tpCompare.ResumeLayout(false);
            this._scCompareRoot.Panel1.ResumeLayout(false);
            this._scCompareRoot.Panel1.PerformLayout();
            this._scCompareRoot.Panel2.ResumeLayout(false);
            this._scCompareRoot.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scCompareRoot)).EndInit();
            this._scCompareRoot.ResumeLayout(false);
            this._tpSpellInfo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this._gSpellFilter.ResumeLayout(false);
            this._gbAdvansedSearch.ResumeLayout(false);
            this._gbAdvansedSearch.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this._tpSpellProcInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this._tpSqlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _status;
        private System.Windows.Forms.ToolStripStatusLabel _ProcStatus;
        private System.Windows.Forms.ToolStripStatusLabel _dbConnect;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ImageList _ilPro;
        private System.Windows.Forms.TabPage _tpCompare;
        private System.Windows.Forms.SplitContainer _scCompareRoot;
        private System.Windows.Forms.Button _bCompareSearch1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell1;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell1;
        private System.Windows.Forms.Button _bCompareSearch2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell2;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell2;
        private System.Windows.Forms.TabPage _tpSpellInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox _rtSpellInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView _lvSpellList;
        private System.Windows.Forms.ColumnHeader chSpellID;
        private System.Windows.Forms.ColumnHeader chSpellName;
        private System.Windows.Forms.GroupBox _gSpellFilter;
        private System.Windows.Forms.GroupBox _gbAdvansedSearch;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1CompareType;
        private System.Windows.Forms.ComboBox _cbEffectFilterCompareType;
        private System.Windows.Forms.TextBox _tbAdvancedFilter2Val;
        private System.Windows.Forms.TextBox _tbAdvancedFilter1Val;
        private System.Windows.Forms.TextBox _tbEffectFilterVal;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1;
        private System.Windows.Forms.ComboBox _cbEffectFilter;
        private System.Windows.Forms.ComboBox _cbTarget2;
        private System.Windows.Forms.ComboBox _cbTarget1;
        private System.Windows.Forms.ComboBox _cbSpellEffect;
        private System.Windows.Forms.ComboBox _cbSpellAura;
        private System.Windows.Forms.ComboBox _cbSpellFamilyName;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _bSearch;
        private System.Windows.Forms.TextBox _tbSearchAttributes;
        private System.Windows.Forms.TextBox _tbSearchIcon;
        private System.Windows.Forms.TextBox _tbSearchId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem _tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem _tsmAbout;
        private System.Windows.Forms.TabPage _tpSpellProcInfo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage _tpSqlData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView _lvProcAdditionalInfo;
        private System.Windows.Forms.ColumnHeader _chID;
        private System.Windows.Forms.ColumnHeader _chName;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ComboBox _cbProcSpellFamilyName;
        private System.Windows.Forms.ComboBox _cbProcSpellAura;
        private System.Windows.Forms.ComboBox _cbProcSpellEffect;
        private System.Windows.Forms.ComboBox _cbProcTarget1;
        private System.Windows.Forms.ComboBox _cbProcTarget2;
        private System.Windows.Forms.TextBox _tbProcSeach;
        private System.Windows.Forms.Button _bProcSearch;
        private System.Windows.Forms.ListView _lvProcSpellList;
        private System.Windows.Forms.ColumnHeader _chProcID;
        private System.Windows.Forms.ColumnHeader _chProcName;
        private System.Windows.Forms.RichTextBox _rtbProcSpellInfo;
        private System.Windows.Forms.TreeView _tvFamilyTree;
        private System.Windows.Forms.ComboBox _cbProcSpellFamilyTree;
        private System.Windows.Forms.GroupBox _gSpellProcEvent;
        private System.Windows.Forms.TextBox _tbCooldown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbPPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbProcFitstSpellFamily;
        private System.Windows.Forms.CheckedListBox _clbSchools;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox _clbProcFlagEx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox _clbProcFlags;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button _bSqlSave;
        private System.Windows.Forms.Button _bSqlToBase;
        private System.Windows.Forms.RichTextBox _rtbSqlLog;
        private System.Windows.Forms.ListView _lvDataList;
        private System.Windows.Forms.ColumnHeader entry;
        private System.Windows.Forms.ColumnHeader spellname;
        private System.Windows.Forms.ColumnHeader schoolmask;
        private System.Windows.Forms.ColumnHeader spellfamilyname;
        private System.Windows.Forms.ColumnHeader spellfamilymask0;
        private System.Windows.Forms.ColumnHeader spellfamilymask1;
        private System.Windows.Forms.ColumnHeader spellfamilymask2;
        private System.Windows.Forms.ColumnHeader procflag;
        private System.Windows.Forms.ColumnHeader procEx;
        private System.Windows.Forms.ColumnHeader ppmRate;
        private System.Windows.Forms.ColumnHeader customchance;
        private System.Windows.Forms.ColumnHeader cooldown;
        private System.Windows.Forms.Button _bSelect;
        private System.Windows.Forms.ComboBox _cbSqlSpellFamily;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox _tbSqlSchool;
        private System.Windows.Forms.TextBox _tbSqlProc;
        private System.Windows.Forms.TextBox _tbSqlProcEx;
        private System.Windows.Forms.Button _bSqlSchool;
        private System.Windows.Forms.Button _bSqlProc;
        private System.Windows.Forms.Button _bSqlProcEx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _tbSqlManual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox _cbBinaryCompare;
        private System.Windows.Forms.CheckBox _cbProcFlag;
        private System.Windows.Forms.Button _bWrite;
        private System.Windows.Forms.ToolStripMenuItem _tsmFile;
        private System.Windows.Forms.ToolStripMenuItem _Connected;
        private System.Windows.Forms.ToolStripMenuItem _tsmSettings;
        private System.Windows.Forms.ToolStripMenuItem _tsmExit;
        private System.Windows.Forms.Button _bLevelScaling;
    }
}