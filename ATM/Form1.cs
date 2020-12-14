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
        MyAccount account1;
        MyAccount account2;
        MyAccount account3;
        MyAccount account4;
        MyAccount current;
        Boolean withdrawing;
        Boolean receipt;

        public cashMachine()
        {
            InitializeComponent();
        }

        private void cashMachine_Load(object sender, EventArgs e)
        {
            inputText = "";
            inputPermitted = true;
            account1 = new MyAccount("0000", 20000);
            account2 = new MyAccount("1234", 30000);
            account3 = new MyAccount("5436", 40000);
            account4 = new MyAccount("6000", 100000);
            
        }


        private MyAccount findAccount(String pin){
           if(account1.verifyPin(pin)){
               return account1;
           }


           if(account2.verifyPin(pin)){
               return account2;
           }


          if(account3.verifyPin(pin)){
                return account3;
            }



            if(account4.verifyPin(pin)){
               return account4;
           }

            return null;
        }


        private void updateDisplay()
        {
            lblmainoutput.Text = inputText;
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

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            Boolean trans;

            if (current == null)
            {
                current = findAccount(inputText);
            }

            if (current != null)
            {
                if (withdrawing==true)
                {
                    trans = current.withdraw(Int32.Parse(inputText));

                    if (trans == true)
                    {
                        lblmainoutput.Text = "Transaction Successful";
                        if (receipt==true)
                        {
                            lblmainoutput.Text = current.getLastTransaction();
                        }
                    }



                    else
                    {
                        lblmainoutput.Text = "Insufficient funds";
                    }
                    inputText = "";
                    withdrawing = false;
                    inputPermitted = false;
                }
                else
                {
                    lblmainoutput.Text = "Choose transaction";
                    inputText = "";
                }
            }

            else
            {
                lblmainoutput.Text = "Invalid Pin";
                inputText = "";
                inputPermitted = true;
                updateDisplay();



            }


        }

        private void cmdReceipt_Click(object sender, EventArgs e)
        {
            withdrawing = true;
            receipt = true;
             
            
        }

        private void cmdWithdraw_Click(object sender, EventArgs e)
        {
            withdrawing = true;
            receipt = false;
        }
      
    }
}
