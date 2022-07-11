using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment1
{
    public class renser
    {
        public int c, j;
        public void Check()
        {
            int[] count = { 50, 65, 56, 71, 81 };
          
            foreach (int i in count)
            {
                if (i % 2 == 0)
                {
                    c += 1;
                }
                else
                {

                    j += 1;
                }
            }
            Console.WriteLine(c);
            Console.WriteLine(j);

            
        }
    }
}
