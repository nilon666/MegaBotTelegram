using System;

namespace IT_AcademyEducationHomework
{
    public class Lesson5
    {
        public static void Work()
        {
            /*
            Самое длинное слово в строке и количество слов в строке
            Вводится строка слов, разделенных пробелами.
            Найти самое длинное слово и вывести его на экран.
            Случай, когда самых длинных слов может быть несколько, не обрабатывать.

            Первый варинат не использовать какие либо методы из string
            */

            Console.WriteLine("Введите строку с несколькими словами:");
            string inputString = Console.ReadLine();

            // ЗАДАНИЕ 1 - ВАРИАНТ 1
            int countSlov = 1;

            //считаем сколько слов
            foreach (var item in inputString)
                if (item == ' ')
                    countSlov++;

            //в первом варианте нельзя использовать Split, поэтому вручную разбиваем строку на слова
            string[] arraySlov = new string[countSlov];
            string slovo = null;
            int f = 0;

            foreach (var item in inputString)
            {
                if (item != ' ')
                {
                    slovo += item;
                }
                else if (item == ' ')
                {
                    arraySlov[f] = slovo;
                    slovo = null;
                    f++;
                }
            }

            arraySlov[arraySlov.Length - 1] = slovo;

            //ищем самое длинное слово
            int indexMaxSlovo = 0;
            int lenghtMaxSlovo = arraySlov[0].Length;

            for (int i = 0; i < arraySlov.Length; i++)
            {
                if (arraySlov[i].Length > lenghtMaxSlovo)
                {
                    indexMaxSlovo = i;
                    lenghtMaxSlovo = arraySlov[i].Length;
                }
            }

            Console.WriteLine($"Самое длинное слово: {arraySlov[indexMaxSlovo]}");

            /*
            ЗАДАНИЕ 1 - ВАРИАНТ 2
            Второй варинт решить задачу с использованием встроенных в .NET
            методов описанных в файле Strings.cs
            */

            //разбиваем строку на массив строк по пробелу
            string[] massSlov = inputString.Split(' ');

            //ищем самое длинное слово
            indexMaxSlovo = 0;
            lenghtMaxSlovo = massSlov[0].Length;

            for (int i = 0; i < massSlov.Length; i++)
            {
                if (massSlov[i].Length > lenghtMaxSlovo)
                {
                    indexMaxSlovo = i;
                    lenghtMaxSlovo = massSlov[i].Length;
                }
            }

            Console.WriteLine($"Самое длинное слово: {massSlov[indexMaxSlovo]}");

            /*
            ЗАДАНИЕ 2
            В двумерном массиве в каждой строке все элементы, расположенные после максимального, заменить на 0.
            */

            // заполняем массив
            int[,] mass = new int[5, 5];
            Random random = new Random();

            Console.WriteLine("Исходный двумерный массив:");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    mass[i, j] = random.Next(3, 26);
                    Console.Write($"{mass[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Измененный массив:");
            int maxIndexMass = 0;
            int maxValueMass = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] > maxValueMass)
                    {
                        maxIndexMass = j;
                        maxValueMass = mass[i, j];
                    }
                }

                for (int k = maxIndexMass + 1; k < mass.GetLength(1); k++)
                {
                    mass[i, k] = 0;
                }

                maxIndexMass = 0;
                maxValueMass = 0;
            }

            //выводим массив
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    Console.Write($"{mass[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}