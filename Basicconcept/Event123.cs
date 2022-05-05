using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basicconcept
{
    public delegate void MyDelegate33();
     public class User
     {  
        //    event kayword         //name of event
        public event MyDelegate33 AgeEvent;
        public void AcceptAge(int age)
        {
            if (age < 18)
                AgeEvent(); // call to the event or raise an event
            Console.WriteLine($"Your age{age}");
        }
     }
    class program12
    {
        static void ErrorMsg()
        {
            Console.WriteLine("Your age is less than 18");
        }
        static void Main(string[] args)
        {
            User user1 = new User();
            //bind event to the delegate
            user1.AgeEvent += new MyDelegate33(ErrorMsg);
            user1.AcceptAge(17);
        }
    }
    public delegate void MyDelegate34();
    public class Bank
    {
        public double balance;
        public event MyDelegate34 CreditInAcc;
        public event MyDelegate34 ZeroBalance;
        public event MyDelegate34 LowBalance;

        public Bank()
        {
            balance = 5000;
        }
         public void CreditAmount(double amt)
         {
            balance = balance + amt;
            CreditInAcc(); //raise an event
         }
        public void Debit(double debit)
        {
            if(balance==0)
            {
                ZeroBalance();
            }
            else if (balance<debit)
            {
                LowBalance();
            }
            else
            {
                balance=balance - debit;
            }
            Console.WriteLine($"Current balance{balance}");
        }
        class TestBank
        {
            static void CreditMsg()
            {
                Console.WriteLine("Your account has been credited");
            }
            static void ZeroBalanceMsg()
            {
                Console.WriteLine("Your account has no balance to debit the amount");
            }
            static void LowBalanceMsg()
            {
                Console.WriteLine("Your account has zero balance");
            }
            static void Main(string[] args)
            {
                Bank bank = new Bank();
                bank.CreditInAcc += new MyDelegate34(CreditMsg);
                bank.ZeroBalance += new MyDelegate34(ZeroBalanceMsg);
                bank.LowBalance += new MyDelegate34(LowBalanceMsg);
                bank.CreditAmount(1000);
                bank.Debit(7000);
            }
        }

        

    }
}

