using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки
{
    class Program
    {
        static void Main(string[] args)
        {

            //a. Объявите строковые литералы. Сравните их.
            string st1 = "aaa";
            string st2 = "aaa";
            Console.WriteLine(String.Compare(st1,st2));

            //b. Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки.
            
            string myStr1 = "first";
            string myStr2 = "second";
            string myStr3 = "third string";
            Console.WriteLine (myStr1 + myStr2);
            Console.WriteLine(String.Concat(myStr1,myStr2));
            Console.WriteLine(String.Copy(myStr3));
            Console.WriteLine(myStr3.Substring(5));
            string[] words = myStr3.Split();
            Console.WriteLine(words.Length);
            Console.WriteLine(myStr1.Insert(2, "ooo"));
            Console.WriteLine(myStr3.Remove(3, 2));

            //c. Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty.Продемонстрируйте что еще можно выполнить с такими строками
            
            string strNull = null;
            string strEmpty = "";
            bool flag1 = String.IsNullOrEmpty(strNull);
            bool flag2= String.IsNullOrEmpty(strEmpty);
            Console.WriteLine("strNull is Null:" + flag1 + " \nand strEmpty is Empty:" + flag2);
            //null-обьединения
            string strNull1 = null;
            string str1 = strNull1 ?? "default";//str1 принимает зн-е strNull1 если strNull1!=null и "default" иначе

            //d. Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.

            StringBuilder strBldr = new StringBuilder("Is it true that you are a scorpion? Yes");
            strBldr.Remove(0, 36);
            strBldr.Insert(3, ", I am. ");
            strBldr.AppendFormat("I am a scorpion");
            strBldr.Replace("scorpion", "scorpion.");
            Console.WriteLine(strBldr);
        }
    }
}
