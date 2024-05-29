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
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ProgressBar progressBarFreeSpace;
        private System.Windows.Forms.Label lblFreeSpace;

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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.progressBarFreeSpace = new System.Windows.Forms.ProgressBar();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(13, 13);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(170, 13);
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
            this.lstFiles.Location = new System.Drawing.Point(16, 60);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(256, 95);
            this.lstFiles.TabIndex = 2;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(16, 213);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(120, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Hacer Respaldo";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(152, 213);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(120, 23);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restaurar Respaldo";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(16, 180);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(256, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(16, 160);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoría";
            // 
            // progressBarFreeSpace
            // 
            this.progressBarFreeSpace.Location = new System.Drawing.Point(16, 250);
            this.progressBarFreeSpace.Name = "progressBarFreeSpace";
            this.progressBarFreeSpace.Size = new System.Drawing.Size(256, 23);
            this.progressBarFreeSpace.TabIndex = 7;
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Location = new System.Drawing.Point(16, 280);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(73, 13);
            this.lblFreeSpace.TabIndex = 8;
            this.lblFreeSpace.Text = "Espacio libre: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lblFreeSpace);
            this.Controls.Add(this.progressBarFreeSpace);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
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

