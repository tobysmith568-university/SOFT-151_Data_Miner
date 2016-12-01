namespace DataMiner
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.btnSave = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.cbUseOneColour = new System.Windows.Forms.CheckBox();
            this.pnlGraphBackground = new System.Windows.Forms.Panel();
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
            this.lblColourTitle = new System.Windows.Forms.Label();
            this.cdBarColourPicker = new System.Windows.Forms.ColorDialog();
            this.gbMain.SuspendLayout();
            this.pnlGraphBackground.SuspendLayout();
            this.tlpGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(421, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnsave);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.cbUseOneColour);
            this.gbMain.Controls.Add(this.pnlGraphBackground);
            this.gbMain.Controls.Add(this.lblColourTitle);
            this.gbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(511, 280);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Bar Colours";
            // 
            // cbUseOneColour
            // 
            this.cbUseOneColour.AutoSize = true;
            this.cbUseOneColour.Location = new System.Drawing.Point(9, 252);
            this.cbUseOneColour.Name = "cbUseOneColour";
            this.cbUseOneColour.Size = new System.Drawing.Size(129, 22);
            this.cbUseOneColour.TabIndex = 2;
            this.cbUseOneColour.Text = "Use one colour";
            this.cbUseOneColour.UseVisualStyleBackColor = true;
            this.cbUseOneColour.CheckedChanged += new System.EventHandler(this.cbUseOneColour_CheckedChanged);
            // 
            // pnlGraphBackground
            // 
            this.pnlGraphBackground.BackColor = System.Drawing.Color.White;
            this.pnlGraphBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphBackground.Controls.Add(this.tlpGraph);
            this.pnlGraphBackground.Location = new System.Drawing.Point(9, 41);
            this.pnlGraphBackground.Name = "pnlGraphBackground";
            this.pnlGraphBackground.Size = new System.Drawing.Size(496, 207);
            this.pnlGraphBackground.TabIndex = 0;
            // 
            // tlpGraph
            // 
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
            this.tlpGraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.332569F));
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
            this.tlpGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraph.Location = new System.Drawing.Point(0, 0);
            this.tlpGraph.Name = "tlpGraph";
            this.tlpGraph.RowCount = 1;
            this.tlpGraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGraph.Size = new System.Drawing.Size(492, 203);
            this.tlpGraph.TabIndex = 0;
            // 
            // pnlDec
            // 
            this.pnlDec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDec.Location = new System.Drawing.Point(454, 101);
            this.pnlDec.Name = "pnlDec";
            this.pnlDec.Size = new System.Drawing.Size(35, 99);
            this.pnlDec.TabIndex = 11;
            this.pnlDec.Tag = "11";
            this.pnlDec.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlNov
            // 
            this.pnlNov.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNov.Location = new System.Drawing.Point(413, 101);
            this.pnlNov.Name = "pnlNov";
            this.pnlNov.Size = new System.Drawing.Size(35, 99);
            this.pnlNov.TabIndex = 10;
            this.pnlNov.Tag = "10";
            this.pnlNov.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlOct
            // 
            this.pnlOct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOct.Location = new System.Drawing.Point(372, 101);
            this.pnlOct.Name = "pnlOct";
            this.pnlOct.Size = new System.Drawing.Size(35, 99);
            this.pnlOct.TabIndex = 9;
            this.pnlOct.Tag = "9";
            this.pnlOct.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlSep
            // 
            this.pnlSep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSep.Location = new System.Drawing.Point(331, 101);
            this.pnlSep.Name = "pnlSep";
            this.pnlSep.Size = new System.Drawing.Size(35, 99);
            this.pnlSep.TabIndex = 8;
            this.pnlSep.Tag = "8";
            this.pnlSep.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlAug
            // 
            this.pnlAug.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAug.Location = new System.Drawing.Point(290, 101);
            this.pnlAug.Name = "pnlAug";
            this.pnlAug.Size = new System.Drawing.Size(35, 99);
            this.pnlAug.TabIndex = 7;
            this.pnlAug.Tag = "7";
            this.pnlAug.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlJul
            // 
            this.pnlJul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJul.Location = new System.Drawing.Point(249, 101);
            this.pnlJul.Name = "pnlJul";
            this.pnlJul.Size = new System.Drawing.Size(35, 99);
            this.pnlJul.TabIndex = 6;
            this.pnlJul.Tag = "6";
            this.pnlJul.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlJun
            // 
            this.pnlJun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJun.Location = new System.Drawing.Point(208, 101);
            this.pnlJun.Name = "pnlJun";
            this.pnlJun.Size = new System.Drawing.Size(35, 99);
            this.pnlJun.TabIndex = 5;
            this.pnlJun.Tag = "5";
            this.pnlJun.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlMay
            // 
            this.pnlMay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMay.Location = new System.Drawing.Point(167, 101);
            this.pnlMay.Name = "pnlMay";
            this.pnlMay.Size = new System.Drawing.Size(35, 99);
            this.pnlMay.TabIndex = 4;
            this.pnlMay.Tag = "4";
            this.pnlMay.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlApr
            // 
            this.pnlApr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlApr.Location = new System.Drawing.Point(126, 101);
            this.pnlApr.Name = "pnlApr";
            this.pnlApr.Size = new System.Drawing.Size(35, 99);
            this.pnlApr.TabIndex = 3;
            this.pnlApr.Tag = "3";
            this.pnlApr.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlMar
            // 
            this.pnlMar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMar.Location = new System.Drawing.Point(85, 101);
            this.pnlMar.Name = "pnlMar";
            this.pnlMar.Size = new System.Drawing.Size(35, 99);
            this.pnlMar.TabIndex = 2;
            this.pnlMar.Tag = "2";
            this.pnlMar.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlFeb
            // 
            this.pnlFeb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFeb.Location = new System.Drawing.Point(44, 101);
            this.pnlFeb.Name = "pnlFeb";
            this.pnlFeb.Size = new System.Drawing.Size(35, 99);
            this.pnlFeb.TabIndex = 1;
            this.pnlFeb.Tag = "1";
            this.pnlFeb.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // pnlJan
            // 
            this.pnlJan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJan.Location = new System.Drawing.Point(3, 101);
            this.pnlJan.Name = "pnlJan";
            this.pnlJan.Size = new System.Drawing.Size(35, 99);
            this.pnlJan.TabIndex = 0;
            this.pnlJan.Tag = "0";
            this.pnlJan.Click += new System.EventHandler(this.pnlBar_Click);
            // 
            // lblColourTitle
            // 
            this.lblColourTitle.AutoSize = true;
            this.lblColourTitle.Location = new System.Drawing.Point(6, 20);
            this.lblColourTitle.Name = "lblColourTitle";
            this.lblColourTitle.Size = new System.Drawing.Size(216, 18);
            this.lblColourTitle.TabIndex = 1;
            this.lblColourTitle.Text = "Click a bar to change its colour:";
            // 
            // cdBarColourPicker
            // 
            this.cdBarColourPicker.Color = System.Drawing.Color.Red;
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 347);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Colour options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptions_FormClosing);
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.pnlGraphBackground.ResumeLayout(false);
            this.tlpGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel pnlGraphBackground;
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
        private System.Windows.Forms.Label lblColourTitle;
        private System.Windows.Forms.CheckBox cbUseOneColour;
        private System.Windows.Forms.ColorDialog cdBarColourPicker;
    }
}