using System;

namespace Lesson6
{
    class BankAccount
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        internal Chek Chek { get; set; }

        private static int nextnumber = 1;
        private static void CreateNumber()
        {
            nextnumber++;
        }
        public override string ToString()
        {
            return $"номер счета {Number}\n" +
                $"баланс {Balance}\n" +
                $"тип счет {Chek}";
        }
        public static bool operator ==(BankAccount number1, BankAccount number2)
        {
            return (number1.Balance == number2.Balance && number1.Chek == number2.Chek);
        }
        public static bool operator !=(BankAccount number1, BankAccount number2)
        {
            return (number1.Balance != number2.Balance || number1.Chek == number2.Chek);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Balance, Number, Chek);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, (BankAccount)obj))
            {
                return true;
            }
            return Balance == ((BankAccount)obj).Balance && Chek == ((BankAccount)obj).Chek;
        }
        public bool GetTransfer(ref BankAccount from, double summ)
        {
            if (from.Balance >= summ)
            {
                from.Balance -= summ;
                Balance += summ;
                return true;
            }
            else
            {
                return false;
            }
        }
        public BankAccount()
        {
            this.Number = nextnumber;
            CreateNumber();
        }
        public BankAccount(double money) : this()
        {
            Balance = money;
        }
        public BankAccount(Chek type) : this()
        {
            Chek = type;
        }
        public BankAccount(double money, Chek type) : this()
        {
            Balance = money;
            Chek = type;
        }
    }
}
enum Chek
{
    no,
    debit,
    credit,
    current
}
