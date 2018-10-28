using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Class1().Show();

#if x64
            Console.WriteLine("x64");
#endif

#if x86
            Console.WriteLine("x86");
#endif
        }
    }
}
