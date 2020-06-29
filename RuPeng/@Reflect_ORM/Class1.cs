using System;

namespace _Reflect_ORM
{
    class Class1
    {
        static void Main(string[] args)
        {
            //ORM(Object relational mapping):Nhibernate dapper entity framework
            //对象关系映射。作用在关系型数据库和对象之间做一个映射
            //这样,我们在操作具体数据库的时候，就不需要再和复杂的SQL语句打交道，只要像平时操作对象一样操作它就可以了
            Person p1 = new Person();
            p1.Name = "rupeng";
            p1.Age = 7;

            Orm.Insert(p1);

            Dog d1 = new Dog();
            d1.Name = "adog";
            d1.Weight = 17;

            Orm.Insert(d1);
            Console.ReadKey();
        }
    }
}
