using System;

namespace типы
{
    class Program //По умолчанию проект консольного приложения уже содержит один класс Program, с которого и начинается выполнение программы.
    {
        static void Main(string[] args) //для передачи в параметрах командной строки
        {
            // ; - конец инструкции
            //boxing - помещение в кучу , unboxing - извлечение
            // неявные пр-я - из меньшего в большее, явные(привидения) - из большего в меньшее

            //a. Определите переменные всех возможных примитивных типов С# и проинициализируйте их. Осуществите ввод и вывод их значений используя консоль.
            Console.WriteLine("Hello World!");
            bool myb = true;
            byte mybyte = 199;
            sbyte mysb = -128;
            short mysh = -32000;
            ushort myush = 64000;
            int myi = 324342;
            uint myui = 0;
            long mylong1 = System.Int64.MaxValue;
            long myl = -4342;
            ulong myul = 3;
            decimal mydec = -3;
            float myfl = -345.3f;
            double mydouble = 34.34d;
            char mych = 'x';
            Console.WriteLine(mylong1);

            

            //b. Выполните 5 операций явного и 5 неявного приведения

            double d11 = 456.45d;
            float f11 = (float)d11;
            int i11 = 34324;
            byte b11 = (byte)i11;
            short sh11 = 344;
            byte b12 = (byte)sh11;
            decimal dec11 = 3423434;
            ushort ush11 = (ushort)b12;
            long lo11 = 34;
            sbyte mysb11 = (sbyte)lo11;

            long l11 = i11;
            sh11 = b11;
            myl = myi;
            mydouble = d11;
            myfl = mysh;
            int k = 0;

            //c. Выполните упаковку и распаковку значимых типов.

            //упаковка и распаковка - преобразование из значимого в ссылочный и наоборот
            int a = 34; //int - стр-ра, стр-ра - значимый тип
            object b = a;//упаковка. в object можно присвоить все что угодно, т.к. это базовый тип данных
            //т.к. object класс а не структура, он лежит в куче. в b оказалась ссылка на данные об a в куче
            int c = (int)b;//распаковкa

            //d. Продемонстрируйте работу с неявно типизированной переменной.

            var myvar1 = -3244; //переменная типа short
            var myvar2 = "string";
            Console.WriteLine(myvar1.GetType().ToString());
            Console.WriteLine(myvar2.GetType().ToString());
            

            //e. Продемонстрируйте пример работы с Nullable переменной

            //null - совместимые значимые типы
            //null значит что нету ссылки на данные в упр. куче. с nullable значимые типы могут хранить null
            int? y = null;
            if (y.HasValue) //проверка на наличие значения
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("there is a null in the y");

            Nullable<int> y1; //применяется только для типов значений


            ////возможности класса Convert. 

            ////int i1 = Convert.ToInt32(Console.ReadLine());
            ////int i2 = Convert.ToInt32(Console.ReadLine());
            //int i1 = 8; int i2 = 14;
            //int sum = i1 + i2;
            //Console.WriteLine("summ of i1 and i2 : " + sum);
            //string mystr1 = "343";
            //string mystr2 = "50";
            //int sum2 = Convert.ToInt32(mystr1) + Convert.ToInt32(mystr2); //конвертация строки в число.

        }
    }
}
