namespace SerqAccess.EasyUI
{
    partial class ctrlConnectionString
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConnectionStrings = new System.Windows.Forms.Label();
            this.cbConnectionStrings = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cbProvider.Location = new System.Drawing.Point(349, 8);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(166, 21);
            this.cbProvider.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Provider:";
            // 
            // lblConnectionStrings
            // 
            this.lblConnectionStrings.AutoSize = true;
            this.lblConnectionStrings.Location = new System.Drawing.Point(12, 11);
            this.lblConnectionStrings.Name = "lblConnectionStrings";
            this.lblConnectionStrings.Size = new System.Drawing.Size(100, 13);
            this.lblConnectionStrings.TabIndex = 13;
            this.lblConnectionStrings.Text = "Connection strings :";
            // 
            // cbConnectionStrings
            // 
            this.cbConnectionStrings.FormattingEnabled = true;
            this.cbConnectionStrings.Location = new System.Drawing.Point(112, 8);
            this.cbConnectionStrings.Name = "cbConnectionStrings";
            this.cbConnectionStrings.Size = new System.Drawing.Size(166, 21);
            this.cbConnectionStrings.TabIndex = 12;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(539, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(132, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ctrlConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConnectionStrings);
            this.Controls.Add(this.cbConnectionStrings);
            this.Controls.Add(this.btnTest);
            this.Name = "ctrlConnectionString";
            this.Size = new System.Drawing.Size(680, 33);
            this.Load += new System.EventHandler(this.ctrlConnectionString_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConnectionStrings;
        private System.Windows.Forms.ComboBox cbConnectionStrings;
        private System.Windows.Forms.Button btnTest;
    }
}
