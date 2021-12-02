using System;

namespace DelegatesAndEvents
{
    class Program
    {
        public static event DelEventHandler Add;
        static void Main(string[] args)
        {
            Mydelegate obj = new Mydelegate(DelegatesDemo.Addition);
            Console.WriteLine("addition is {0}", obj(23, 27));
            Multicastdelegates.ImplementDelegate();
            Add += new DelEventHandler(EventHandler.India);
            Add += new DelEventHandler(EventHandler.USA);
            Add += new DelEventHandler(EventHandler.England);
            Add.Invoke();
        }
    }
}
