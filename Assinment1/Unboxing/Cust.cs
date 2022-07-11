using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing
{
    public class Cust
    {
        public void boxing()
        {
            Console.WriteLine(String.Concat("Answer", 42, true));

        }
        public void unboxing()
        {
            int i = 123;
            object o = i;     // boxing
            int j = (int)o; // unboxing
            Console.WriteLine(o);   
        }
    }
}
