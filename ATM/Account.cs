using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class MyAccount
    {
        String PIN;
        int balance;
        String lastTransaction;
        private char p1;
        private int p2;
        
        public MyAccount(string pin, int b)
        {
            PIN = pin;
            balance = b;
        }

       
       
        public Boolean verifyPin(String pin)
        {
            if (PIN.ToLower().Equals(pin.ToLower()))
            {
                return true;
            }

            return false;
        }

        public int checkBalance()
        {
            return balance;
        }
        public Boolean withdraw(int amount)
        {
            if (amount > balance)
            {
                return false;
            }

            lastTransaction = "Balance was " + balance + " Withdrew " + amount;

            
            balance -= amount;
           

            return true;
            
        }

        public String getLastTransaction()
        {
            if (lastTransaction != null)
            {
                return lastTransaction;
            }
            return "No transactions";
        }

    }
}
