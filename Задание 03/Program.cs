using System;
using System.IO;

namespace Задание_03
{
    class Program
    {
        //3.Вручную подготовьте текстовый файл с фрагментом текста.
        //Напишите программу, которая выводит статистику по файлу - количество символов,
        //строк и слов в тексте.
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Users\Михаил\Desktop\ИТМО\Блок 1\Занятие 08\text.txt";

            int stringCount = File.ReadAllLines(sourceFile).Length;
            int charCount = File.ReadAllText(sourceFile).Length;
            
            int wordCount = 0;
            int letterCount = 0;
                        
            //Счётчик количества слов (идею почерпнута на форуме)
            using (StreamReader sr = new StreamReader(sourceFile))
            {
                while (sr.EndOfStream != true)
                {
                    char c = Convert.ToChar(sr.Read());
                    if (isLetter(c) == true)
                    {
                        letterCount++;
                    }
                    else //Слово защитывается в случае признака символа "не буква" и перед символом имелися буквы
                    {
                        if (letterCount > 0)
                        {
                            wordCount++;
                            letterCount = 0;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Количество символов в файле составляет: {0}", charCount);
            Console.WriteLine("Количество строк в файле составляет: {0}", stringCount);
            Console.WriteLine("Количество слов в файле составляет: {0}", wordCount);
            Console.ReadKey();
        }
        private static bool isLetter(char ch) //Данный метод проверяет символ на признок соответствия букве
        {
            if (ch >= 'a' && ch <= 'z') return true;
            if (ch >= 'A' && ch <= 'Z') return true;
            if (ch >= 'а' && ch <= 'я') return true;
            if (ch >= 'А' && ch <= 'Я') return true;
            if (ch == 'ё' || ch == 'Ё') return true;

            return false;
        }
    }
}
