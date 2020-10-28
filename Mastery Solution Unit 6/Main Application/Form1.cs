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


namespace Master_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma seperated values |*.csv|Text File| *.txt",
                Title = @"Select the Hundred Names database"
            };

            // Shows Dialog
            // When user clicks ok, it opens

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)

            {
                MessageBox.Show(
                    openFileDialog.SafeFileName,
                    @"You Selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFileName.Text = openFileDialog.SafeFileName;

                toolStripStatusLabel1.Text = openFileDialog.FileName;

                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    var oneLineOfText = "";
                    while ((oneLineOfText = sr.ReadLine()) !=null)
                    {
                        IbFileOutput.Items.Add(oneLineOfText);
                    }
                }
            }
        }
    }
}
