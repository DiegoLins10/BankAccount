using BankAccount.Entities.Exceptions;
using System.Globalization;


namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; set; }

        /*
         * Construtores da classe
         */
        public Account()
        {

        }

        public Account(int number, string name, double balance, double withDrawLimit)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }
        /*
         * Metodo para depositar dinheiro
         */
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        /*
         * Metodo para retirar dinheiro da conta 
         */
        public void WithDraw(double amount)
        {
            /*
             * Utilizando as exceptions persoanlizadas e verificando o limite de saque
             * */
            if (amount >= WithDrawLimit)
            {
                throw new AccountExceptions("The amount exceeds withdraw limit");
            }
            else if(amount > Balance)
            {
                throw new AccountExceptions("Not enough balance");
            }
            Balance -= amount;
        }

        /*
         * ToString da classe
         */
        public override string ToString()
        {
            return "New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture); 
        }

    }

}
