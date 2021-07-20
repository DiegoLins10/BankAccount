using BankAccount.Entities;
using BankAccount.Entities.Exceptions;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limitBalance = double.Parse(Console.ReadLine());
                Account account = new Account(number, name, balance, limitBalance);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                account.WithDraw(withdraw);
                Console.WriteLine(account);
            }
            /*
             * Exception personalizada
             */
            catch (AccountExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }/*
              * exception de formato de entrada
              */
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            /*
             * exception Generica
             */
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
