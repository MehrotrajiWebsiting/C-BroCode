using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class generics
    {
        static void Main(String[] args)
        {
            int a = 1;
            double b = 2.4;
            String c = "om";
            bool d = false;

            display(a);
            display(b);
            display(c);
            display(d);
        }
        public static void display<T>(T x)
        {
            Console.WriteLine(x+" "+x.GetType());
        }
    }
}
