using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кортежи //комбинируют объекты различных типов
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.

            (int, string, char, string, ulong) myTuple1 = (3, "good luck",'h',"dear friend",234);
            var myTuple = (5, "this is string", 'b', "else str", 123);

            //b. Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)
            Console.WriteLine(myTuple1);
            Console.WriteLine(myTuple);

            Console.WriteLine(myTuple1.Item1 + '\t' + myTuple1.Item2 + myTuple1.Item4); //Item получчает значение элемента в массиве

            //вывести весь кортеж

            //c. Выполните распаковку кортежа в переменные. Продемонстрируйте различные способы распаковки кортежа. Продемонстрируйте использование переменной(_). (доступно начиная с C#7.3)
            var newTuple = (true, 8, 'l', '_', '_');
            var (a, b, c, d, e) = newTuple;
            (bool a1, int b1, char c1, char d11, char d1) = newTuple;

            //d. Сравните два кортежа

            bool flag = myTuple.Equals(myTuple1);
            Console.WriteLine(flag);
        }
    }
}
