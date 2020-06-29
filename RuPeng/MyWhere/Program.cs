using System;
using System.Collections.Generic;

namespace MyWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 5, 9, 12, 38, 9 };
            IEnumerable<int> r1 = nums.MyWhere(i => i > 10); //delegate(int i){return i>10;}
            foreach (var item in r1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    static class JiHeExt
    {

        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> data, Func<T, bool> func)
        {
            var resultList = new List<T>();
            //实现了IEnumerable的对象就能用foreach遍历
            foreach (var item in data)
            {
                if (func(item))
                {//判断便利道德这条数据是否满足条件
                    resultList.Add(item);
                }
            }
            return resultList;
        }
    }
}
