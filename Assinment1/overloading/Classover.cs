using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    public class Classover
    {
        public int c;
        public Classover(int a,int b,int d)
        {
            c=a+b+d;
            Console.WriteLine(c);   
 

        }
       public Classover(int a,int b) 
        {
            c = a + b;
            Console.WriteLine(c);

        }
    }
}
