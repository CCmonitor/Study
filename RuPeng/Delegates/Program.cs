using System;
namespace Delegates
{

    delegate void MyDel1(string s, string s1);

    /// <summary>
    ///委托是一种可以指向方法的数据类型
    ///声明委托的方式:
    ///delagate 返回值类型 委托类型名(参数)
    ///delegate void           MyDel        (int n):
    ///定义一个类型为MyDel数据类型,(这个MyDel类似于int)
    ///MyDel这个类型的变量可以指向一个"返回值为Void,参数为int"的方法
    /// 委托(Delagates)
    /// </summary>
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            //MyDel d1 = new MyDel(M1);//①声明一个MyDel类型的变量d1,new MyDel(m1)创建一个指向m1方法的对象
            //①可以简化成
            //MyDel d1 = M1;//②
            Action<int> Action = new Action<int>(M1);
            Func<int, bool> func = new Func<int, bool>(M2);
            //调用
            Action(200000);
            System.Console.WriteLine("value of num :{0}", func(2));
            //MyDel nc1 = new MyDel(Addnum);
            //nc1(25);
            System.Console.WriteLine("value of num :{0}", num);
            System.Console.ReadKey();
        }

        static bool M2(int a)
        {
            return a > 0;
        }
        static void M1(int a)
        {
            System.Console.WriteLine("M1" + a);
        }

        private static int Addnum(int p)
        {
            num += p;
            return num;
        }
    }
}
