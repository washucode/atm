using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class cashMachine : Form
    {
        String inputText;
        Boolean inputPermitted;
        

        public cashMachine()
        {
            InitializeComponent();
        }

        private void cashMachine_Load(object sender, EventArgs e)
        {
            inputText = "";
        }

        private void updateDisplay()
        {
            lblmainoutput.Text = inputText;
        }

        private void lblmainoutput_Click(object sender, EventArgs e)
        {

        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "7";
            updateDisplay();

        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "8";
            updateDisplay();

        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "8";
            updateDisplay();

        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "4";
            updateDisplay();

        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "5";
            updateDisplay();

        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "6";
            updateDisplay();

        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "1";
            updateDisplay();

        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "2";
            updateDisplay();

        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "3";
            updateDisplay();

        }

        private void cmdA_Click(object sender, EventArgs e)
        {

        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = inputText + "0";
            updateDisplay();

        }

        private void cmdC_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            inputText = "";
            updateDisplay();

        }



      
    }
}
