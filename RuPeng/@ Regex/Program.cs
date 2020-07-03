using System;
using System.Text.RegularExpressions;
/// <summary>
/// 正则表达式--编译原理
/// </summary>
namespace __Regex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///参数1：等待匹配的字符串
            ///参数2：正则表达式
            var xxx=Regex.IsMatch("123",@"\d{3}");
            ///只要有一部分匹配就成功
            var xxx1 = Regex.IsMatch("1243", @"\d{3}");
            ///全匹配要加上^(以…开始)和$(以…结束)
            var xxx2 = Regex.IsMatch("1243", @"^\d{3}$");

            Console.WriteLine(xxx);
            Console.WriteLine(xxx1);
            Console.WriteLine(xxx2);
            Console.Read();
        }
    }
}
