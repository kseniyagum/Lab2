using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 

            Random rnd = new Random();
            int[,] myArr1 = new int[3, 4];
            for(int i = 0; i < myArr1.GetLength(0); i++)
            {
                for (int j = 0; j < myArr1.GetLength(1); j++)
                {
                    myArr1[i, j] = rnd.Next(10, 100);
                    Console.Write(myArr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //b. Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент(пользователь определяет позицию и значение)

            string[] myArr2 = new string[5] { "fd", "sdf", "erdg", "sdgd", "ert" };
            foreach(var item in myArr2)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine(myArr2.Length);
            myArr2[3] = "dsfgssf";

            //c. Создайте ступечатый (не выровненный) массив вещественных чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно.Значения массива введите с консоли.

            int[][] myArr3 = new int[3][];
            myArr3[0] = new int[2];
            myArr3[1] = new int[3];
            myArr3[2] = new int[4];
            for(int i = 0; i < myArr3.Length; i++)
            {
                for(int j=0;j< myArr3[i].Length; j++)
                {
                    //myArr3[i][j] = rnd.Next(-20, 20);
                    myArr3[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < myArr3.Length; i++)
            {
                for (int j = 0; j < myArr3[i].Length; j++)
                {
                    Console.Write(myArr3[i][j] + "\t");
                }
                Console.WriteLine();
            }

            //d. Создайте неявно типизированные переменные для хранения массива и строки.

                        var varArr = new[] { 4, 6, 8, 5, 8 };
            var varStr = "oogabooga";

            int k = 0;

        }
    }
}
