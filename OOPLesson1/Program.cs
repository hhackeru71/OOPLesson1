using System;

namespace OOPLesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string name = " yarin shet ";
            //string str1 = "hello";
            //Console.WriteLine(str1 + name);
            //Console.WriteLine(str1+name.TrimStart());
            //Console.WriteLine(name.TrimEnd()+str1);
            //Console.WriteLine(str1 + name.Trim() +str1);//helloyarinhello
            //string before = "good  , what nla";
            //string after = before.Replace("morning", "night");
            //Console.WriteLine(after);//

            string str2 = "helloyarinshaerold";
            //Console.WriteLine(str2.Remove(6));
            //Console.WriteLine(str2.StartsWith("hello"));

            string name = "asd";

            // Console.WriteLine(a);
            int? a = null;

            double max = Math.Max(2, 6);
            Console.WriteLine(max);
            double min = Math.Min(2, 3);
            Console.WriteLine(min);







            //string name = Console.ReadLine();

            //string st1 = name.Substring(0, 5);
            //Console.WriteLine(st1);



            //string name = "yarinshaer1234";
            
            ////Console.WriteLine(name.ToUpper());
            ////Console.WriteLine(name.ToLower());
            ////name = string.Concat(name, "world");
            ////Console.WriteLine(name);
            //string str1 = name.Substring(0,4);
            //Console.WriteLine(str1);
            ////לקלוט מחרוזת לחתוך את המחרוזת מהאינדקס 0 עד 5 אותיות (אורך)














            //Ptr1();
            //Pt2();
        }

        private static void Pt2()
        {
            
        }

        static void Ptr1()
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

        static int GetStringSize(string str)
        {
            return str.Length;
        }

        static string GetBigString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
                return str1;
            return str2;

        }

        static bool IsEqualStrings(string str1, string str2)
        {
            return str1 == str2;
        }


    }
}
