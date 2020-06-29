using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Delegates
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace TestConsole
    {

        class Class1
        {
            delegate bool CompareNum(object obj1, object obj2);
            static void Main(string[] args)
            {
                //1、
                Action<string, bool> a1 = delegate (string s, bool b) {
                    if (b) { Console.WriteLine("true" + s); }
                    else { Console.WriteLine("false" + s); }
                };
                //简化后
                Action<string, bool> a2 = (s, b) =>
                {
                    if (b) { Console.WriteLine("true" + s); }
                    else { Console.WriteLine("false" + s); }
                };
                a2("hello", true);
                //2、
                Func<string, int> f1 = delegate (string str) { return Convert.ToInt32(str); };
                Func<string, int> f2 = (str) => Convert.ToInt32(str); ;
                int i = f2("1");
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }

    }