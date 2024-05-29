using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace U5_organizaciones_de_archivo
{
    public partial class Form1 : Form
    {
        private List<string> filesToBackup = new List<string>();
        private string backupFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BackupFolder");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filesToBackup.AddRange(openFileDialog.FileNames);
                lstFiles.Items.AddRange(openFileDialog.FileNames);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            foreach (string file in filesToBackup)
            {
                string fileName = Path.GetFileName(file);
                string destPath = Path.Combine(backupFolder, fileName);
                File.Copy(file, destPath, true);
            }

            MessageBox.Show("Respaldo completado.");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string restoreFolder = folderBrowserDialog1.SelectedPath;

                foreach (string file in Directory.GetFiles(backupFolder))
                {
                    string fileName = Path.GetFileName(file);
                    string destPath = Path.Combine(restoreFolder, fileName);
                    File.Copy(file, destPath, true);
                }

                MessageBox.Show("Restauración completada.");
            }

        }

        private void UpdateFreeSpace()
        {
            var driveInfo = new DriveInfo(Path.GetPathRoot(backupFolder));
            long freeSpace = driveInfo.AvailableFreeSpace;
            long totalSpace = driveInfo.TotalSize;
            int freeSpacePercentage = (int)((freeSpace * 100) / totalSpace);

            progressBarFreeSpace.Value = freeSpacePercentage;
            lblFreeSpace.Text = $"Espacio libre: {freeSpace / (1024 * 1024)} MB de {totalSpace / (1024 * 1024)} MB ({freeSpacePercentage}%)";
        }
    }
}
