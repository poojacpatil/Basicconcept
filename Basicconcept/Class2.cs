using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicconcept
{
    public class Employee1
    {
        //departmrent & Employee class,creat list of depatment
        public string EmpName { get; set; }
        public int EmployeeId { get; set; }
    }
    public class Department1
    {
        public string DName { get; set; }
        public int DId { get; set; }

        public List<Employee1> Employee11 = new List<Employee1>();
    }
    class program
    {
        static void Main(string[] args)
        {
            List<Department1> department11 = new List<Department1>()
            {
                new Department1{DName="Marketing",DId=34,Employee11={
                    new Employee1{EmpName="pooja",EmployeeId=76 },
                    new Employee1{EmpName="shrutika",EmployeeId=56},
                    new Employee1{EmpName="pankaj",EmployeeId=45},
                    }
                },
                new Department1{DName="HR",DId=89,Employee11={
                        new Employee1{EmpName="priya",EmployeeId=90},
                        new Employee1{EmpName="pranali",EmployeeId=78},
                        new Employee1{EmpName="sonali",EmployeeId=67 },
                    }
                },
            };
            foreach (Department1 d in department11)
            {
                Console.WriteLine($"{d.DName}{d.DId}");

                foreach (Employee1 e in d.Employee11)
                {
                    Console.WriteLine($"{e.EmpName} {e.EmployeeId}");
                }
            }

        }
    }

    public class Customer
    {
        //creat a class Customer -> number of Accounts(saving&Current)&loan(home loan,car loan)taken by the 
        //Customer->Display List Customer with their list of accounts &loan taken

        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public int CustId { get; set; }
        public List<Account> Accounts = new List<Account>();


    }
    public class Account
    {
        public string AccountType { get; set; }

        public List<Loan> Loans = new List<Loan>();

    }
    public class Loan
    {
        public string LoanType { get; set; }
        public int LoanPrice { get; set; }

    }

    class TestCust
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            {  new Customer { CustName = "pooja", CustAddress = "Karad",  CustId = 112, Accounts ={
                    new Account{AccountType = "Saving",Loans={
                            new Loan { LoanType="HomeLoan",LoanPrice=234567}, }, }, }
                };
                new Customer { CustName = "Shrutika", CustAddress = "Pune",  CustId = 11,Accounts = {
                      new Account  { AccountType = "Current", Loans = {
                            new Loan { LoanType = "CarLoan", LoanPrice = 3456789 }, }, }, }

                };
                foreach(Customer Cust in Customers)
                {
                    Console.WriteLine($"{Cust.CustName}{Cust.CustAddress}{Cust.CustId}");

                    foreach(Account Acc in Cust. Accounts)
                    {
                        Console.WriteLine($"{Acc.AccountType}");

                        foreach(Loan L in Acc.Loans)
                        {
                            Console.WriteLine($"{L.LoanType}{L.LoanPrice}");
                        }
                    }

                }

            }
        }
    }
}


    


 
    

    


    

   



         
    

    
    

