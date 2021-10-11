using System;
using System.IO;

namespace Задание_02
{
    class Program
    {
        //2.Программно создайте текстовый файл и запишите в него 10 случайных чисел.
        //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем,
        //ответ выведите на консоль.
        static void Main(string[] args)
        {
            const byte n = 10;
            string sourceFile = @"C:\Users\Михаил\Desktop\ИТМО\Блок 1\Занятие 08\test.txt";

            if (!File.Exists(sourceFile)) //Если файл ещё не создан, то создаём заново
            {
                File.Create(sourceFile);
            }

            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(sourceFile, true))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(random.Next(-100, 100));
                }
            }
        }
    }
}
