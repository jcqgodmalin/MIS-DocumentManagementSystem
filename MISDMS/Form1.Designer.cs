namespace MISDMS
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Welcome");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Connection Properties");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Documents");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Add Documents");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Document Properties");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Documents Management", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Exit");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scMainWin = new System.Windows.Forms.SplitContainer();
            this.tvMainNav = new System.Windows.Forms.TreeView();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tslDate = new System.Windows.Forms.ToolStripLabel();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.conPropPanel = new System.Windows.Forms.Panel();
            this.docPropPanel = new System.Windows.Forms.Panel();
            this.addDocPanel = new System.Windows.Forms.Panel();
            this.manDocPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkToday = new System.Windows.Forms.CheckBox();
            this.btnDIEdit = new System.Windows.Forms.Button();
            this.btnDIDel = new System.Windows.Forms.Button();
            this.btnDIPrint = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.cbDIType = new System.Windows.Forms.ComboBox();
            this.cbDICat = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.cbDISem = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbDIDate = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnDIBrowse = new System.Windows.Forms.Button();
            this.tbDIPath = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbDIName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblClearSearch = new System.Windows.Forms.Label();
            this.lblNumOfRows = new System.Windows.Forms.Label();
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbAddType = new System.Windows.Forms.ComboBox();
            this.cbAddCat = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbAddSem = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbDocName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDateCustom = new System.Windows.Forms.TextBox();
            this.rbDateCustom = new System.Windows.Forms.RadioButton();
            this.rbDateToday = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.tbAddType = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lstType = new System.Windows.Forms.ListBox();
            this.cmsTypeList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmTypeDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCat = new System.Windows.Forms.GroupBox();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.tbAddCat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstCat = new System.Windows.Forms.ListBox();
            this.cmsCatList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCatDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.cbCats = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDBList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbServCred = new System.Windows.Forms.GroupBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnCheckCon = new System.Windows.Forms.Button();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbServ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.conPropLabel2 = new System.Windows.Forms.Label();
            this.conPropLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timrClockStats = new System.Windows.Forms.Timer(this.components);
            this.lblDISafeFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scMainWin)).BeginInit();
            this.scMainWin.Panel1.SuspendLayout();
            this.scMainWin.Panel2.SuspendLayout();
            this.scMainWin.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.WelcomePanel.SuspendLayout();
            this.conPropPanel.SuspendLayout();
            this.docPropPanel.SuspendLayout();
            this.addDocPanel.SuspendLayout();
            this.manDocPanel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsTypeList.SuspendLayout();
            this.gbCat.SuspendLayout();
            this.cmsCatList.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.gbDatabase.SuspendLayout();
            this.gbServCred.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMainWin
            // 
            this.scMainWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainWin.Location = new System.Drawing.Point(0, 0);
            this.scMainWin.Name = "scMainWin";
            // 
            // scMainWin.Panel1
            // 
            this.scMainWin.Panel1.Controls.Add(this.tvMainNav);
            this.scMainWin.Panel1MinSize = 150;
            // 
            // scMainWin.Panel2
            // 
            this.scMainWin.Panel2.Controls.Add(this.tsMain);
            this.scMainWin.Panel2.Controls.Add(this.WelcomePanel);
            this.scMainWin.Panel2MinSize = 500;
            this.scMainWin.Size = new System.Drawing.Size(700, 460);
            this.scMainWin.SplitterDistance = 150;
            this.scMainWin.TabIndex = 0;
            // 
            // tvMainNav
            // 
            this.tvMainNav.BackColor = System.Drawing.Color.Gainsboro;
            this.tvMainNav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMainNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMainNav.Location = new System.Drawing.Point(0, 0);
            this.tvMainNav.Name = "tvMainNav";
            treeNode1.Name = "welcome";
            treeNode1.Text = "Welcome";
            treeNode2.Name = "conProp";
            treeNode2.Text = "Connection Properties";
            treeNode3.Name = "mDoc";
            treeNode3.Text = "Documents";
            treeNode4.Name = "aDoc";
            treeNode4.Text = "Add Documents";
            treeNode5.Name = "pDoc";
            treeNode5.Text = "Document Properties";
            treeNode6.Name = "docManagement";
            treeNode6.Text = "Documents Management";
            treeNode7.Name = "help";
            treeNode7.Text = "Help";
            treeNode8.Name = "exit";
            treeNode8.Text = "Exit";
            this.tvMainNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode6,
            treeNode7,
            treeNode8});
            this.tvMainNav.Size = new System.Drawing.Size(150, 460);
            this.tvMainNav.TabIndex = 0;
            this.tvMainNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMainNav_AfterSelect);
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.LightGray;
            this.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslDate});
            this.tsMain.Location = new System.Drawing.Point(0, 435);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(546, 25);
            this.tsMain.Stretch = true;
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tslDate
            // 
            this.tslDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslDate.Name = "tslDate";
            this.tslDate.Size = new System.Drawing.Size(113, 22);
            this.tslDate.Text = "Date: MM/DD/YYYY";
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.White;
            this.WelcomePanel.Controls.Add(this.conPropPanel);
            this.WelcomePanel.Controls.Add(this.label4);
            this.WelcomePanel.Controls.Add(this.label3);
            this.WelcomePanel.Controls.Add(this.linkLabel1);
            this.WelcomePanel.Controls.Add(this.label2);
            this.WelcomePanel.Controls.Add(this.label1);
            this.WelcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomePanel.Location = new System.Drawing.Point(0, 0);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(546, 460);
            this.WelcomePanel.TabIndex = 1;
            // 
            // conPropPanel
            // 
            this.conPropPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.conPropPanel.Controls.Add(this.docPropPanel);
            this.conPropPanel.Controls.Add(this.gbEdit);
            this.conPropPanel.Controls.Add(this.conPropLabel2);
            this.conPropPanel.Controls.Add(this.conPropLabel1);
            this.conPropPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conPropPanel.Location = new System.Drawing.Point(0, 0);
            this.conPropPanel.Name = "conPropPanel";
            this.conPropPanel.Size = new System.Drawing.Size(546, 460);
            this.conPropPanel.TabIndex = 5;
            // 
            // docPropPanel
            // 
            this.docPropPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.docPropPanel.Controls.Add(this.addDocPanel);
            this.docPropPanel.Controls.Add(this.groupBox1);
            this.docPropPanel.Controls.Add(this.gbCat);
            this.docPropPanel.Controls.Add(this.label13);
            this.docPropPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docPropPanel.Location = new System.Drawing.Point(0, 0);
            this.docPropPanel.Name = "docPropPanel";
            this.docPropPanel.Size = new System.Drawing.Size(546, 460);
            this.docPropPanel.TabIndex = 2;
            // 
            // addDocPanel
            // 
            this.addDocPanel.Controls.Add(this.manDocPanel);
            this.addDocPanel.Controls.Add(this.label24);
            this.addDocPanel.Controls.Add(this.btnAddDoc);
            this.addDocPanel.Controls.Add(this.groupBox3);
            this.addDocPanel.Controls.Add(this.groupBox2);
            this.addDocPanel.Controls.Add(this.gbDate);
            this.addDocPanel.Controls.Add(this.label19);
            this.addDocPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDocPanel.Location = new System.Drawing.Point(0, 0);
            this.addDocPanel.Name = "addDocPanel";
            this.addDocPanel.Size = new System.Drawing.Size(546, 460);
            this.addDocPanel.TabIndex = 6;
            // 
            // manDocPanel
            // 
            this.manDocPanel.Controls.Add(this.groupBox5);
            this.manDocPanel.Controls.Add(this.groupBox4);
            this.manDocPanel.Controls.Add(this.label27);
            this.manDocPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manDocPanel.Location = new System.Drawing.Point(0, 0);
            this.manDocPanel.Name = "manDocPanel";
            this.manDocPanel.Size = new System.Drawing.Size(546, 460);
            this.manDocPanel.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDISafeFileName);
            this.groupBox5.Controls.Add(this.checkToday);
            this.groupBox5.Controls.Add(this.btnDIEdit);
            this.groupBox5.Controls.Add(this.btnDIDel);
            this.groupBox5.Controls.Add(this.btnDIPrint);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.cbDIType);
            this.groupBox5.Controls.Add(this.cbDICat);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.cbDISem);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.tbDIDate);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.btnDIBrowse);
            this.groupBox5.Controls.Add(this.tbDIPath);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.tbDIName);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Location = new System.Drawing.Point(15, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 136);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Document Information ";
            // 
            // checkToday
            // 
            this.checkToday.AutoSize = true;
            this.checkToday.Enabled = false;
            this.checkToday.Location = new System.Drawing.Point(329, 68);
            this.checkToday.Name = "checkToday";
            this.checkToday.Size = new System.Drawing.Size(56, 17);
            this.checkToday.TabIndex = 17;
            this.checkToday.Text = "Today";
            this.checkToday.UseVisualStyleBackColor = true;
            this.checkToday.CheckedChanged += new System.EventHandler(this.checkToday_CheckedChanged);
            // 
            // btnDIEdit
            // 
            this.btnDIEdit.Enabled = false;
            this.btnDIEdit.Location = new System.Drawing.Point(277, 104);
            this.btnDIEdit.Name = "btnDIEdit";
            this.btnDIEdit.Size = new System.Drawing.Size(75, 23);
            this.btnDIEdit.TabIndex = 16;
            this.btnDIEdit.Text = "Edit";
            this.btnDIEdit.UseVisualStyleBackColor = true;
            this.btnDIEdit.Click += new System.EventHandler(this.btnDIEdit_Click);
            // 
            // btnDIDel
            // 
            this.btnDIDel.Enabled = false;
            this.btnDIDel.Location = new System.Drawing.Point(358, 104);
            this.btnDIDel.Name = "btnDIDel";
            this.btnDIDel.Size = new System.Drawing.Size(75, 23);
            this.btnDIDel.TabIndex = 15;
            this.btnDIDel.Text = "Delete";
            this.btnDIDel.UseVisualStyleBackColor = true;
            this.btnDIDel.Click += new System.EventHandler(this.btnDIDel_Click);
            // 
            // btnDIPrint
            // 
            this.btnDIPrint.Enabled = false;
            this.btnDIPrint.Location = new System.Drawing.Point(439, 103);
            this.btnDIPrint.Name = "btnDIPrint";
            this.btnDIPrint.Size = new System.Drawing.Size(75, 23);
            this.btnDIPrint.TabIndex = 14;
            this.btnDIPrint.Text = "Print";
            this.btnDIPrint.UseVisualStyleBackColor = true;
            this.btnDIPrint.Click += new System.EventHandler(this.btnDIPrint_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 109);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 13);
            this.label34.TabIndex = 13;
            this.label34.Text = "Type:";
            // 
            // cbDIType
            // 
            this.cbDIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDIType.Enabled = false;
            this.cbDIType.FormattingEnabled = true;
            this.cbDIType.Location = new System.Drawing.Point(79, 106);
            this.cbDIType.Name = "cbDIType";
            this.cbDIType.Size = new System.Drawing.Size(120, 21);
            this.cbDIType.TabIndex = 12;
            // 
            // cbDICat
            // 
            this.cbDICat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDICat.Enabled = false;
            this.cbDICat.FormattingEnabled = true;
            this.cbDICat.Location = new System.Drawing.Point(79, 81);
            this.cbDICat.Name = "cbDICat";
            this.cbDICat.Size = new System.Drawing.Size(120, 21);
            this.cbDICat.TabIndex = 11;
            this.cbDICat.SelectedIndexChanged += new System.EventHandler(this.cbDICat_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 84);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 13);
            this.label33.TabIndex = 10;
            this.label33.Text = "Category:";
            // 
            // cbDISem
            // 
            this.cbDISem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDISem.Enabled = false;
            this.cbDISem.FormattingEnabled = true;
            this.cbDISem.Items.AddRange(new object[] {
            "0 - N/A",
            "1 - First Sem",
            "2 - Second Sem",
            "3 - Summer"});
            this.cbDISem.Location = new System.Drawing.Point(79, 54);
            this.cbDISem.Name = "cbDISem";
            this.cbDISem.Size = new System.Drawing.Size(120, 21);
            this.cbDISem.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 57);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 13);
            this.label32.TabIndex = 8;
            this.label32.Text = "Semester:";
            // 
            // tbDIDate
            // 
            this.tbDIDate.Location = new System.Drawing.Point(329, 42);
            this.tbDIDate.Name = "tbDIDate";
            this.tbDIDate.ReadOnly = true;
            this.tbDIDate.Size = new System.Drawing.Size(143, 20);
            this.tbDIDate.TabIndex = 7;
            this.tbDIDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(238, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "Document Date:";
            // 
            // btnDIBrowse
            // 
            this.btnDIBrowse.Enabled = false;
            this.btnDIBrowse.Location = new System.Drawing.Point(478, 18);
            this.btnDIBrowse.Name = "btnDIBrowse";
            this.btnDIBrowse.Size = new System.Drawing.Size(30, 21);
            this.btnDIBrowse.TabIndex = 5;
            this.btnDIBrowse.Text = "...";
            this.btnDIBrowse.UseVisualStyleBackColor = true;
            this.btnDIBrowse.Click += new System.EventHandler(this.btnDIBrowse_Click);
            // 
            // tbDIPath
            // 
            this.tbDIPath.Location = new System.Drawing.Point(272, 19);
            this.tbDIPath.Name = "tbDIPath";
            this.tbDIPath.ReadOnly = true;
            this.tbDIPath.Size = new System.Drawing.Size(200, 20);
            this.tbDIPath.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(238, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Path:";
            // 
            // tbDIName
            // 
            this.tbDIName.Location = new System.Drawing.Point(52, 19);
            this.tbDIName.Name = "tbDIName";
            this.tbDIName.ReadOnly = true;
            this.tbDIName.Size = new System.Drawing.Size(147, 20);
            this.tbDIName.TabIndex = 1;
            this.tbDIName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblClearSearch);
            this.groupBox4.Controls.Add(this.lblNumOfRows);
            this.groupBox4.Controls.Add(this.dgvDocs);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.tbSearchTerm);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.cbSearchBy);
            this.groupBox4.Location = new System.Drawing.Point(15, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 237);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // lblClearSearch
            // 
            this.lblClearSearch.AutoSize = true;
            this.lblClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearSearch.Location = new System.Drawing.Point(446, 50);
            this.lblClearSearch.Name = "lblClearSearch";
            this.lblClearSearch.Size = new System.Drawing.Size(68, 13);
            this.lblClearSearch.TabIndex = 6;
            this.lblClearSearch.Text = "Clear Search";
            this.lblClearSearch.Visible = false;
            this.lblClearSearch.Click += new System.EventHandler(this.lblClearSearch_Click);
            // 
            // lblNumOfRows
            // 
            this.lblNumOfRows.AutoSize = true;
            this.lblNumOfRows.Location = new System.Drawing.Point(3, 48);
            this.lblNumOfRows.Name = "lblNumOfRows";
            this.lblNumOfRows.Size = new System.Drawing.Size(168, 13);
            this.lblNumOfRows.TabIndex = 5;
            this.lblNumOfRows.Text = "Showing all N documents records.";
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            this.dgvDocs.AllowUserToResizeRows = false;
            this.dgvDocs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Location = new System.Drawing.Point(6, 68);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.ReadOnly = true;
            this.dgvDocs.RowHeadersVisible = false;
            this.dgvDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocs.Size = new System.Drawing.Size(508, 163);
            this.dgvDocs.TabIndex = 4;
            this.dgvDocs.SelectionChanged += new System.EventHandler(this.dgvDocs_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(478, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 21);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.Location = new System.Drawing.Point(326, 15);
            this.tbSearchTerm.Multiline = true;
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.Size = new System.Drawing.Size(146, 21);
            this.tbSearchTerm.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(172, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "Search by:";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Name",
            "Category",
            "Type",
            "Semester",
            "Year",
            "Month"});
            this.cbSearchBy.Location = new System.Drawing.Point(230, 15);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(90, 21);
            this.cbSearchBy.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 7);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(152, 31);
            this.label27.TabIndex = 3;
            this.label27.Text = "Documents";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "All fields are required.";
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Location = new System.Drawing.Point(423, 381);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(108, 27);
            this.btnAddDoc.TabIndex = 5;
            this.btnAddDoc.Text = "Add Document";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.cbAddType);
            this.groupBox3.Controls.Add(this.cbAddCat);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.cbAddSem);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.tbDocName);
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 145);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Document Properties";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(79, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "Type: *";
            // 
            // cbAddType
            // 
            this.cbAddType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddType.FormattingEnabled = true;
            this.cbAddType.Location = new System.Drawing.Point(187, 108);
            this.cbAddType.Name = "cbAddType";
            this.cbAddType.Size = new System.Drawing.Size(121, 21);
            this.cbAddType.TabIndex = 8;
            // 
            // cbAddCat
            // 
            this.cbAddCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddCat.FormattingEnabled = true;
            this.cbAddCat.Location = new System.Drawing.Point(187, 81);
            this.cbAddCat.Name = "cbAddCat";
            this.cbAddCat.Size = new System.Drawing.Size(121, 21);
            this.cbAddCat.TabIndex = 7;
            this.cbAddCat.SelectedIndexChanged += new System.EventHandler(this.cbAddCat_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(79, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "Category: *";
            // 
            // cbAddSem
            // 
            this.cbAddSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddSem.FormattingEnabled = true;
            this.cbAddSem.Items.AddRange(new object[] {
            "0 - N/A",
            "1 - 1st Sem",
            "2 - 2nd Sem",
            "3 - Summer"});
            this.cbAddSem.Location = new System.Drawing.Point(187, 54);
            this.cbAddSem.Name = "cbAddSem";
            this.cbAddSem.Size = new System.Drawing.Size(121, 21);
            this.cbAddSem.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(79, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Semester Valid: *";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(79, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Document Name: *";
            // 
            // tbDocName
            // 
            this.tbDocName.Location = new System.Drawing.Point(187, 28);
            this.tbDocName.Name = "tbDocName";
            this.tbDocName.Size = new System.Drawing.Size(220, 20);
            this.tbDocName.TabIndex = 2;
            this.tbDocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFileName);
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.tbFilePath);
            this.groupBox2.Location = new System.Drawing.Point(190, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 81);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload Document *";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(63, 55);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "File Name";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(296, 28);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(39, 20);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "...";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "File Path:";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Enabled = false;
            this.tbFilePath.Location = new System.Drawing.Point(63, 28);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(227, 20);
            this.tbFilePath.TabIndex = 2;
            this.tbFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.label20);
            this.gbDate.Controls.Add(this.tbDateCustom);
            this.gbDate.Controls.Add(this.rbDateCustom);
            this.gbDate.Controls.Add(this.rbDateToday);
            this.gbDate.Location = new System.Drawing.Point(12, 88);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(166, 111);
            this.gbDate.TabIndex = 5;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date *";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Format: mm/dd/yyyy";
            // 
            // tbDateCustom
            // 
            this.tbDateCustom.Enabled = false;
            this.tbDateCustom.Location = new System.Drawing.Point(23, 66);
            this.tbDateCustom.Name = "tbDateCustom";
            this.tbDateCustom.Size = new System.Drawing.Size(123, 20);
            this.tbDateCustom.TabIndex = 2;
            // 
            // rbDateCustom
            // 
            this.rbDateCustom.AutoSize = true;
            this.rbDateCustom.Location = new System.Drawing.Point(23, 43);
            this.rbDateCustom.Name = "rbDateCustom";
            this.rbDateCustom.Size = new System.Drawing.Size(60, 17);
            this.rbDateCustom.TabIndex = 1;
            this.rbDateCustom.TabStop = true;
            this.rbDateCustom.Text = "Custom";
            this.rbDateCustom.UseVisualStyleBackColor = true;
            this.rbDateCustom.CheckedChanged += new System.EventHandler(this.rbDateCustom_CheckedChanged);
            // 
            // rbDateToday
            // 
            this.rbDateToday.AutoSize = true;
            this.rbDateToday.Location = new System.Drawing.Point(23, 19);
            this.rbDateToday.Name = "rbDateToday";
            this.rbDateToday.Size = new System.Drawing.Size(55, 17);
            this.rbDateToday.TabIndex = 0;
            this.rbDateToday.TabStop = true;
            this.rbDateToday.Text = "Today";
            this.rbDateToday.UseVisualStyleBackColor = true;
            this.rbDateToday.CheckedChanged += new System.EventHandler(this.rbDateToday_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 31);
            this.label19.TabIndex = 2;
            this.label19.Text = "Add Document";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnAddType);
            this.groupBox1.Controls.Add(this.tbAddType);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lstType);
            this.groupBox1.Location = new System.Drawing.Point(278, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Types";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 26);
            this.label18.TabIndex = 5;
            this.label18.Text = "Select a Category to\r\nshow its types.\r\n";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(51, 74);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 23);
            this.btnAddType.TabIndex = 4;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // tbAddType
            // 
            this.tbAddType.Location = new System.Drawing.Point(9, 47);
            this.tbAddType.Name = "tbAddType";
            this.tbAddType.Size = new System.Drawing.Size(118, 20);
            this.tbAddType.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Add New Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(134, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Type List:";
            // 
            // lstType
            // 
            this.lstType.ContextMenuStrip = this.cmsTypeList;
            this.lstType.FormattingEnabled = true;
            this.lstType.Location = new System.Drawing.Point(137, 47);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(120, 173);
            this.lstType.TabIndex = 0;
            // 
            // cmsTypeList
            // 
            this.cmsTypeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTypeDelete});
            this.cmsTypeList.Name = "cmsCatList";
            this.cmsTypeList.Size = new System.Drawing.Size(108, 26);
            // 
            // tsmTypeDelete
            // 
            this.tsmTypeDelete.Name = "tsmTypeDelete";
            this.tsmTypeDelete.Size = new System.Drawing.Size(107, 22);
            this.tsmTypeDelete.Text = "Delete";
            this.tsmTypeDelete.Click += new System.EventHandler(this.tsmTypeDelete_Click);
            // 
            // gbCat
            // 
            this.gbCat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbCat.Controls.Add(this.btnAddCat);
            this.gbCat.Controls.Add(this.tbAddCat);
            this.gbCat.Controls.Add(this.label15);
            this.gbCat.Controls.Add(this.label14);
            this.gbCat.Controls.Add(this.lstCat);
            this.gbCat.Location = new System.Drawing.Point(9, 47);
            this.gbCat.Name = "gbCat";
            this.gbCat.Size = new System.Drawing.Size(263, 226);
            this.gbCat.TabIndex = 2;
            this.gbCat.TabStop = false;
            this.gbCat.Text = "Categories";
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(51, 74);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddCat.TabIndex = 4;
            this.btnAddCat.Text = "Add";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // tbAddCat
            // 
            this.tbAddCat.Location = new System.Drawing.Point(9, 47);
            this.tbAddCat.Name = "tbAddCat";
            this.tbAddCat.Size = new System.Drawing.Size(118, 20);
            this.tbAddCat.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Add New Category";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Category List:";
            // 
            // lstCat
            // 
            this.lstCat.ContextMenuStrip = this.cmsCatList;
            this.lstCat.FormattingEnabled = true;
            this.lstCat.Location = new System.Drawing.Point(137, 47);
            this.lstCat.Name = "lstCat";
            this.lstCat.Size = new System.Drawing.Size(120, 173);
            this.lstCat.TabIndex = 0;
            this.lstCat.SelectedValueChanged += new System.EventHandler(this.lstCat_SelectedValueChanged);
            // 
            // cmsCatList
            // 
            this.cmsCatList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCatDelete});
            this.cmsCatList.Name = "cmsCatList";
            this.cmsCatList.Size = new System.Drawing.Size(108, 26);
            // 
            // tsmCatDelete
            // 
            this.tsmCatDelete.Name = "tsmCatDelete";
            this.tsmCatDelete.Size = new System.Drawing.Size(107, 22);
            this.tsmCatDelete.Text = "Delete";
            this.tsmCatDelete.Click += new System.EventHandler(this.tsmCatDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 31);
            this.label13.TabIndex = 1;
            this.label13.Text = "Document Properties";
            // 
            // gbEdit
            // 
            this.gbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEdit.Controls.Add(this.btnSaveSettings);
            this.gbEdit.Controls.Add(this.gbDatabase);
            this.gbEdit.Controls.Add(this.gbServCred);
            this.gbEdit.Location = new System.Drawing.Point(9, 108);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(525, 324);
            this.gbEdit.TabIndex = 1;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit Connection Properties";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.Location = new System.Drawing.Point(381, 284);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Padding = new System.Windows.Forms.Padding(5);
            this.btnSaveSettings.Size = new System.Drawing.Size(138, 34);
            this.btnSaveSettings.TabIndex = 14;
            this.btnSaveSettings.Text = "Save New Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // gbDatabase
            // 
            this.gbDatabase.Controls.Add(this.label11);
            this.gbDatabase.Controls.Add(this.cbTypes);
            this.gbDatabase.Controls.Add(this.cbCats);
            this.gbDatabase.Controls.Add(this.label10);
            this.gbDatabase.Controls.Add(this.cbDoc);
            this.gbDatabase.Controls.Add(this.label9);
            this.gbDatabase.Controls.Add(this.cbDBList);
            this.gbDatabase.Controls.Add(this.label5);
            this.gbDatabase.Enabled = false;
            this.gbDatabase.Location = new System.Drawing.Point(263, 19);
            this.gbDatabase.Name = "gbDatabase";
            this.gbDatabase.Size = new System.Drawing.Size(251, 188);
            this.gbDatabase.TabIndex = 10;
            this.gbDatabase.TabStop = false;
            this.gbDatabase.Text = "Database and Table Settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "\'Type\' Table:";
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(113, 103);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(132, 21);
            this.cbTypes.TabIndex = 10;
            // 
            // cbCats
            // 
            this.cbCats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCats.FormattingEnabled = true;
            this.cbCats.Location = new System.Drawing.Point(113, 77);
            this.cbCats.Name = "cbCats";
            this.cbCats.Size = new System.Drawing.Size(132, 21);
            this.cbCats.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "\'Category\' Table:";
            // 
            // cbDoc
            // 
            this.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoc.FormattingEnabled = true;
            this.cbDoc.Location = new System.Drawing.Point(113, 51);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(132, 21);
            this.cbDoc.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "\'Documents\' Table:";
            // 
            // cbDBList
            // 
            this.cbDBList.FormattingEnabled = true;
            this.cbDBList.Location = new System.Drawing.Point(113, 26);
            this.cbDBList.Name = "cbDBList";
            this.cbDBList.Size = new System.Drawing.Size(132, 21);
            this.cbDBList.TabIndex = 5;
            this.cbDBList.SelectedIndexChanged += new System.EventHandler(this.cbDBList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Database:";
            // 
            // gbServCred
            // 
            this.gbServCred.Controls.Add(this.tbPass);
            this.gbServCred.Controls.Add(this.btnCheckCon);
            this.gbServCred.Controls.Add(this.tbUID);
            this.gbServCred.Controls.Add(this.label6);
            this.gbServCred.Controls.Add(this.label8);
            this.gbServCred.Controls.Add(this.tbServ);
            this.gbServCred.Controls.Add(this.label7);
            this.gbServCred.Location = new System.Drawing.Point(6, 19);
            this.gbServCred.Name = "gbServCred";
            this.gbServCred.Size = new System.Drawing.Size(251, 151);
            this.gbServCred.TabIndex = 9;
            this.gbServCred.TabStop = false;
            this.gbServCred.Text = "Server Credentials";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(101, 78);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(144, 20);
            this.tbPass.TabIndex = 8;
            // 
            // btnCheckCon
            // 
            this.btnCheckCon.Location = new System.Drawing.Point(6, 117);
            this.btnCheckCon.Name = "btnCheckCon";
            this.btnCheckCon.Padding = new System.Windows.Forms.Padding(3);
            this.btnCheckCon.Size = new System.Drawing.Size(239, 28);
            this.btnCheckCon.TabIndex = 1;
            this.btnCheckCon.Text = "Check Connection and Set Database Settings";
            this.btnCheckCon.UseVisualStyleBackColor = true;
            this.btnCheckCon.Click += new System.EventHandler(this.btnCheckCon_Click);
            // 
            // tbUID
            // 
            this.tbUID.Location = new System.Drawing.Point(101, 52);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(144, 20);
            this.tbUID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Server:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password:";
            // 
            // tbServ
            // 
            this.tbServ.Location = new System.Drawing.Point(101, 26);
            this.tbServ.Name = "tbServ";
            this.tbServ.Size = new System.Drawing.Size(144, 20);
            this.tbServ.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "User ID:";
            // 
            // conPropLabel2
            // 
            this.conPropLabel2.AutoSize = true;
            this.conPropLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPropLabel2.Location = new System.Drawing.Point(9, 38);
            this.conPropLabel2.Name = "conPropLabel2";
            this.conPropLabel2.Size = new System.Drawing.Size(127, 34);
            this.conPropLabel2.TabIndex = 0;
            this.conPropLabel2.Text = "Server:\r\nConnection Status:";
            // 
            // conPropLabel1
            // 
            this.conPropLabel1.AutoSize = true;
            this.conPropLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPropLabel1.Location = new System.Drawing.Point(3, 2);
            this.conPropLabel1.Name = "conPropLabel1";
            this.conPropLabel1.Size = new System.Drawing.Size(283, 31);
            this.conPropLabel1.TabIndex = 0;
            this.conPropLabel1.Text = "Connection Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Software Version : 1.0\r\nState: Beta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "By Gabriel, Norhanie\r\nOJT - Lyceum of Iligan Foundation\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 251);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.lezirhc.github.com/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 143);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MIS - Documents Management System";
            // 
            // timrClockStats
            // 
            this.timrClockStats.Enabled = true;
            this.timrClockStats.Interval = 1000;
            this.timrClockStats.Tick += new System.EventHandler(this.timrClockStats_Tick);
            // 
            // lblDISafeFileName
            // 
            this.lblDISafeFileName.AutoSize = true;
            this.lblDISafeFileName.Location = new System.Drawing.Point(418, 69);
            this.lblDISafeFileName.Name = "lblDISafeFileName";
            this.lblDISafeFileName.Size = new System.Drawing.Size(32, 13);
            this.lblDISafeFileName.TabIndex = 18;
            this.lblDISafeFileName.Text = "Path:";
            this.lblDISafeFileName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.ControlBox = false;
            this.Controls.Add(this.scMainWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "MIS Documents Management System";
            this.scMainWin.Panel1.ResumeLayout(false);
            this.scMainWin.Panel2.ResumeLayout(false);
            this.scMainWin.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainWin)).EndInit();
            this.scMainWin.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.conPropPanel.ResumeLayout(false);
            this.conPropPanel.PerformLayout();
            this.docPropPanel.ResumeLayout(false);
            this.docPropPanel.PerformLayout();
            this.addDocPanel.ResumeLayout(false);
            this.addDocPanel.PerformLayout();
            this.manDocPanel.ResumeLayout(false);
            this.manDocPanel.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsTypeList.ResumeLayout(false);
            this.gbCat.ResumeLayout(false);
            this.gbCat.PerformLayout();
            this.cmsCatList.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbDatabase.ResumeLayout(false);
            this.gbDatabase.PerformLayout();
            this.gbServCred.ResumeLayout(false);
            this.gbServCred.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMainWin;
        private System.Windows.Forms.TreeView tvMainNav;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel conPropPanel;
        private System.Windows.Forms.Label conPropLabel1;
        private System.Windows.Forms.Label conPropLabel2;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnCheckCon;
        private System.Windows.Forms.GroupBox gbDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbServCred;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbServ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDBList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.ComboBox cbCats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripLabel tslDate;
        private System.Windows.Forms.Timer timrClockStats;
        private System.Windows.Forms.Panel docPropPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox tbAddType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lstType;
        private System.Windows.Forms.GroupBox gbCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.TextBox tbAddCat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstCat;
        private System.Windows.Forms.ContextMenuStrip cmsCatList;
        private System.Windows.Forms.ToolStripMenuItem tsmCatDelete;
        private System.Windows.Forms.ContextMenuStrip cmsTypeList;
        private System.Windows.Forms.ToolStripMenuItem tsmTypeDelete;
        private System.Windows.Forms.Panel addDocPanel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbDateCustom;
        private System.Windows.Forms.RadioButton rbDateCustom;
        private System.Windows.Forms.RadioButton rbDateToday;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbDocName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbAddType;
        private System.Windows.Forms.ComboBox cbAddCat;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbAddSem;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel manDocPanel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchTerm;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbDIName;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnDIEdit;
        private System.Windows.Forms.Button btnDIDel;
        private System.Windows.Forms.Button btnDIPrint;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cbDIType;
        private System.Windows.Forms.ComboBox cbDICat;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cbDISem;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbDIDate;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnDIBrowse;
        private System.Windows.Forms.TextBox tbDIPath;
        private System.Windows.Forms.CheckBox checkToday;
        private System.Windows.Forms.Label lblClearSearch;
        private System.Windows.Forms.Label lblNumOfRows;
        private System.Windows.Forms.Label lblDISafeFileName;
    }
}

