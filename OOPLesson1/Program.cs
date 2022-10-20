using System;

namespace OOPLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckStringOk("a1233456789"));
            Console.WriteLine(CheckStringOk("11233456789"));




        }
        static bool CheckStringOk(string str1)
        {
            return str1[0] >= 'a' && str1[0] <= 'z' &&
                   str1.Length >= 8 &&
                   str1[str1.Length - 1] >= '0' &&
                   str1[str1.Length - 1] <= '9';
        }
    }
}
