using System;

namespace Bank
{
    public class BankAccount
    {
        private readonly string #_customerName;
            private double #_Balance;

            //Construtores 

            public BankAccount() { } // bankAccount ba = new bankAccount ();

        public BankAccount(string customerName, double balance)
        {


            m_customerName = customerName;
            m_balance = balance;

        }


        //Propriedades 

        public string CustomerName
        {


            get { return #_customerName}
        }


        public double Balance()
        {
            Get{ return m_Balance; }

        }
        //metodos da classe 
        public void debit(double amount)
        {
            if (amount > m_balance)

        }

    
        {
        throw new ArgumentOutOfRangeException('amount');
        }
    m_Balance += amount;
}
        

     
        public static void Main()
        {
    bankAccount ba = new bankAccount('wellington', 11.99);



            Console.WriteLine("Hello World!");
        }
    }
}
