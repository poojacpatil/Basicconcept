using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicconcept
{
    public class productttt
    {
     public string Name { get; set; }   
        public  int Id { get; set; }    
        public int price { get; set; }

    }
    class Testproduct
    {
        static void Main(string[] args)
        {
            List<productttt> productList=new List<productttt>()
            {
                   new productttt { Name = "Hp", Id = 1, price = 45600 },
                   new productttt { Name = "Dell", Id = 2, price = 35600 },
                   new productttt { Name = "Lenovo", Id = 3, price = 30000 },
                   new productttt { Name = "sony", Id = 4, price = 32000 },
                   new productttt { Name = "accer", Id = 5, price = 45000 },
                   new productttt { Name = "Hp", Id = 6, price = 43600 }, 
                   new productttt { Name = "Hp", Id = 7, price = 42000 },

            };
           // var result1 = from p in productList
              //            where p.price < 40000
              //            orderby p.price
               //           select p;

          /*  var result1 =from p in productList
                         where p.price>35000 && p.price<45000
                          orderby p.price
                         select p; */
          
            var result1= from p in productList
                         where p.Name.StartsWith('l') || p.Name.StartsWith('L')
                         orderby p.Name
                         select p;


            foreach(productttt p in result1)
            {
                Console.WriteLine($"{p.Name}{p.price}");
            }
        }
    }
    public class Employeeee
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string City { get; set; }    
        public double Salary { get; set; }
        public string Dept { get; set; }

    }
    class program555
    {
        static void Main(string[] args)
        {


            List<Employeeee> EmployeList = new List<Employeeee>()
            {
            new Employeeee{Id=1, Name ="Priya",City="Pune",Salary=40000,Dept="HR"},
            new Employeeee{Id=2, Name ="Shrutika",City="Mumbai",Salary=30000,Dept="Production"},
            new Employeeee{Id=3, Name ="Sonali",City="Satara",Salary=45000,Dept="Marketing"},
            new Employeeee{Id=4, Name ="pooja",City="Karad",Salary=50000,Dept="HR"},
            new Employeeee{Id=5, Name ="Ankita",City="Kolhapur",Salary=48000,Dept="Production"},
            new Employeeee{Id=6, Name ="Dhiraj",City="Sangmner",Salary=35000,Dept="Marketing"},
            new Employeeee{Id=7, Name ="Vaibhav",City="Sangli",Salary=38000,Dept="HR"},
            new Employeeee{Id=8, Name ="Pankaj",City="Amravti",Salary=33000,Dept="Production"},
            new Employeeee{Id=9 ,Name ="Komal",City="Nashik",Salary=44000,Dept="HR"},
            new Employeeee{Id=10, Name ="Sushant",City="Kadehav",Salary=48000,Dept="Marketing"},


           };
        
    
            //1.Display emp whose salary is greater than 45000
            /* var result2 = from e in EmployeList
                           where e.Salary > 45000
                           orderby e.Salary
                           select e;*/

            /*2.Display all emp accending order by their name
             var result2 = from e in EmployeList
                             orderby e.Name 
                            select e; */

            /*3.display emp who name start with 'a' or'k'
             var result2 = from e in EmployeList
                           where e.Name.StartsWith('A') || e.Name.StartsWith('K')
                           orderby e.Name
                             select e;*/

            /*4.display emp who belongs to HR department
             var result2 = from e in EmployeList
                           where e.Dept.Contains("HR")
                           orderby e.Dept
                           select e;*/

            /*5.display all emp orderby salary desending
            var result2 = from e in EmployeList
                         orderby e.Salary descending
                         select e;*/

            /*6.display emps belongs to pune city & salary <35000
                   var  result2 = from e in EmployeList
                                  where e.City.Contains("Pune") && e.Salary > 35000
                                  select e;*/

            //7.display emp who lives in mumbai city
                 var result2 = from e in EmployeList
                               where e.City.Contains("Mumbai")
                               orderby e.City
                               select e;



            foreach (Employeeee e in result2)
            {
                Console.WriteLine($"{e.Name}  {e.City} {e.Salary} {e.Dept}");
            }
           
        }
    }
    public class Course
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Fees { get; set; }
    }
    class TestCourse
    {
        static void Main(string[] args)
        {
             List<Course> CourseList = new List<Course>()
             { 
                new Course { Id=1,Name="C#",Fees=4500},
                new Course { Id=2,Name="JAVA",Fees=3000},
                new Course { Id=3,Name="HTML",Fees=2800},
                new Course { Id=4,Name="C",Fees=4000},
                new Course { Id=5,Name="C++",Fees=4800},
                new Course { Id=6,Name="SQL",Fees=5000},
                new Course { Id=7,Name="PYTHON",Fees=4300},
                new Course { Id=8,Name="AUTOCAD",Fees=3500},
                new Course { Id=9,Name="PHP",Fees=3800},
                new Course { Id=10,Name="DOT NET",Fees=4200},
            };
            /*1.display course whose fees is greater than 4000
            var result1=from c in CourseList
                        where c.Fees>4500
                        orderby c.Fees
                        select c;*/

            /*2.display all element assending order by their name
            var result1 = from c in CourseList
                          orderby c.Name
                          select c;*/

            /*3.display all element Fees betwwen than 3500 to 4500
               var result1 = from c in CourseList
                             where c.Fees > 3500 && c.Fees < 4500
                             orderby c.Fees
                            select c;*/

          /*4.display course  belong to java
            var result1 = from c in CourseList
                          where c.Name.Contains("JAVA")
                          orderby c.Name
                          select c;*/

            //5.display course fees assending order
              var result1 = from c in CourseList
                              orderby c.Fees
                             select c;


            foreach (Course c in result1)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
            }
        }
    }
   public class student
    {
        public int Rollno { get; set; }
        public int percentage { get; set; }
        public string branch { get; set; }
    }
    class TestStud
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>()
            {
                new student { Rollno=23,percentage=85,branch="Civil"},
                new student { Rollno=31,percentage=90,branch="Mechanical"},
                new student { Rollno=45,percentage=80,branch="IT"},
                new student { Rollno=44,percentage=98,branch="ComputerScience"},
                new student { Rollno=40,percentage=91,branch="E&TC"},
                new student { Rollno=16,percentage=95,branch="Electrical"},
                new student { Rollno=27,percentage=88,branch="AutoMobile"},
            };
            /*1.display percentage in assding order
            var result3 = from S in students
                         orderby S.percentage
                         select S;*/

            /*2.display student of Mechanical branch
            var result3 = from S in students
                          where S.branch.Contains("Mechanical")
                          orderby S.branch
                         select S;*/

            /*3.display student percentage between 85 to 90
            var result3 = from S in students
                          where S.percentage>=85 && S.percentage<=90
                        orderby S.percentage
                         select S;*/

            /*4.display the branch name in assending order
            var result3 = from S in students
                           orderby S.branch
                           select S;*/

           //5.display the branch E&TC & percentage <90
            var result3 = from S in students
                          where S.percentage > 90 && S.branch == "E&TC"
                        select S;

            foreach (student S in result3)
            {
                Console.WriteLine($"{S.Rollno} {S.percentage} {S.branch}");
            }
        }
    }

 }
