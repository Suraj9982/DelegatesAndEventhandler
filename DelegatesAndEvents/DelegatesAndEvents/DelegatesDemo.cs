using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int Mydelegate(int x, int y);
    class DelegatesDemo
    {
        public static int Addition(int a,int b)
        {
            return a + b;
        }
    }
}
