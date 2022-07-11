using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodloading
{
    public class Method
    {
        public void ping(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("positive number");
            }
            else
            {
                Console.WriteLine("its not a posiyive number");
            }
        }
        public void ping()
        {
            Console.WriteLine("hello world");

        }
        public void ping(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
