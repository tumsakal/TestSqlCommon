namespace TestSqlCommon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.rdoMsAccess = new System.Windows.Forms.RadioButton();
            this.rdoSqlServer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 78);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(185, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // rdoMsAccess
            // 
            this.rdoMsAccess.AutoSize = true;
            this.rdoMsAccess.Location = new System.Drawing.Point(12, 55);
            this.rdoMsAccess.Name = "rdoMsAccess";
            this.rdoMsAccess.Size = new System.Drawing.Size(77, 17);
            this.rdoMsAccess.TabIndex = 2;
            this.rdoMsAccess.TabStop = true;
            this.rdoMsAccess.Text = "Ms Access";
            this.rdoMsAccess.UseVisualStyleBackColor = true;
            this.rdoMsAccess.CheckedChanged += new System.EventHandler(this.RdoMsAccess_CheckedChanged);
            // 
            // rdoSqlServer
            // 
            this.rdoSqlServer.AutoSize = true;
            this.rdoSqlServer.Location = new System.Drawing.Point(123, 55);
            this.rdoSqlServer.Name = "rdoSqlServer";
            this.rdoSqlServer.Size = new System.Drawing.Size(74, 17);
            this.rdoSqlServer.TabIndex = 3;
            this.rdoSqlServer.TabStop = true;
            this.rdoSqlServer.Text = "Sql Server";
            this.rdoSqlServer.UseVisualStyleBackColor = true;
            this.rdoSqlServer.CheckedChanged += new System.EventHandler(this.RdoSqlServer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoSqlServer);
            this.Controls.Add(this.rdoMsAccess);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.RadioButton rdoMsAccess;
        private System.Windows.Forms.RadioButton rdoSqlServer;
    }
}

