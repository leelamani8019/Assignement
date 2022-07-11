using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceproject
{
    public interface addition
    {
        void add(int a,int b);
    }
    public interface multipication
    {
        void multiply(int a,int b);
    }
    public class Classinter : addition, multipication
    {
        public int c;
        public void add(int a,int b)
        {
            c = a + b;
            Console.WriteLine(c);

        }
        public void multiply(int a,int b)
        {
            c = a * b;
            Console.WriteLine(c);

        }
    }
}