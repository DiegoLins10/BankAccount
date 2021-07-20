using System;

namespace BankAccount.Entities.Exceptions
{
    /*
     * Sub classe chamando a super classe ApplicationExceptions
     * para a criacao de exceptions personalizadas
     */
    class AccountExceptions : ApplicationException
    {
        public AccountExceptions(string message) : base(message)
        {
        }
    }
}
