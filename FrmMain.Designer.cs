namespace DataMiner
{
    partial class FrmMain
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
        	this.ofdFilePicker = new System.Windows.Forms.OpenFileDialog();
        	this.msTop = new System.Windows.Forms.MenuStrip();
        	this.tmiFile = new System.Windows.Forms.ToolStripMenuItem();
        	this.tmiPickFile = new System.Windows.Forms.ToolStripMenuItem();
        	this.tssPickNew = new System.Windows.Forms.ToolStripSeparator();
        	this.tmiPrint = new System.Windows.Forms.ToolStripMenuItem();
        	this.tmiColours = new System.Windows.Forms.ToolStripMenuItem();
        	this.tmiAbout = new System.Windows.Forms.ToolStripMenuItem();
        	this.tssClose = new System.Windows.Forms.ToolStripSeparator();
        	this.tmiClose = new System.Windows.Forms.ToolStripMenuItem();
        	this.pnlButtons = new System.Windows.Forms.Panel();
        	this.gbxLookUps = new System.Windows.Forms.GroupBox();
        	this.tbxID = new System.Windows.Forms.TextBox();
        	this.btnFindInvoice = new System.Windows.Forms.Button();
        	this.btnFindCustomer = new System.Windows.Forms.Button();
        	this.gbxAveragesPerMonth = new System.Windows.Forms.GroupBox();
        	this.btnIntemsPerInvoice = new System.Windows.Forms.Button();
        	this.gbxValuesPerMonth = new System.Windows.Forms.GroupBox();
        	this.btnTotalInvoices = new System.Windows.Forms.Button();
        	this.btnTotalUniqueCustomers = new System.Windows.Forms.Button();
        	this.btnTotalValueSold = new System.Windows.Forms.Button();
        	this.btnTotalItemsSold = new System.Windows.Forms.Button();
        	this.lblFileName = new System.Windows.Forms.Label();
        	this.pbDataAnalysing = new System.Windows.Forms.ProgressBar();
        	this.pdPrintOptions = new System.Windows.Forms.PrintDialog();
        	this.pdtPrintArea = new System.Drawing.Printing.PrintDocument();
        	this.tlpDataSwitcher = new System.Windows.Forms.TableLayoutPanel();
        	this.pnlGraphHolder = new System.Windows.Forms.Panel();
        	this.tlpMonthHolder = new System.Windows.Forms.TableLayoutPanel();
        	this.lblDecValue = new System.Windows.Forms.Label();
        	this.lblNovValue = new System.Windows.Forms.Label();
        	this.lblOctValue = new System.Windows.Forms.Label();
        	this.lblSepValue = new System.Windows.Forms.Label();
        	this.lblAugValue = new System.Windows.Forms.Label();
        	this.lblJulValue = new System.Windows.Forms.Label();
        	this.lblJunValue = new System.Windows.Forms.Label();
        	this.lblMayValue = new System.Windows.Forms.Label();
        	this.lblAprValue = new System.Windows.Forms.Label();
        	this.lblMarValue = new System.Windows.Forms.Label();
        	this.lblFebValue = new System.Windows.Forms.Label();
        	this.lblDec = new System.Windows.Forms.Label();
        	this.lblJan = new System.Windows.Forms.Label();
        	this.lblNov = new System.Windows.Forms.Label();
        	this.lblFeb = new System.Windows.Forms.Label();
        	this.lblOct = new System.Windows.Forms.Label();
        	this.lblMar = new System.Windows.Forms.Label();
        	this.lblSep = new System.Windows.Forms.Label();
        	this.lblApr = new System.Windows.Forms.Label();
        	this.lblAug = new System.Windows.Forms.Label();
        	this.lblMay = new System.Windows.Forms.Label();
        	this.lblJul = new System.Windows.Forms.Label();
        	this.lblJun = new System.Windows.Forms.Label();
        	this.lblJanValue = new System.Windows.Forms.Label();
        	this.pnlGraphValueHolder = new System.Windows.Forms.Panel();
        	this.tlpGraph = new System.Windows.Forms.TableLayoutPanel();
        	this.pnlDec = new System.Windows.Forms.Panel();
        	this.pnlNov = new System.Windows.Forms.Panel();
        	this.pnlOct = new System.Windows.Forms.Panel();
        	this.pnlSep = new System.Windows.Forms.Panel();
        	this.pnlAug = new System.Windows.Forms.Panel();
        	this.pnlJul = new System.Windows.Forms.Panel();
        	this.pnlJun = new System.Windows.Forms.Panel();
        	this.pnlMay = new System.Windows.Forms.Panel();
        	this.pnlApr = new System.Windows.Forms.Panel();
        	this.pnlMar = new System.Windows.Forms.Panel();
        	this.pnlFeb = new System.Windows.Forms.Panel();
        	this.pnlJan = new System.Windows.Forms.Panel();
        	this.lblMinValue = new System.Windows.Forms.Label();
        	this.lblMaxValue = new System.Windows.Forms.Label();
        	this.lblMidValue = new System.Windows.Forms.Label();
        	this.pnlSearchResults = new System.Windows.Forms.Panel();
        	this.lblGraphTitle = new System.Windows.Forms.Label();
        	this.msTop.SuspendLayout();
        	this.pnlButtons.SuspendLayout();
        	this.gbxLookUps.SuspendLayout();
        	this.gbxAveragesPerMonth.SuspendLayout();
        	this.gbxValuesPerMonth.SuspendLayout();
        	this.tlpDataSwitcher.SuspendLayout();
        	this.pnlGraphHolder.SuspendLayout();
        	this.tlpMonthHolder.SuspendLayout();
        	this.pnlGraphValueHolder.SuspendLayout();
        	this.tlpGraph.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// ofdFilePicker
        	// 
        	this.ofdFilePicker.FileName = "openFileDialog1";
        	this.ofdFilePicker.Filter = "CSV Files| *.csv|Text files|*.txt";
        	this.ofdFilePicker.Title = "Select a file to open";
        	// 
        	// msTop
        	// 
        	this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.tmiFile});
        	this.msTop.Location = new System.Drawing.Point(0, 0);
        	this.msTop.Name = "msTop";
        	this.msTop.Size = new System.Drawing.Size(884, 24);
        	this.msTop.TabIndex = 3;
        	this.msTop.Text = "menuStrip1";
        	// 
        	// tmiFile
        	// 
        	this.tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.tmiPickFile,
        	        	        	this.tssPickNew,
        	        	        	this.tmiPrint,
        	        	        	this.tmiColours,
        	        	        	this.tmiAbout,
        	        	        	this.tssClose,
        	        	        	this.tmiClose});
        	this.tmiFile.Name = "tmiFile";
        	this.tmiFile.Size = new System.Drawing.Size(50, 20);
        	this.tmiFile.Text = "Menu";
        	// 
        	// tmiPickFile
        	// 
        	this.tmiPickFile.Image = global::DataMiner.Properties.Resources.Add_File_96;
        	this.tmiPickFile.Name = "tmiPickFile";
        	this.tmiPickFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.tmiPickFile.Size = new System.Drawing.Size(187, 22);
        	this.tmiPickFile.Text = "Pick &New File";
        	this.tmiPickFile.Click += new System.EventHandler(this.tmiPickFile_Click);
        	// 
        	// tssPickNew
        	// 
        	this.tssPickNew.Name = "tssPickNew";
        	this.tssPickNew.Size = new System.Drawing.Size(184, 6);
        	// 
        	// tmiPrint
        	// 
        	this.tmiPrint.Image = global::DataMiner.Properties.Resources.Print_96;
        	this.tmiPrint.Name = "tmiPrint";
        	this.tmiPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
        	this.tmiPrint.Size = new System.Drawing.Size(187, 22);
        	this.tmiPrint.Text = "&Print";
        	this.tmiPrint.Click += new System.EventHandler(this.tmiPrint_Click);
        	// 
        	// tmiColours
        	// 
        	this.tmiColours.Image = global::DataMiner.Properties.Resources.Paint_Palette_96;
        	this.tmiColours.Name = "tmiColours";
        	this.tmiColours.Size = new System.Drawing.Size(187, 22);
        	this.tmiColours.Text = "&Colours";
        	this.tmiColours.Click += new System.EventHandler(this.tmiColours_Click);
        	// 
        	// tmiAbout
        	// 
        	this.tmiAbout.Image = global::DataMiner.Properties.Resources.About_96;
        	this.tmiAbout.Name = "tmiAbout";
        	this.tmiAbout.Size = new System.Drawing.Size(187, 22);
        	this.tmiAbout.Text = "&About";
        	this.tmiAbout.Click += new System.EventHandler(this.tmiAbout_Click);
        	// 
        	// tssClose
        	// 
        	this.tssClose.Name = "tssClose";
        	this.tssClose.Size = new System.Drawing.Size(184, 6);
        	// 
        	// tmiClose
        	// 
        	this.tmiClose.Image = global::DataMiner.Properties.Resources.Close_Window_96;
        	this.tmiClose.Name = "tmiClose";
        	this.tmiClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
        	this.tmiClose.Size = new System.Drawing.Size(187, 22);
        	this.tmiClose.Text = "&Close";
        	this.tmiClose.Click += new System.EventHandler(this.tmiClose_Click);
        	// 
        	// pnlButtons
        	// 
        	this.pnlButtons.Controls.Add(this.gbxLookUps);
        	this.pnlButtons.Controls.Add(this.gbxAveragesPerMonth);
        	this.pnlButtons.Controls.Add(this.gbxValuesPerMonth);
        	this.pnlButtons.Controls.Add(this.lblFileName);
        	this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
        	this.pnlButtons.Location = new System.Drawing.Point(0, 24);
        	this.pnlButtons.Name = "pnlButtons";
        	this.pnlButtons.Size = new System.Drawing.Size(184, 624);
        	this.pnlButtons.TabIndex = 4;
        	// 
        	// gbxLookUps
        	// 
        	this.gbxLookUps.Controls.Add(this.tbxID);
        	this.gbxLookUps.Controls.Add(this.btnFindInvoice);
        	this.gbxLookUps.Controls.Add(this.btnFindCustomer);
        	this.gbxLookUps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gbxLookUps.Location = new System.Drawing.Point(12, 363);
        	this.gbxLookUps.Name = "gbxLookUps";
        	this.gbxLookUps.Size = new System.Drawing.Size(166, 157);
        	this.gbxLookUps.TabIndex = 6;
        	this.gbxLookUps.TabStop = false;
        	this.gbxLookUps.Text = "Search data";
        	// 
        	// tbxID
        	// 
        	this.tbxID.Enabled = false;
        	this.tbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tbxID.ForeColor = System.Drawing.Color.DarkGray;
        	this.tbxID.Location = new System.Drawing.Point(6, 23);
        	this.tbxID.Name = "tbxID";
        	this.tbxID.Size = new System.Drawing.Size(146, 24);
        	this.tbxID.TabIndex = 3;
        	this.tbxID.Text = "ID";
        	this.tbxID.Click += new System.EventHandler(this.TbxID_click);
        	this.tbxID.TextChanged += new System.EventHandler(this.tbxID_textChanged);
        	// 
        	// btnFindInvoice
        	// 
        	this.btnFindInvoice.Enabled = false;
        	this.btnFindInvoice.Location = new System.Drawing.Point(6, 53);
        	this.btnFindInvoice.Name = "btnFindInvoice";
        	this.btnFindInvoice.Size = new System.Drawing.Size(146, 44);
        	this.btnFindInvoice.TabIndex = 2;
        	this.btnFindInvoice.Tag = "4";
        	this.btnFindInvoice.Text = "Find invoice";
        	this.btnFindInvoice.UseVisualStyleBackColor = true;
        	this.btnFindInvoice.Click += new System.EventHandler(this.SearchButton_click);
        	// 
        	// btnFindCustomer
        	// 
        	this.btnFindCustomer.Enabled = false;
        	this.btnFindCustomer.Location = new System.Drawing.Point(6, 103);
        	this.btnFindCustomer.Name = "btnFindCustomer";
        	this.btnFindCustomer.Size = new System.Drawing.Size(146, 44);
        	this.btnFindCustomer.TabIndex = 1;
        	this.btnFindCustomer.Tag = "4";
        	this.btnFindCustomer.Text = "Find customer";
        	this.btnFindCustomer.UseVisualStyleBackColor = true;
        	this.btnFindCustomer.Click += new System.EventHandler(this.SearchButton_click);
        	// 
        	// gbxAveragesPerMonth
        	// 
        	this.gbxAveragesPerMonth.Controls.Add(this.btnIntemsPerInvoice);
        	this.gbxAveragesPerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gbxAveragesPerMonth.Location = new System.Drawing.Point(12, 280);
        	this.gbxAveragesPerMonth.Name = "gbxAveragesPerMonth";
        	this.gbxAveragesPerMonth.Size = new System.Drawing.Size(166, 77);
        	this.gbxAveragesPerMonth.TabIndex = 5;
        	this.gbxAveragesPerMonth.TabStop = false;
        	this.gbxAveragesPerMonth.Text = "Averages per Month";
        	// 
        	// btnIntemsPerInvoice
        	// 
        	this.btnIntemsPerInvoice.Enabled = false;
        	this.btnIntemsPerInvoice.Location = new System.Drawing.Point(6, 25);
        	this.btnIntemsPerInvoice.Name = "btnIntemsPerInvoice";
        	this.btnIntemsPerInvoice.Size = new System.Drawing.Size(146, 44);
        	this.btnIntemsPerInvoice.TabIndex = 1;
        	this.btnIntemsPerInvoice.Tag = "4";
        	this.btnIntemsPerInvoice.Text = "Items per invoice";
        	this.btnIntemsPerInvoice.UseVisualStyleBackColor = true;
        	this.btnIntemsPerInvoice.Click += new System.EventHandler(this.GraphButton_click);
        	// 
        	// gbxValuesPerMonth
        	// 
        	this.gbxValuesPerMonth.Controls.Add(this.btnTotalInvoices);
        	this.gbxValuesPerMonth.Controls.Add(this.btnTotalUniqueCustomers);
        	this.gbxValuesPerMonth.Controls.Add(this.btnTotalValueSold);
        	this.gbxValuesPerMonth.Controls.Add(this.btnTotalItemsSold);
        	this.gbxValuesPerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gbxValuesPerMonth.Location = new System.Drawing.Point(12, 47);
        	this.gbxValuesPerMonth.Name = "gbxValuesPerMonth";
        	this.gbxValuesPerMonth.Size = new System.Drawing.Size(166, 227);
        	this.gbxValuesPerMonth.TabIndex = 2;
        	this.gbxValuesPerMonth.TabStop = false;
        	this.gbxValuesPerMonth.Text = "Values per Month";
        	// 
        	// btnTotalInvoices
        	// 
        	this.btnTotalInvoices.Enabled = false;
        	this.btnTotalInvoices.Location = new System.Drawing.Point(6, 175);
        	this.btnTotalInvoices.Name = "btnTotalInvoices";
        	this.btnTotalInvoices.Size = new System.Drawing.Size(146, 44);
        	this.btnTotalInvoices.TabIndex = 4;
        	this.btnTotalInvoices.Tag = "3";
        	this.btnTotalInvoices.Text = "Total invoices";
        	this.btnTotalInvoices.UseVisualStyleBackColor = true;
        	this.btnTotalInvoices.Click += new System.EventHandler(this.GraphButton_click);
        	// 
        	// btnTotalUniqueCustomers
        	// 
        	this.btnTotalUniqueCustomers.Enabled = false;
        	this.btnTotalUniqueCustomers.Location = new System.Drawing.Point(6, 125);
        	this.btnTotalUniqueCustomers.Name = "btnTotalUniqueCustomers";
        	this.btnTotalUniqueCustomers.Size = new System.Drawing.Size(146, 44);
        	this.btnTotalUniqueCustomers.TabIndex = 3;
        	this.btnTotalUniqueCustomers.Tag = "2";
        	this.btnTotalUniqueCustomers.Text = "Total unique customers";
        	this.btnTotalUniqueCustomers.UseVisualStyleBackColor = true;
        	this.btnTotalUniqueCustomers.Click += new System.EventHandler(this.GraphButton_click);
        	// 
        	// btnTotalValueSold
        	// 
        	this.btnTotalValueSold.Enabled = false;
        	this.btnTotalValueSold.Location = new System.Drawing.Point(6, 75);
        	this.btnTotalValueSold.Name = "btnTotalValueSold";
        	this.btnTotalValueSold.Size = new System.Drawing.Size(146, 44);
        	this.btnTotalValueSold.TabIndex = 2;
        	this.btnTotalValueSold.Tag = "1";
        	this.btnTotalValueSold.Text = "Total value sold";
        	this.btnTotalValueSold.UseVisualStyleBackColor = true;
        	this.btnTotalValueSold.Click += new System.EventHandler(this.GraphButton_click);
        	// 
        	// btnTotalItemsSold
        	// 
        	this.btnTotalItemsSold.Enabled = false;
        	this.btnTotalItemsSold.Location = new System.Drawing.Point(6, 25);
        	this.btnTotalItemsSold.Name = "btnTotalItemsSold";
        	this.btnTotalItemsSold.Size = new System.Drawing.Size(146, 44);
        	this.btnTotalItemsSold.TabIndex = 1;
        	this.btnTotalItemsSold.Tag = "0";
        	this.btnTotalItemsSold.Text = "Total items sold";
        	this.btnTotalItemsSold.UseVisualStyleBackColor = true;
        	this.btnTotalItemsSold.Click += new System.EventHandler(this.GraphButton_click);
        	// 
        	// lblFileName
        	// 
        	this.lblFileName.AutoEllipsis = true;
        	this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblFileName.Location = new System.Drawing.Point(12, 17);
        	this.lblFileName.Name = "lblFileName";
        	this.lblFileName.Size = new System.Drawing.Size(166, 24);
        	this.lblFileName.TabIndex = 0;
        	this.lblFileName.Text = "This will be a file name";
        	// 
        	// pbDataAnalysing
        	// 
        	this.pbDataAnalysing.Location = new System.Drawing.Point(55, 0);
        	this.pbDataAnalysing.MarqueeAnimationSpeed = 25;
        	this.pbDataAnalysing.Name = "pbDataAnalysing";
        	this.pbDataAnalysing.Size = new System.Drawing.Size(829, 23);
        	this.pbDataAnalysing.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
        	this.pbDataAnalysing.TabIndex = 7;
        	this.pbDataAnalysing.Visible = false;
        	// 
        	// pdPrintOptions
        	// 
        	this.pdPrintOptions.Document = this.pdtPrintArea;
        	this.pdPrintOptions.UseEXDialog = true;
        	// 
        	// tlpDataSwitcher
        	// 
        	this.tlpDataSwitcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tlpDataSwitcher.ColumnCount = 1;
        	this.tlpDataSwitcher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tlpDataSwitcher.Controls.Add(this.pnlGraphHolder, 0, 0);
        	this.tlpDataSwitcher.Controls.Add(this.pnlSearchResults, 0, 1);
        	this.tlpDataSwitcher.Location = new System.Drawing.Point(190, 68);
        	this.tlpDataSwitcher.Name = "tlpDataSwitcher";
        	this.tlpDataSwitcher.RowCount = 2;
        	this.tlpDataSwitcher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tlpDataSwitcher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
        	this.tlpDataSwitcher.Size = new System.Drawing.Size(682, 580);
        	this.tlpDataSwitcher.TabIndex = 8;
        	// 
        	// pnlGraphHolder
        	// 
        	this.pnlGraphHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.pnlGraphHolder.BackColor = System.Drawing.Color.White;
        	this.pnlGraphHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.pnlGraphHolder.Controls.Add(this.tlpMonthHolder);
        	this.pnlGraphHolder.Controls.Add(this.pnlGraphValueHolder);
        	this.pnlGraphHolder.Location = new System.Drawing.Point(3, 3);
        	this.pnlGraphHolder.Name = "pnlGraphHolder";
        	this.pnlGraphHolder.Size = new System.Drawing.Size(676, 574);
        	this.pnlGraphHolder.TabIndex = 6;
        	// 
        	// tlpMonthHolder
        	// 
        	this.tlpMonthHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tlpMonthHolder.ColumnCount = 12;
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
        	this.tlpMonthHolder.Controls.Add(this.lblDecValue, 11, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblNovValue, 10, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblOctValue, 9, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblSepValue, 8, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblAugValue, 7, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblJulValue, 6, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblJunValue, 5, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblMayValue, 4, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblAprValue, 3, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblMarValue, 2, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblFebValue, 1, 0);
        	this.tlpMonthHolder.Controls.Add(this.lblDec, 11, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblJan, 0, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblNov, 10, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblFeb, 1, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblOct, 9, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblMar, 2, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblSep, 8, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblApr, 3, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblAug, 7, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblMay, 4, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblJul, 6, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblJun, 5, 1);
        	this.tlpMonthHolder.Controls.Add(this.lblJanValue, 0, 0);
        	this.tlpMonthHolder.Location = new System.Drawing.Point(66, 534);
        	this.tlpMonthHolder.Name = "tlpMonthHolder";
        	this.tlpMonthHolder.RowCount = 2;
        	this.tlpMonthHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tlpMonthHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tlpMonthHolder.Size = new System.Drawing.Size(602, 29);
        	this.tlpMonthHolder.TabIndex = 2;
        	this.tlpMonthHolder.Visible = false;
        	// 
        	// lblDecValue
        	// 
        	this.lblDecValue.AutoSize = true;
        	this.lblDecValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblDecValue.Location = new System.Drawing.Point(553, 0);
        	this.lblDecValue.Name = "lblDecValue";
        	this.lblDecValue.Size = new System.Drawing.Size(46, 14);
        	this.lblDecValue.TabIndex = 13;
        	this.lblDecValue.Text = "Value";
        	this.lblDecValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblNovValue
        	// 
        	this.lblNovValue.AutoSize = true;
        	this.lblNovValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblNovValue.Location = new System.Drawing.Point(503, 0);
        	this.lblNovValue.Name = "lblNovValue";
        	this.lblNovValue.Size = new System.Drawing.Size(44, 14);
        	this.lblNovValue.TabIndex = 12;
        	this.lblNovValue.Text = "Value";
        	this.lblNovValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblOctValue
        	// 
        	this.lblOctValue.AutoSize = true;
        	this.lblOctValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblOctValue.Location = new System.Drawing.Point(453, 0);
        	this.lblOctValue.Name = "lblOctValue";
        	this.lblOctValue.Size = new System.Drawing.Size(44, 14);
        	this.lblOctValue.TabIndex = 11;
        	this.lblOctValue.Text = "Value";
        	this.lblOctValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblSepValue
        	// 
        	this.lblSepValue.AutoSize = true;
        	this.lblSepValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblSepValue.Location = new System.Drawing.Point(403, 0);
        	this.lblSepValue.Name = "lblSepValue";
        	this.lblSepValue.Size = new System.Drawing.Size(44, 14);
        	this.lblSepValue.TabIndex = 10;
        	this.lblSepValue.Text = "Value";
        	this.lblSepValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblAugValue
        	// 
        	this.lblAugValue.AutoSize = true;
        	this.lblAugValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblAugValue.Location = new System.Drawing.Point(353, 0);
        	this.lblAugValue.Name = "lblAugValue";
        	this.lblAugValue.Size = new System.Drawing.Size(44, 14);
        	this.lblAugValue.TabIndex = 9;
        	this.lblAugValue.Text = "Value";
        	this.lblAugValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblJulValue
        	// 
        	this.lblJulValue.AutoSize = true;
        	this.lblJulValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblJulValue.Location = new System.Drawing.Point(303, 0);
        	this.lblJulValue.Name = "lblJulValue";
        	this.lblJulValue.Size = new System.Drawing.Size(44, 14);
        	this.lblJulValue.TabIndex = 8;
        	this.lblJulValue.Text = "Value";
        	this.lblJulValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblJunValue
        	// 
        	this.lblJunValue.AutoSize = true;
        	this.lblJunValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblJunValue.Location = new System.Drawing.Point(253, 0);
        	this.lblJunValue.Name = "lblJunValue";
        	this.lblJunValue.Size = new System.Drawing.Size(44, 14);
        	this.lblJunValue.TabIndex = 7;
        	this.lblJunValue.Text = "Value";
        	this.lblJunValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblMayValue
        	// 
        	this.lblMayValue.AutoSize = true;
        	this.lblMayValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblMayValue.Location = new System.Drawing.Point(203, 0);
        	this.lblMayValue.Name = "lblMayValue";
        	this.lblMayValue.Size = new System.Drawing.Size(44, 14);
        	this.lblMayValue.TabIndex = 6;
        	this.lblMayValue.Text = "Value";
        	this.lblMayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblAprValue
        	// 
        	this.lblAprValue.AutoSize = true;
        	this.lblAprValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblAprValue.Location = new System.Drawing.Point(153, 0);
        	this.lblAprValue.Name = "lblAprValue";
        	this.lblAprValue.Size = new System.Drawing.Size(44, 14);
        	this.lblAprValue.TabIndex = 5;
        	this.lblAprValue.Text = "Value";
        	this.lblAprValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblMarValue
        	// 
        	this.lblMarValue.AutoSize = true;
        	this.lblMarValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblMarValue.Location = new System.Drawing.Point(103, 0);
        	this.lblMarValue.Name = "lblMarValue";
        	this.lblMarValue.Size = new System.Drawing.Size(44, 14);
        	this.lblMarValue.TabIndex = 4;
        	this.lblMarValue.Text = "Value";
        	this.lblMarValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblFebValue
        	// 
        	this.lblFebValue.AutoSize = true;
        	this.lblFebValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblFebValue.Location = new System.Drawing.Point(53, 0);
        	this.lblFebValue.Name = "lblFebValue";
        	this.lblFebValue.Size = new System.Drawing.Size(44, 14);
        	this.lblFebValue.TabIndex = 3;
        	this.lblFebValue.Text = "Value";
        	this.lblFebValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblDec
        	// 
        	this.lblDec.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblDec.Location = new System.Drawing.Point(550, 14);
        	this.lblDec.Margin = new System.Windows.Forms.Padding(0);
        	this.lblDec.Name = "lblDec";
        	this.lblDec.Size = new System.Drawing.Size(52, 15);
        	this.lblDec.TabIndex = 1;
        	this.lblDec.Text = "Dec";
        	this.lblDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblJan
        	// 
        	this.lblJan.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblJan.Location = new System.Drawing.Point(0, 14);
        	this.lblJan.Margin = new System.Windows.Forms.Padding(0);
        	this.lblJan.Name = "lblJan";
        	this.lblJan.Size = new System.Drawing.Size(50, 15);
        	this.lblJan.TabIndex = 0;
        	this.lblJan.Text = "Jan";
        	this.lblJan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblNov
        	// 
        	this.lblNov.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblNov.Location = new System.Drawing.Point(500, 14);
        	this.lblNov.Margin = new System.Windows.Forms.Padding(0);
        	this.lblNov.Name = "lblNov";
        	this.lblNov.Size = new System.Drawing.Size(50, 15);
        	this.lblNov.TabIndex = 1;
        	this.lblNov.Text = "Nov";
        	this.lblNov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblFeb
        	// 
        	this.lblFeb.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblFeb.Location = new System.Drawing.Point(50, 14);
        	this.lblFeb.Margin = new System.Windows.Forms.Padding(0);
        	this.lblFeb.Name = "lblFeb";
        	this.lblFeb.Size = new System.Drawing.Size(50, 15);
        	this.lblFeb.TabIndex = 1;
        	this.lblFeb.Text = "Feb";
        	this.lblFeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblOct
        	// 
        	this.lblOct.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblOct.Location = new System.Drawing.Point(450, 14);
        	this.lblOct.Margin = new System.Windows.Forms.Padding(0);
        	this.lblOct.Name = "lblOct";
        	this.lblOct.Size = new System.Drawing.Size(50, 15);
        	this.lblOct.TabIndex = 1;
        	this.lblOct.Text = "Oct";
        	this.lblOct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblMar
        	// 
        	this.lblMar.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblMar.Location = new System.Drawing.Point(100, 14);
        	this.lblMar.Margin = new System.Windows.Forms.Padding(0);
        	this.lblMar.Name = "lblMar";
        	this.lblMar.Size = new System.Drawing.Size(50, 15);
        	this.lblMar.TabIndex = 1;
        	this.lblMar.Text = "Mar";
        	this.lblMar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblSep
        	// 
        	this.lblSep.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblSep.Location = new System.Drawing.Point(400, 14);
        	this.lblSep.Margin = new System.Windows.Forms.Padding(0);
        	this.lblSep.Name = "lblSep";
        	this.lblSep.Size = new System.Drawing.Size(50, 15);
        	this.lblSep.TabIndex = 1;
        	this.lblSep.Text = "Sep";
        	this.lblSep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblApr
        	// 
        	this.lblApr.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblApr.Location = new System.Drawing.Point(150, 14);
        	this.lblApr.Margin = new System.Windows.Forms.Padding(0);
        	this.lblApr.Name = "lblApr";
        	this.lblApr.Size = new System.Drawing.Size(50, 15);
        	this.lblApr.TabIndex = 1;
        	this.lblApr.Text = "Apr";
        	this.lblApr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblAug
        	// 
        	this.lblAug.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblAug.Location = new System.Drawing.Point(350, 14);
        	this.lblAug.Margin = new System.Windows.Forms.Padding(0);
        	this.lblAug.Name = "lblAug";
        	this.lblAug.Size = new System.Drawing.Size(50, 15);
        	this.lblAug.TabIndex = 1;
        	this.lblAug.Text = "Aug";
        	this.lblAug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblMay
        	// 
        	this.lblMay.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblMay.Location = new System.Drawing.Point(200, 14);
        	this.lblMay.Margin = new System.Windows.Forms.Padding(0);
        	this.lblMay.Name = "lblMay";
        	this.lblMay.Size = new System.Drawing.Size(50, 15);
        	this.lblMay.TabIndex = 1;
        	this.lblMay.Text = "May";
        	this.lblMay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblJul
        	// 
        	this.lblJul.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblJul.Location = new System.Drawing.Point(300, 14);
        	this.lblJul.Margin = new System.Windows.Forms.Padding(0);
        	this.lblJul.Name = "lblJul";
        	this.lblJul.Size = new System.Drawing.Size(50, 15);
        	this.lblJul.TabIndex = 1;
        	this.lblJul.Text = "Jul";
        	this.lblJul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblJun
        	// 
        	this.lblJun.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblJun.Location = new System.Drawing.Point(250, 14);
        	this.lblJun.Margin = new System.Windows.Forms.Padding(0);
        	this.lblJun.Name = "lblJun";
        	this.lblJun.Size = new System.Drawing.Size(50, 15);
        	this.lblJun.TabIndex = 1;
        	this.lblJun.Text = "Jun";
        	this.lblJun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblJanValue
        	// 
        	this.lblJanValue.AutoSize = true;
        	this.lblJanValue.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblJanValue.Location = new System.Drawing.Point(3, 0);
        	this.lblJanValue.Name = "lblJanValue";
        	this.lblJanValue.Size = new System.Drawing.Size(44, 14);
        	this.lblJanValue.TabIndex = 2;
        	this.lblJanValue.Text = "Value";
        	this.lblJanValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// pnlGraphValueHolder
        	// 
        	this.pnlGraphValueHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.pnlGraphValueHolder.Controls.Add(this.tlpGraph);
        	this.pnlGraphValueHolder.Controls.Add(this.lblMinValue);
        	this.pnlGraphValueHolder.Controls.Add(this.lblMaxValue);
        	this.pnlGraphValueHolder.Controls.Add(this.lblMidValue);
        	this.pnlGraphValueHolder.Location = new System.Drawing.Point(3, 22);
        	this.pnlGraphValueHolder.Name = "pnlGraphValueHolder";
        	this.pnlGraphValueHolder.Size = new System.Drawing.Size(668, 589);
        	this.pnlGraphValueHolder.TabIndex = 5;
        	// 
        	// tlpGraph
        	// 
        	this.tlpGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tlpGraph.ColumnCount = 12;
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
        	this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.332567F));
        	this.tlpGraph.Controls.Add(this.pnlDec, 11, 0);
        	this.tlpGraph.Controls.Add(this.pnlNov, 10, 0);
        	this.tlpGraph.Controls.Add(this.pnlOct, 9, 0);
        	this.tlpGraph.Controls.Add(this.pnlSep, 8, 0);
        	this.tlpGraph.Controls.Add(this.pnlAug, 7, 0);
        	this.tlpGraph.Controls.Add(this.pnlJul, 6, 0);
        	this.tlpGraph.Controls.Add(this.pnlJun, 5, 0);
        	this.tlpGraph.Controls.Add(this.pnlMay, 4, 0);
        	this.tlpGraph.Controls.Add(this.pnlApr, 3, 0);
        	this.tlpGraph.Controls.Add(this.pnlMar, 2, 0);
        	this.tlpGraph.Controls.Add(this.pnlFeb, 1, 0);
        	this.tlpGraph.Controls.Add(this.pnlJan, 0, 0);
        	this.tlpGraph.Location = new System.Drawing.Point(63, 0);
        	this.tlpGraph.Name = "tlpGraph";
        	this.tlpGraph.RowCount = 1;
        	this.tlpGraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tlpGraph.Size = new System.Drawing.Size(605, 509);
        	this.tlpGraph.TabIndex = 5;
        	// 
        	// pnlDec
        	// 
        	this.pnlDec.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlDec.Location = new System.Drawing.Point(553, 505);
        	this.pnlDec.Name = "pnlDec";
        	this.pnlDec.Size = new System.Drawing.Size(49, 1);
        	this.pnlDec.TabIndex = 11;
        	// 
        	// pnlNov
        	// 
        	this.pnlNov.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlNov.Location = new System.Drawing.Point(503, 505);
        	this.pnlNov.Name = "pnlNov";
        	this.pnlNov.Size = new System.Drawing.Size(44, 1);
        	this.pnlNov.TabIndex = 10;
        	// 
        	// pnlOct
        	// 
        	this.pnlOct.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlOct.Location = new System.Drawing.Point(453, 505);
        	this.pnlOct.Name = "pnlOct";
        	this.pnlOct.Size = new System.Drawing.Size(44, 1);
        	this.pnlOct.TabIndex = 9;
        	// 
        	// pnlSep
        	// 
        	this.pnlSep.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlSep.Location = new System.Drawing.Point(403, 505);
        	this.pnlSep.Name = "pnlSep";
        	this.pnlSep.Size = new System.Drawing.Size(44, 1);
        	this.pnlSep.TabIndex = 8;
        	// 
        	// pnlAug
        	// 
        	this.pnlAug.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlAug.Location = new System.Drawing.Point(353, 505);
        	this.pnlAug.Name = "pnlAug";
        	this.pnlAug.Size = new System.Drawing.Size(44, 1);
        	this.pnlAug.TabIndex = 7;
        	// 
        	// pnlJul
        	// 
        	this.pnlJul.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlJul.Location = new System.Drawing.Point(303, 505);
        	this.pnlJul.Name = "pnlJul";
        	this.pnlJul.Size = new System.Drawing.Size(44, 1);
        	this.pnlJul.TabIndex = 6;
        	// 
        	// pnlJun
        	// 
        	this.pnlJun.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlJun.Location = new System.Drawing.Point(253, 505);
        	this.pnlJun.Name = "pnlJun";
        	this.pnlJun.Size = new System.Drawing.Size(44, 1);
        	this.pnlJun.TabIndex = 5;
        	// 
        	// pnlMay
        	// 
        	this.pnlMay.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlMay.Location = new System.Drawing.Point(203, 505);
        	this.pnlMay.Name = "pnlMay";
        	this.pnlMay.Size = new System.Drawing.Size(44, 1);
        	this.pnlMay.TabIndex = 4;
        	// 
        	// pnlApr
        	// 
        	this.pnlApr.BackColor = System.Drawing.Color.White;
        	this.pnlApr.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlApr.Location = new System.Drawing.Point(153, 505);
        	this.pnlApr.Name = "pnlApr";
        	this.pnlApr.Size = new System.Drawing.Size(44, 1);
        	this.pnlApr.TabIndex = 3;
        	// 
        	// pnlMar
        	// 
        	this.pnlMar.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlMar.Location = new System.Drawing.Point(103, 505);
        	this.pnlMar.Name = "pnlMar";
        	this.pnlMar.Size = new System.Drawing.Size(44, 1);
        	this.pnlMar.TabIndex = 2;
        	// 
        	// pnlFeb
        	// 
        	this.pnlFeb.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlFeb.Location = new System.Drawing.Point(53, 505);
        	this.pnlFeb.Name = "pnlFeb";
        	this.pnlFeb.Size = new System.Drawing.Size(44, 1);
        	this.pnlFeb.TabIndex = 1;
        	// 
        	// pnlJan
        	// 
        	this.pnlJan.BackColor = System.Drawing.Color.White;
        	this.pnlJan.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlJan.Location = new System.Drawing.Point(3, 505);
        	this.pnlJan.Name = "pnlJan";
        	this.pnlJan.Size = new System.Drawing.Size(44, 1);
        	this.pnlJan.TabIndex = 0;
        	// 
        	// lblMinValue
        	// 
        	this.lblMinValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.lblMinValue.AutoSize = true;
        	this.lblMinValue.Location = new System.Drawing.Point(54, 578);
        	this.lblMinValue.Name = "lblMinValue";
        	this.lblMinValue.Size = new System.Drawing.Size(13, 13);
        	this.lblMinValue.TabIndex = 1;
        	this.lblMinValue.Text = "0";
        	// 
        	// lblMaxValue
        	// 
        	this.lblMaxValue.Location = new System.Drawing.Point(8, 0);
        	this.lblMaxValue.Name = "lblMaxValue";
        	this.lblMaxValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.lblMaxValue.Size = new System.Drawing.Size(54, 13);
        	this.lblMaxValue.TabIndex = 0;
        	this.lblMaxValue.Text = "MaxValue";
        	// 
        	// lblMidValue
        	// 
        	this.lblMidValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
        	this.lblMidValue.Location = new System.Drawing.Point(11, 289);
        	this.lblMidValue.Name = "lblMidValue";
        	this.lblMidValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.lblMidValue.Size = new System.Drawing.Size(51, 13);
        	this.lblMidValue.TabIndex = 4;
        	this.lblMidValue.Text = "MidValue";
        	// 
        	// pnlSearchResults
        	// 
        	this.pnlSearchResults.BackColor = System.Drawing.Color.White;
        	this.pnlSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pnlSearchResults.Location = new System.Drawing.Point(3, 583);
        	this.pnlSearchResults.Name = "pnlSearchResults";
        	this.pnlSearchResults.Size = new System.Drawing.Size(676, 1);
        	this.pnlSearchResults.TabIndex = 7;
        	// 
        	// lblGraphTitle
        	// 
        	this.lblGraphTitle.AutoSize = true;
        	this.lblGraphTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblGraphTitle.Location = new System.Drawing.Point(190, 41);
        	this.lblGraphTitle.Name = "lblGraphTitle";
        	this.lblGraphTitle.Size = new System.Drawing.Size(205, 24);
        	this.lblGraphTitle.TabIndex = 6;
        	this.lblGraphTitle.Text = "This will be a graph title";
        	// 
        	// FrmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(884, 648);
        	this.Controls.Add(this.tlpDataSwitcher);
        	this.Controls.Add(this.pbDataAnalysing);
        	this.Controls.Add(this.lblGraphTitle);
        	this.Controls.Add(this.pnlButtons);
        	this.Controls.Add(this.msTop);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MainMenuStrip = this.msTop;
        	this.MinimumSize = new System.Drawing.Size(700, 600);
        	this.Name = "FrmMain";
        	this.Text = "Data Miner";
        	this.Load += new System.EventHandler(this.FrmMain_Load);
        	this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
        	this.msTop.ResumeLayout(false);
        	this.msTop.PerformLayout();
        	this.pnlButtons.ResumeLayout(false);
        	this.gbxLookUps.ResumeLayout(false);
        	this.gbxLookUps.PerformLayout();
        	this.gbxAveragesPerMonth.ResumeLayout(false);
        	this.gbxValuesPerMonth.ResumeLayout(false);
        	this.tlpDataSwitcher.ResumeLayout(false);
        	this.pnlGraphHolder.ResumeLayout(false);
        	this.tlpMonthHolder.ResumeLayout(false);
        	this.tlpMonthHolder.PerformLayout();
        	this.pnlGraphValueHolder.ResumeLayout(false);
        	this.pnlGraphValueHolder.PerformLayout();
        	this.tlpGraph.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Panel pnlSearchResults;
        private System.Windows.Forms.TableLayoutPanel tlpDataSwitcher;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Button btnFindInvoice;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.GroupBox gbxLookUps;

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdFilePicker;
        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.ToolStripMenuItem tmiFile;
        private System.Windows.Forms.ToolStripMenuItem tmiPickFile;
        private System.Windows.Forms.ToolStripMenuItem tmiAbout;
        private System.Windows.Forms.ToolStripSeparator tssClose;
        private System.Windows.Forms.ToolStripMenuItem tmiClose;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnTotalItemsSold;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel pnlGraphHolder;
        private System.Windows.Forms.GroupBox gbxValuesPerMonth;
        private System.Windows.Forms.Button btnTotalValueSold;
        private System.Windows.Forms.Button btnTotalUniqueCustomers;
        private System.Windows.Forms.Button btnTotalInvoices;
        private System.Windows.Forms.GroupBox gbxAveragesPerMonth;
        private System.Windows.Forms.Button btnIntemsPerInvoice;
        private System.Windows.Forms.Label lblGraphTitle;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMidValue;
        private System.Windows.Forms.Panel pnlGraphValueHolder;
        private System.Windows.Forms.Label lblJun;
        private System.Windows.Forms.Label lblJul;
        private System.Windows.Forms.Label lblMay;
        private System.Windows.Forms.Label lblAug;
        private System.Windows.Forms.Label lblApr;
        private System.Windows.Forms.Label lblSep;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblFeb;
        private System.Windows.Forms.Label lblNov;
        private System.Windows.Forms.Label lblJan;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.TableLayoutPanel tlpMonthHolder;
        private System.Windows.Forms.Label lblDecValue;
        private System.Windows.Forms.Label lblNovValue;
        private System.Windows.Forms.Label lblOctValue;
        private System.Windows.Forms.Label lblSepValue;
        private System.Windows.Forms.Label lblAugValue;
        private System.Windows.Forms.Label lblJulValue;
        private System.Windows.Forms.Label lblJunValue;
        private System.Windows.Forms.Label lblMayValue;
        private System.Windows.Forms.Label lblAprValue;
        private System.Windows.Forms.Label lblMarValue;
        private System.Windows.Forms.Label lblFebValue;
        private System.Windows.Forms.Label lblJanValue;
        private System.Windows.Forms.ToolStripMenuItem tmiPrint;
        private System.Windows.Forms.TableLayoutPanel tlpGraph;
        private System.Windows.Forms.Panel pnlDec;
        private System.Windows.Forms.Panel pnlNov;
        private System.Windows.Forms.Panel pnlOct;
        private System.Windows.Forms.Panel pnlSep;
        private System.Windows.Forms.Panel pnlAug;
        private System.Windows.Forms.Panel pnlJul;
        private System.Windows.Forms.Panel pnlJun;
        private System.Windows.Forms.Panel pnlMay;
        private System.Windows.Forms.Panel pnlApr;
        private System.Windows.Forms.Panel pnlMar;
        private System.Windows.Forms.Panel pnlFeb;
        private System.Windows.Forms.Panel pnlJan;
        private System.Windows.Forms.ToolStripMenuItem tmiColours;
        private System.Windows.Forms.ToolStripSeparator tssPickNew;
        private System.Windows.Forms.ProgressBar pbDataAnalysing;
        private System.Windows.Forms.PrintDialog pdPrintOptions;
        private System.Drawing.Printing.PrintDocument pdtPrintArea;
    }
}

