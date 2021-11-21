
using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new();
            myAccount.Balance = 899.79;
            myAccount.Chek = Chek.debit;
            BankAccount myAccount2 = new();
            myAccount2.Balance = 9778.34;
            myAccount2.Chek = Chek.credit;
            Console.WriteLine(myAccount);
            Console.WriteLine(myAccount2);
            Console.WriteLine(myAccount==myAccount2);
            Console.WriteLine(myAccount!= myAccount2);
            Console.WriteLine(myAccount.Equals(myAccount2));

        }
    }
}
