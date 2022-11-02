using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Event
{
    #region ICICBANK

    
    internal class ICICIBANK
    {
        private int accountNumber;
        private string customerName;
        private int balance;
        private int amount;




        public void deposit(int amount)
        {
            this.balance += amount;

        }

        public delegate void withdrawdelegate();
        public event withdrawdelegate Transactionfailedevent;
        public void withdraw(int amount)
        {
            if (amount > balance || amount == balance)
            {
                Console.WriteLine("Transaction failed !");
            }
            else if (amount < balance)
            {
                this.balance -= amount;
            }



        }
        public void raisemyevent()
        {
            Transactionfailedevent?.Invoke();
        }


        public void checkbalance()
        {
            Console.WriteLine($"your account balance is {this.balance}");
        }



        ICICIBANK(int accountno, string customername)
        {
            this.customerName = customername;
            this.accountNumber = accountno;
            balance = 5000;

        }

        void Main()
        {


        }




    }

    #endregion
}
