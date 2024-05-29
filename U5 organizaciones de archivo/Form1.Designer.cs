namespace U5_organizaciones_de_archivo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSource = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(13, 13);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(224, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Seleccione Archivos para Respaldo";
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(16, 30);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(120, 23);
            this.btnSelectFiles.TabIndex = 1;
            this.btnSelectFiles.Text = "Seleccionar Archivos";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 16;
            this.lstFiles.Location = new System.Drawing.Point(16, 60);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(256, 84);
            this.lstFiles.TabIndex = 2;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(16, 162);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(120, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Hacer Respaldo";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(152, 162);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(120, 23);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restaurar Respaldo";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(360, 258);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.lblSource);
            this.Name = "Form1";
            this.Text = "Backup and Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

