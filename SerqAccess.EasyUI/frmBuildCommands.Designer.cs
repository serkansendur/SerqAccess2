namespace SerqAccess.EasyUI
{
    partial class frmBuildCommands
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
            this.pnlConnectionString = new System.Windows.Forms.Panel();
            this.lblSelectStatement = new System.Windows.Forms.Label();
            this.txtSelectStatement = new System.Windows.Forms.TextBox();
            this.btnBuildCommands = new System.Windows.Forms.Button();
            this.txtCommandText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlConnectionString
            // 
            this.pnlConnectionString.Location = new System.Drawing.Point(9, 12);
            this.pnlConnectionString.Name = "pnlConnectionString";
            this.pnlConnectionString.Size = new System.Drawing.Size(794, 31);
            this.pnlConnectionString.TabIndex = 18;
            this.pnlConnectionString.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConnectionString_Paint);
            // 
            // lblSelectStatement
            // 
            this.lblSelectStatement.AutoSize = true;
            this.lblSelectStatement.Location = new System.Drawing.Point(12, 56);
            this.lblSelectStatement.Name = "lblSelectStatement";
            this.lblSelectStatement.Size = new System.Drawing.Size(91, 13);
            this.lblSelectStatement.TabIndex = 19;
            this.lblSelectStatement.Text = "Select Statement:";
            // 
            // txtSelectStatement
            // 
            this.txtSelectStatement.Location = new System.Drawing.Point(15, 72);
            this.txtSelectStatement.Multiline = true;
            this.txtSelectStatement.Name = "txtSelectStatement";
            this.txtSelectStatement.Size = new System.Drawing.Size(788, 110);
            this.txtSelectStatement.TabIndex = 20;
            // 
            // btnBuildCommands
            // 
            this.btnBuildCommands.Location = new System.Drawing.Point(15, 188);
            this.btnBuildCommands.Name = "btnBuildCommands";
            this.btnBuildCommands.Size = new System.Drawing.Size(180, 23);
            this.btnBuildCommands.TabIndex = 21;
            this.btnBuildCommands.Text = "Build Commands";
            this.btnBuildCommands.UseVisualStyleBackColor = true;
            this.btnBuildCommands.Click += new System.EventHandler(this.btnBuildCommands_Click);
            // 
            // txtCommandText
            // 
            this.txtCommandText.Location = new System.Drawing.Point(15, 217);
            this.txtCommandText.Multiline = true;
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.Size = new System.Drawing.Size(788, 110);
            this.txtCommandText.TabIndex = 22;
            // 
            // frmBuildCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 400);
            this.Controls.Add(this.txtCommandText);
            this.Controls.Add(this.btnBuildCommands);
            this.Controls.Add(this.txtSelectStatement);
            this.Controls.Add(this.lblSelectStatement);
            this.Controls.Add(this.pnlConnectionString);
            this.Name = "frmBuildCommands";
            this.Text = "frmBuildCommands";
            this.Load += new System.EventHandler(this.frmBuildCommands_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlConnectionString;
        private System.Windows.Forms.Label lblSelectStatement;
        private System.Windows.Forms.TextBox txtSelectStatement;
        private System.Windows.Forms.Button btnBuildCommands;
        private System.Windows.Forms.TextBox txtCommandText;
    }
}