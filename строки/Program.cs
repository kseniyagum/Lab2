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

            int str1IsBigger = String.Compare("aaa","bbb");

            //b. Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки.
            
            string myStr1 = "aboba";
            string myStr2 = "biliboba";
            string myStr3 = "ooga booga";
            string conStr = myStr1 + myStr2;
            string conStr1 = String.Concat(myStr1,myStr2);
            string copyStr = String.Copy(myStr3);
            string subStr = myStr3.Substring(5);
            string[] words = myStr3.Split();
            string insSubStr = myStr1.Insert(2, "ooo");
            string delSubStr = insSubStr.Remove(3, 2);

            ////Продемонстрируйте интерполирование строк. 

            string interStr1 = "Vasya";
            string interStr2 = "Ivanov";
            string interRes = String.Format("name : {0}, lastname : {1}", interStr1, interStr2);

            //c. Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty.Продемонстрируйте что еще можно выполнить с такими строками
            
            string strNull = null;
            string strEmpty = "";
            bool flag1 = String.IsNullOrEmpty(strNull);
            bool flag2= String.IsNullOrEmpty(strEmpty);
            //null-обьединения
            string strNull1 = null;
            string str1 = strNull1 ?? "default";//str1 принимает зн-е strNull1 если strNull1!=null и "default" иначе

            //d. Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.

            StringBuilder strBldr = new StringBuilder("thick fluffy cat");
            strBldr.Remove(3, 1);
            strBldr.Insert(6, "chonky");
            strBldr.AppendFormat("very good");
            strBldr.Replace("o", "u");
            int strCap = strBldr.Capacity;
            int strLen = strBldr.Length;


            int k = 0;
        }
    }
}
