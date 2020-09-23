using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Kenneth Rodriguez
 */


namespace Project_1_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMessageBoxPopup(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This is a caption box",
                "This is the title bar",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }
    }
    }
