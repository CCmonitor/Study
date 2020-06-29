using System;
using System.Reflection;

namespace _Reflect
{
    //反射(Reflect)的概念：
    class Program
    {
        static void Main(string[] args)
        {
            //①首先拿到person类的type
            Type type = typeof(Person);

            //②创建对象.
            //②_Ⅰ 调用的是默认的无参的构造函数
            Object obj = Activator.CreateInstance(type);//new person()

            //②_Ⅱ 
            //--type.GetConstructor(new Type[0])拿到无参构造函数
            //--Invoke调用构造函数
            Object obj2 = type.GetConstructor(new Type[0]).Invoke(new object[0]);//new person()

            //③通过type获得Name属性
            PropertyInfo propName = type.GetProperty("Name");

            //④给obj对象设置name的值
            propName.SetValue(obj, "rupeng");//obj.Name="rupeng"

            PropertyInfo propAge = type.GetProperty("Age");
            propAge.SetValue(obj, 18);//obj.Age=18
            propAge.SetValue(obj2, 99);//obj2.Age=99
            //⑤获得SayHi()方法
            MethodInfo methodSayHi = type.GetMethod("SayHi", new Type[0]);
            //⑥在obj指向的对象上调用SayHi方法。Obj.sayhi
            methodSayHi.Invoke(obj, new object[0]);
            MethodInfo methodSayHi2 = type.GetMethod("SayHi", new Type[] { typeof(string) });
            methodSayHi2.Invoke(obj, new object[] { "hahahahahahaha" });//obj.SayHi("hahahahahahaha");
            methodSayHi.Invoke(obj2, new object[0]);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
        }
        public Person(string name)
        {
        }
        public Person(int age, string name)
        {
        }
        public void SayHi()
        {
            Console.WriteLine("大家好，我是" + this.Name + ",我的年龄" + this.Age);
        }

        public void SayHi(string s)
        {
            Console.WriteLine("Hi" + s);
        }
    }
}
