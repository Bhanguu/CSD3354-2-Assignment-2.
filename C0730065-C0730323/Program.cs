using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730065_C0730323
{
    class Program
    {
        static void Main(string[] args)
        { }
                public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Methods1");
            Console.ReadLine();

        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
