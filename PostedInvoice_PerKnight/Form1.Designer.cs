namespace PostInvoice
{
    partial class BQPostInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_PostInvoice = new System.Windows.Forms.DataGridView();
            this.PostCheckBox1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_PostInv = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.blb_Find = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_CancelSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InvPnl = new System.Windows.Forms.Panel();
            this.cmbInv = new System.Windows.Forms.ComboBox();
            this.ClientPnl = new System.Windows.Forms.Panel();
            this.cmbclt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.ProjectPnl = new System.Windows.Forms.Panel();
            this.cmbproject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RdbtnPosted = new System.Windows.Forms.RadioButton();
            this.rbtnUnposted = new System.Windows.Forms.RadioButton();
            this.btnunposted = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ProjectGRPpnl = new System.Windows.Forms.Panel();
            this.pRjGRPCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrgMngPnl = new System.Windows.Forms.Panel();
            this.cmbPrgMng = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PostInvoice)).BeginInit();
            this.InvPnl.SuspendLayout();
            this.ClientPnl.SuspendLayout();
            this.DatePnl.SuspendLayout();
            this.ProjectPnl.SuspendLayout();
            this.ProjectGRPpnl.SuspendLayout();
            this.PrgMngPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_PostInvoice
            // 
            this.DGV_PostInvoice.AllowUserToAddRows = false;
            this.DGV_PostInvoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_PostInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PostInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_PostInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PostInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostCheckBox1});
            this.DGV_PostInvoice.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_PostInvoice.Location = new System.Drawing.Point(12, 91);
            this.DGV_PostInvoice.Name = "DGV_PostInvoice";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.DGV_PostInvoice.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_PostInvoice.Size = new System.Drawing.Size(1023, 503);
            this.DGV_PostInvoice.TabIndex = 0;
            // 
            // PostCheckBox1
            // 
            this.PostCheckBox1.FillWeight = 200F;
            this.PostCheckBox1.HeaderText = "";
            this.PostCheckBox1.MinimumWidth = 7;
            this.PostCheckBox1.Name = "PostCheckBox1";
            this.PostCheckBox1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PostCheckBox1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PostCheckBox1.Width = 25;
            // 
            // btn_PostInv
            // 
            this.btn_PostInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PostInv.Location = new System.Drawing.Point(903, 632);
            this.btn_PostInv.Name = "btn_PostInv";
            this.btn_PostInv.Size = new System.Drawing.Size(75, 23);
            this.btn_PostInv.TabIndex = 1;
            this.btn_PostInv.Text = "Post Invoice";
            this.btn_PostInv.UseVisualStyleBackColor = true;
            this.btn_PostInv.Click += new System.EventHandler(this.btn_PostInv_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(807, 632);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // blb_Find
            // 
            this.blb_Find.AutoSize = true;
            this.blb_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blb_Find.Location = new System.Drawing.Point(3, 21);
            this.blb_Find.Name = "blb_Find";
            this.blb_Find.Size = new System.Drawing.Size(96, 13);
            this.blb_Find.TabIndex = 3;
            this.blb_Find.Text = "Invoice Number";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(641, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(61, 25);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_CancelSearch
            // 
            this.btn_CancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelSearch.Location = new System.Drawing.Point(708, 30);
            this.btn_CancelSearch.Name = "btn_CancelSearch";
            this.btn_CancelSearch.Size = new System.Drawing.Size(61, 25);
            this.btn_CancelSearch.TabIndex = 6;
            this.btn_CancelSearch.Text = "Refresh:";
            this.btn_CancelSearch.UseVisualStyleBackColor = true;
            this.btn_CancelSearch.Click += new System.EventHandler(this.btn_CancelSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Project",
            "Client",
            "Invoice Number",
            "Date",
            "Project Group",
            "Project Manager"});
            this.comboBox1.Location = new System.Drawing.Point(113, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Criteria:";
            // 
            // InvPnl
            // 
            this.InvPnl.Controls.Add(this.cmbInv);
            this.InvPnl.Controls.Add(this.blb_Find);
            this.InvPnl.Location = new System.Drawing.Point(240, 12);
            this.InvPnl.Name = "InvPnl";
            this.InvPnl.Size = new System.Drawing.Size(234, 45);
            this.InvPnl.TabIndex = 9;
            // 
            // cmbInv
            // 
            this.cmbInv.AllowDrop = true;
            this.cmbInv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbInv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInv.FormattingEnabled = true;
            this.cmbInv.Location = new System.Drawing.Point(105, 18);
            this.cmbInv.Name = "cmbInv";
            this.cmbInv.Size = new System.Drawing.Size(117, 21);
            this.cmbInv.TabIndex = 16;
            // 
            // ClientPnl
            // 
            this.ClientPnl.Controls.Add(this.cmbclt);
            this.ClientPnl.Controls.Add(this.label3);
            this.ClientPnl.Location = new System.Drawing.Point(420, 205);
            this.ClientPnl.Name = "ClientPnl";
            this.ClientPnl.Size = new System.Drawing.Size(234, 67);
            this.ClientPnl.TabIndex = 10;
            // 
            // cmbclt
            // 
            this.cmbclt.AllowDrop = true;
            this.cmbclt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbclt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbclt.FormattingEnabled = true;
            this.cmbclt.Location = new System.Drawing.Point(87, 33);
            this.cmbclt.Name = "cmbclt";
            this.cmbclt.Size = new System.Drawing.Size(121, 21);
            this.cmbclt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Client";
            // 
            // DatePnl
            // 
            this.DatePnl.Controls.Add(this.label4);
            this.DatePnl.Controls.Add(this.From);
            this.DatePnl.Controls.Add(this.dateto);
            this.DatePnl.Controls.Add(this.datefrom);
            this.DatePnl.Location = new System.Drawing.Point(206, 109);
            this.DatePnl.Name = "DatePnl";
            this.DatePnl.Size = new System.Drawing.Size(402, 58);
            this.DatePnl.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "To";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(23, 36);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(34, 13);
            this.From.TabIndex = 8;
            this.From.Text = "From";
            // 
            // dateto
            // 
            this.dateto.CustomFormat = "mm-dd-yyyy";
            this.dateto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateto.Location = new System.Drawing.Point(254, 30);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(135, 20);
            this.dateto.TabIndex = 1;
            // 
            // datefrom
            // 
            this.datefrom.CustomFormat = "mm-dd-yyyy";
            this.datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefrom.Location = new System.Drawing.Point(68, 30);
            this.datefrom.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(128, 20);
            this.datefrom.TabIndex = 0;
            // 
            // ProjectPnl
            // 
            this.ProjectPnl.Controls.Add(this.cmbproject);
            this.ProjectPnl.Controls.Add(this.label2);
            this.ProjectPnl.Location = new System.Drawing.Point(138, 205);
            this.ProjectPnl.Name = "ProjectPnl";
            this.ProjectPnl.Size = new System.Drawing.Size(234, 67);
            this.ProjectPnl.TabIndex = 12;
            // 
            // cmbproject
            // 
            this.cmbproject.AllowDrop = true;
            this.cmbproject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbproject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbproject.FormattingEnabled = true;
            this.cmbproject.Location = new System.Drawing.Point(83, 37);
            this.cmbproject.Name = "cmbproject";
            this.cmbproject.Size = new System.Drawing.Size(121, 21);
            this.cmbproject.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Project";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RdbtnPosted
            // 
            this.RdbtnPosted.AutoSize = true;
            this.RdbtnPosted.Location = new System.Drawing.Point(927, 12);
            this.RdbtnPosted.Name = "RdbtnPosted";
            this.RdbtnPosted.Size = new System.Drawing.Size(101, 17);
            this.RdbtnPosted.TabIndex = 13;
            this.RdbtnPosted.TabStop = true;
            this.RdbtnPosted.Text = "Posted Invoices";
            this.RdbtnPosted.UseVisualStyleBackColor = true;
            this.RdbtnPosted.CheckedChanged += new System.EventHandler(this.RdbtnPosted_CheckedChanged);
            // 
            // rbtnUnposted
            // 
            this.rbtnUnposted.AutoSize = true;
            this.rbtnUnposted.Location = new System.Drawing.Point(807, 12);
            this.rbtnUnposted.Name = "rbtnUnposted";
            this.rbtnUnposted.Size = new System.Drawing.Size(114, 17);
            this.rbtnUnposted.TabIndex = 14;
            this.rbtnUnposted.TabStop = true;
            this.rbtnUnposted.Text = "Unposted Invoices";
            this.rbtnUnposted.UseVisualStyleBackColor = true;
            this.rbtnUnposted.CheckedChanged += new System.EventHandler(this.rbtnUnposted_CheckedChanged);
            // 
            // btnunposted
            // 
            this.btnunposted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunposted.Location = new System.Drawing.Point(903, 661);
            this.btnunposted.Name = "btnunposted";
            this.btnunposted.Size = new System.Drawing.Size(75, 23);
            this.btnunposted.TabIndex = 15;
            this.btnunposted.Text = "Unpost";
            this.btnunposted.UseVisualStyleBackColor = true;
            this.btnunposted.Click += new System.EventHandler(this.btnunposted_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(283, 614);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(59, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Select/Unselect All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ProjectGRPpnl
            // 
            this.ProjectGRPpnl.Controls.Add(this.pRjGRPCmb);
            this.ProjectGRPpnl.Controls.Add(this.label6);
            this.ProjectGRPpnl.Location = new System.Drawing.Point(687, 205);
            this.ProjectGRPpnl.Name = "ProjectGRPpnl";
            this.ProjectGRPpnl.Size = new System.Drawing.Size(246, 67);
            this.ProjectGRPpnl.TabIndex = 19;
            // 
            // pRjGRPCmb
            // 
            this.pRjGRPCmb.AllowDrop = true;
            this.pRjGRPCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pRjGRPCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pRjGRPCmb.FormattingEnabled = true;
            this.pRjGRPCmb.Location = new System.Drawing.Point(109, 37);
            this.pRjGRPCmb.Name = "pRjGRPCmb";
            this.pRjGRPCmb.Size = new System.Drawing.Size(121, 21);
            this.pRjGRPCmb.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Project Group";
            // 
            // PrgMngPnl
            // 
            this.PrgMngPnl.Controls.Add(this.cmbPrgMng);
            this.PrgMngPnl.Controls.Add(this.label7);
            this.PrgMngPnl.Location = new System.Drawing.Point(138, 298);
            this.PrgMngPnl.Name = "PrgMngPnl";
            this.PrgMngPnl.Size = new System.Drawing.Size(253, 67);
            this.PrgMngPnl.TabIndex = 20;
            // 
            // cmbPrgMng
            // 
            this.cmbPrgMng.AllowDrop = true;
            this.cmbPrgMng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPrgMng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrgMng.FormattingEnabled = true;
            this.cmbPrgMng.Location = new System.Drawing.Point(122, 37);
            this.cmbPrgMng.Name = "cmbPrgMng";
            this.cmbPrgMng.Size = new System.Drawing.Size(121, 21);
            this.cmbPrgMng.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Project Manager";
            // 
            // BQPostInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 687);
            this.ControlBox = false;
            this.Controls.Add(this.PrgMngPnl);
            this.Controls.Add(this.ProjectGRPpnl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnunposted);
            this.Controls.Add(this.rbtnUnposted);
            this.Controls.Add(this.RdbtnPosted);
            this.Controls.Add(this.ProjectPnl);
            this.Controls.Add(this.DatePnl);
            this.Controls.Add(this.InvPnl);
            this.Controls.Add(this.ClientPnl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_CancelSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_PostInv);
            this.Controls.Add(this.DGV_PostInvoice);
            this.Name = "BQPostInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BQPostInvoice";
            this.Load += new System.EventHandler(this.BQPostInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PostInvoice)).EndInit();
            this.InvPnl.ResumeLayout(false);
            this.InvPnl.PerformLayout();
            this.ClientPnl.ResumeLayout(false);
            this.ClientPnl.PerformLayout();
            this.DatePnl.ResumeLayout(false);
            this.DatePnl.PerformLayout();
            this.ProjectPnl.ResumeLayout(false);
            this.ProjectPnl.PerformLayout();
            this.ProjectGRPpnl.ResumeLayout(false);
            this.ProjectGRPpnl.PerformLayout();
            this.PrgMngPnl.ResumeLayout(false);
            this.PrgMngPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_PostInvoice;
        private System.Windows.Forms.Button btn_PostInv;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label blb_Find;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_CancelSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InvPnl;
        private System.Windows.Forms.Panel ClientPnl;
        private System.Windows.Forms.Panel DatePnl;
        private System.Windows.Forms.Panel ProjectPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.RadioButton RdbtnPosted;
        private System.Windows.Forms.RadioButton rbtnUnposted;
        private System.Windows.Forms.Button btnunposted;
        private System.Windows.Forms.ComboBox cmbInv;
        private System.Windows.Forms.ComboBox cmbclt;
        private System.Windows.Forms.ComboBox cmbproject;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PostCheckBox1;
        private System.Windows.Forms.Panel ProjectGRPpnl;
        private System.Windows.Forms.ComboBox pRjGRPCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PrgMngPnl;
        private System.Windows.Forms.ComboBox cmbPrgMng;
        private System.Windows.Forms.Label label7;
    }
}

