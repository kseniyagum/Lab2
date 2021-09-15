using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace локальная_функция
{
    class Program
    {
        static (int,int,int,char) returnTuple(int [] arr,string str)
        {
            return (arr.Max(), arr.Min(), arr.Sum(), str[0]);
        }
        static void Main(string[] args)
        {
            int[] myArr = { 3, 6, 3, 8, 5 };
            string myStr = "ooga booga";
            (int, int, int, char) resTuple;
            resTuple = returnTuple(myArr, myStr);
            Console.WriteLine(resTuple);

            //int k = 0;
        }
    }
}
