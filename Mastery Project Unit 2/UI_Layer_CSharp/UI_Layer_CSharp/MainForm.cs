using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layer_CSharp
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var newForm = new AboutBox();
            newForm.Show();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            var PlayerNameIsVaid = (txtPlayerName.Text.Length >= 3);

            // as the content changes, this event will trigger as each cahracter changes
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            // When Player clicks the button, game should start
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            // When Clicked, computer will have a chance to go in one of the 9 boxes
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // when clicked icon will change from "?" to an X or an O
        }
    }
}
