using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            string sa = a.ToString();
            int ia=sa.IndexOf("0");
           int newa= int.Parse(sa.Remove(ia, 1));
            string sb = b.ToString();
            int ib = sb.IndexOf("0");
           int newb=int.Parse( sb.Remove(ib, 1));
           string sc = c.ToString();
           int ic = sa.IndexOf("0");
           int newc = int.Parse(sc.Remove(ic, 1));
           int newc2 = newa + newb;
           if (newc == newc2)
           {
               Console.WriteLine("true");
           }
           else
           {
               Console.WriteLine("false");
           }
           Console.ReadLine();
        }
        
    }
    
}
