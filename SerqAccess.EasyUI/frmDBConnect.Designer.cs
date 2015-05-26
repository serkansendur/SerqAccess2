namespace SerqAccess.EasyUI
{
    partial class frmDBConnect
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
            this.btnTest = new System.Windows.Forms.Button();
            this.cbConnectionStrings = new System.Windows.Forms.ComboBox();
            this.lblConnectionStrings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(616, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(132, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbConnectionStrings
            // 
            this.cbConnectionStrings.FormattingEnabled = true;
            this.cbConnectionStrings.Location = new System.Drawing.Point(189, 6);
            this.cbConnectionStrings.Name = "cbConnectionStrings";
            this.cbConnectionStrings.Size = new System.Drawing.Size(166, 21);
            this.cbConnectionStrings.TabIndex = 1;
            // 
            // lblConnectionStrings
            // 
            this.lblConnectionStrings.AutoSize = true;
            this.lblConnectionStrings.Location = new System.Drawing.Point(89, 9);
            this.lblConnectionStrings.Name = "lblConnectionStrings";
            this.lblConnectionStrings.Size = new System.Drawing.Size(100, 13);
            this.lblConnectionStrings.TabIndex = 2;
            this.lblConnectionStrings.Text = "Connection strings :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Provider:";
            // 
            // cbProvider
            // 
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Items.AddRange(new object[] {
            "ODP",
            "OLEDB",
            "ODBC",
            "ORACLECLIENT",
            "SQL SERVER"});
            this.cbProvider.Location = new System.Drawing.Point(426, 6);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(166, 21);
            this.cbProvider.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SQL:";
            // 
            // txtSQL
            // 
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQL.Location = new System.Drawing.Point(12, 33);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(1030, 200);
            this.txtSQL.TabIndex = 12;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(15, 240);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(188, 23);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgvSQL
            // 
            this.dgvSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(15, 268);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.Size = new System.Drawing.Size(1027, 194);
            this.dgvSQL.TabIndex = 14;
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(209, 240);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(188, 23);
            this.btnPut.TabIndex = 15;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(967, 239);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "Excel File|*.xlsx";
            // 
            // frmDBConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 485);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConnectionStrings);
            this.Controls.Add(this.cbConnectionStrings);
            this.Controls.Add(this.btnTest);
            this.Name = "frmDBConnect";
            this.Text = "ConnectionTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDBConnect_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cbConnectionStrings;
        private System.Windows.Forms.Label lblConnectionStrings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}