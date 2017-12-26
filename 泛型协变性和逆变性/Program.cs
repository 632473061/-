using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Caching;

namespace 泛型协变性和逆变性
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Derived> dlist = new List<Derived>();

            //Derived.PrintBases(dlist);
            //IEnumerable<Base> bIEnum = dlist;
        
            //Test3();
            //Test4();
            //Cache.Add("Category", "asdas", null, DateTime.Now.AddSeconds(60), TimeSpan.Zero, CacheItemPriority.Normal, null);
              
        }

        

        private static void Test3()
        {
            string res = "开始";
            Console.WriteLine("test3 start\n" + DateTime.Now);
            var t1 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                res += "t1";
            });

            var t2 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                res += "t2";
            });

            var t3 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                res += "t3";
            });
            Console.WriteLine(res);
            t1.Wait();
            Console.WriteLine(res);
            t2.Wait();
            Console.WriteLine(res);
            t3.Wait();
            Console.WriteLine(res);
          
            Console.WriteLine("test3  end\n" + DateTime.Now);
        }
        private static void Test4()
        {
            Console.WriteLine("Test4 start\n" + DateTime.Now);
           
                Thread.Sleep(1000);
                Thread.Sleep(1000); 
                Thread.Sleep(1000);

                Console.WriteLine("Test4  end\n" + DateTime.Now);
        }  
    }

    class Base
    {
        public static void PrintBases(IEnumerable<Base> bases)
        {
            foreach (Base b in bases)
            {
                Console.WriteLine(b);
            }
        }
    }

    class Derived : Base
    {
      
    }
}
