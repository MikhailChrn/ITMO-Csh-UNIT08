using System;
using System.IO;

namespace Задание_01
{
    class Program
    {
        //1.Выберите любую папку на своем компьютере, имеющую вложенные директории
        //Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\Михаил\Desktop\ИТМО\Блок 1";
            string[] Dirs = Directory.GetDirectories(sourceDirectory);

            foreach (string d in Dirs)
            {
                Console.WriteLine(d);
            }

            Console.ReadKey();
        }
    }
}
