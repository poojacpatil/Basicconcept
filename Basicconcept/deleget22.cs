using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicconcept
{
    //step 1: declare the delegate
    public delegate int MyDelegate(int n1, int n2);
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a,int b)
        {
            return a-b;
        }
        public int multiply(int a,int b)
        {
            return a * b;
        }

    }
    class programmmm
    {
        static void Main(string[] args)
        {
            Calculation c=new Calculation();
            //+=add method ref in the invocation list
            MyDelegate mydel = new MyDelegate(c.Add);//added method ref
            mydel +=new MyDelegate(c.sub);
            mydel +=new MyDelegate(c.multiply);
            //-= can be used to remove method reference from the invocation list
            mydel -=new MyDelegate(c.Add);
            Delegate []list=mydel.GetInvocationList();
            foreach(Delegate a in list)
            {
                Console.WriteLine(a.Method);
                Console.WriteLine(a.DynamicInvoke(45,32));
            }

        }
    }
    public delegate void MyDelegate2(string s);
   public class calci
   { 
        public void Uppercase(string s)
        {
           s=s.ToUpper();
            Console.WriteLine(s);
        }
        public void Lowercase(string s)
        {
            s=s.ToLower();
            Console.WriteLine(s);
        }
    }
    class Testprogram
    {
        static void Main(string[] args)
        {
            calci c = new calci();
            MyDelegate2 m1=new MyDelegate2(c.Uppercase);
            m1+=new MyDelegate2(c.Lowercase);
            Delegate []list=m1.GetInvocationList();

            foreach( Delegate a in list)
            {
                Console.WriteLine(a.Method);
                a.DynamicInvoke("pooja");
            }
        }
    }

}
