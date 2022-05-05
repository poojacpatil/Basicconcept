using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Basicconcept
{
    class EmployeeCompare : IComparable
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int salary { get; set; }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
    public class test : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            EmployeeCompare e1 = (EmployeeCompare)obj1;
            EmployeeCompare e2 = (EmployeeCompare)obj2;

            if (e1.salary > e2.salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            EmployeeCompare e1 = new EmployeeCompare { Eid = 1, Ename = "pooja", salary = 30000 };
            EmployeeCompare e2 = new EmployeeCompare { Eid = 2, Ename = "shrutika", salary = 45000 };
        }
    }

    public class Employee
    {
        //List using generic collection
       public int Id { get; set; }
        public  string Name { get; set; }
          public int Salary { get; set; } 
          static void Main(string[] args)

          {
              List<Employee>Employeelist=new List<Employee>()
              {
               new Employee { Id = 1, Name = "patil", Salary = 20000 },
                new Employee { Id = 2, Name = "pooja", Salary = 30000 },
                new Employee{Id = 3, Name ="Shrutika",Salary=45000},
                
              };
            foreach(Employee o in Employeelist)
            {
                Console.WriteLine($"{o.Id} {o.Name} {o.Salary}");
            }
            Console.ReadLine();
            
          }
       
            
    }

    public class product
    {
         public int productid { get; set; }
          public int productprice { get; set; } 
        public string productname { get; set; }

        static void Main(string[] args)
        {
            List<product> productLists = new List<product>()
            {
               new product { productid = 1, productprice = 2000, productname = "ABCD" },
               new product { productid = 2, productprice = 5000, productname = "UYTR" },
               new product { productid = 3, productprice = 6578, productname = "KJHGG" },
            };
            foreach(product p in productLists)
            {
                Console.WriteLine($"{p.productid} {p.productprice}{p.productname}");
            }
            Console.ReadLine();
        }
        
    }
    public class Student
    {
        public string name {get; set; }    
        public int rollno { get; set; }
        public int id { get; set; }

        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
               new Student { name = "pooja", rollno = 41, id = 1 },
               new Student { name = "shrutika", rollno = 25, id = 2 },
               new Student { name = "priya", rollno = 16, id = 3 },
            };


            foreach (Student s in studentList)
            {
                Console.WriteLine($"{s.name}{s.rollno}{s.id}");
            }
            Console.ReadLine();
        }

    }

    class course
    {
        public string name { get; set; }    
        public int coursefees { get; set; }
        public string trainer { get; set; }
        public int startdate { get; set; }

        static void Main(string[] args)
        {
            List<course> coursList = new List<course>()
            {
                new course { name = "c#", coursefees = 5000, trainer = "ABCDE", startdate = 15 / 03 / 2022 },
                new course { name = "java", coursefees = 8000, trainer = "MNBV", startdate = 23 / 03 / 2022 },
                new course { name = "c++", coursefees = 3000, trainer = "HGFD", startdate = 16 / 05 / 2022 },

            };
            foreach (course c in coursList)
            {
                Console.WriteLine($"{c.name} {c.coursefees} {c.trainer} {c.startdate}");
            }
            Console.ReadLine();
        }
    }
     class Department
     {
        public string DepartmentName { get; set; }
        public string EName { get; set; }
        public int Employeeid { get; set; }
        public int NoOfEmployee { get; set; }

        static void Main(string[] args)
        {
            List<Department> departmentList = new List<Department>()
            {
             new Department { DepartmentName = "Marketing", EName = "XYZ", Employeeid = 121, NoOfEmployee = 200 },
            new Department { DepartmentName = "Production", EName = "PQR", Employeeid = 234, NoOfEmployee = 150 },
            new Department { DepartmentName = "HR", EName = "JKL", Employeeid = 543, NoOfEmployee = 100 },
            };
            foreach(Department d in departmentList)
            {
                Console.WriteLine($"{d.DepartmentName}{d.EName}{d.Employeeid}{d.NoOfEmployee}");
            }
            Console.ReadLine();
        }

     }
    class product1
    {
        //stack using non generic collection
        static void Main(string[] args)
        {
            Stack st1=new Stack();
            st1.Push("icecreame");
            st1.Push("chochalateicecreame"); 
            st1.Push("mangoicecreame");
            st1.Push("vannilaicecreame");
            st1.Push("null");
            st1.Push(1234);
            st1.Push(4567.89);

            Console.WriteLine("Total elements present in "+"st1: {0}",st1.Count);

            st1.Pop();
            Console.WriteLine("Total element present in "+ "st1:{0}",st1.Count);
         

            st1.Clear();
            Console.WriteLine("Total element prresent in "+ "st1:{0}",st1.Count);
            

        }
    }
    
    class DFGH
    {
        //stack using pop generic collection
        static void Main(string[] args)
        {
            Stack<int>st2=new Stack<int>();
            st2.Push(1);
            st2.Push(2);
            st2.Push(3);
            st2.Push(4);

            Console.WriteLine("Number of element in stack :{0}",st2.Count);

            while (st2.Count > 0)
            {
                Console.Write(st2.Pop() + " ,");
            }
            Console.WriteLine("Number of element in stack:{0}",st2.Count);
        }
    }
    class QueEmployee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int salary { get; set; }

        static void Main(string[] args)
        {
            QueEmployee emp1 = new QueEmployee()
            {
                Empid = 101,
                EmpName = "sonali",
                salary = 33000,
            };
            QueEmployee emp2 = new QueEmployee()
            {
                Empid = 111,
                EmpName = "sneha",
                salary = 30000,
            };
            QueEmployee emp3 = new QueEmployee()
            {
                Empid = 901,
                EmpName = "pranali",
                salary = 20000,
            };
            Queue<QueEmployee> queue = new Queue<QueEmployee>();
            queue.Enqueue(emp1);
            queue.Enqueue(emp2);
            queue.Enqueue(emp3);

            foreach(QueEmployee emp in queue)
            {
                Console.WriteLine($"{emp.Empid} {emp.EmpName} {emp.salary}");
            }
            queue.Dequeue();
            Console.WriteLine("////////////////////////////////////");
            foreach(QueEmployee emp in queue)
            {
                Console.WriteLine($"{emp.Empid} {emp.EmpName}{emp.salary}");
            }

        }

    }
}

