using System.IO.Pipes;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;






namespace Banking_Event
{
    public delegate void TransactionHandler(object sender, TransactionEventArgs e);
    public class Account
    {

        #region VariableDeclaration

       
        private int accountNumber;
        private string customerName;
        private int balance;
        private int amount;

        #endregion


        #region methodDeclaration

      
        public void deposit(int amount)
        {
                this.balance += amount;
            
        }

        
        public event TransactionHandler TransactionMade;
        public void  withdraw(int amount)
        {
            if(amount>balance || amount == balance)
            {
                TransactionEventArgs e = new TransactionEventArgs();
                OnTransactionMade(e);
            }
            else if(amount < balance)
            {
                this.balance -= amount;
            }

            
            
        }

        protected virtual void OnTransactionMade(TransactionEventArgs e)
        {
            TransactionMade(this, e);
        }
        public class TransactionEventArgs : EventArgs
        {
            public TransactionEventArgs()
            {
                Console.WriteLine("transaction failed");
            }
        }


        public void checkbalance()
        {
            Console.WriteLine($"your account balance is {this.balance}");
        }

        

        Account(int accountno,string customername)
        {
            this.customerName = customername;
            this.accountNumber = accountno;
            balance =5000;

        }

        #endregion






        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Banking Application");
                Console.WriteLine("Enter your Account Number");
                int accountno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your name");
                string customername = Console.ReadLine();


                Account ac1 = new Account(accountno, customername);




                while (true)
                {
                    Console.WriteLine("select the operation you want to perform : 1.deposit 2.withdraw 3.chcek balance 4.exit ");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.WriteLine("Enter your amount to deposit");
                        int amount = int.Parse(Console.ReadLine());
                        ac1.deposit(amount);
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Enter your amount to withdraw");
                        int amount = int.Parse(Console.ReadLine());
                        ac1.withdraw(amount);


                    }
                    else if (option == 3)
                    {
                        ac1.checkbalance();

                    }
                    else if (option == 4)
                    {
                        break;
                    }

                }


            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message "+ e.Message);
            }
           
           





        }

        #region privateMethod

        
        private static void Ac1_Transactionfailedevent()
        {
            Console.WriteLine("transaction failed you cannot perform operation !");
        }
        #endregion

    }
}