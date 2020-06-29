using System;

namespace _Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.OnBenMingNian += BMN;//方法的参数返回值要和事件的委托一致

            p1.Age = 5;
            Console.WriteLine(p1.Age);
            p1.Age = 24;
            Console.WriteLine(p1.Age);
            p1.Age = 55;
            Console.WriteLine(p1.Age);
            p1.Age = 48;
            Console.WriteLine(p1.Age);

            Console.ReadKey();
        }

        static void BMN()
        {
            Console.WriteLine("到了本命年了");

        }
    }
}
