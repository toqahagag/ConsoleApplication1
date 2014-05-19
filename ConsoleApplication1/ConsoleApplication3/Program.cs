using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string w = Console.ReadLine();
           string a= w.ToLower();
           string firstletter = a.Substring(0, 1).ToUpper();
           string sub=a.Remove(0, 1);
           string newword = firstletter +sub;
           Console.WriteLine(newword);
           Console.ReadLine();
        }
    }
}
