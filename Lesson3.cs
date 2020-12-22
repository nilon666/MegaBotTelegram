using System;

namespace IT_AcademyEducationHomework
{
    public class Lesson3
    {
        public static void Work()
        {
            /*
                задание 1
                Посчитать сумму n-членов арифметической прогрессии. Для
                вычисления an нужно взять алгоритм, который писали на занятии. Он
                если в примерах кода в папке к 3-му заданию
            */

            Console.WriteLine(new string('#', 20));
            Console.WriteLine("Задание 1");
            Console.WriteLine(new string('#', 20));

            Console.WriteLine("Введите первый член прогрессии а1:");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер последнего члена n:");
            int n = int.Parse(Console.ReadLine());

            if (a1 < n)
            {
                double summ = 0;
                summ = n * ((a1 + n) / 2);

                Console.WriteLine($"Cумма n-членов арифметической прогрессии :{summ}");
            }
            else
            {
                Console.WriteLine("Последний член n должен быть больше первого члена a1");
            }

            Console.WriteLine(new string('#', 20));

            /*
                задание 2
                Дописать пример по подсчёту скидки с занятие чтобы зацикливался
                ввод данных, и программа ожидала только число.
            */

            Console.WriteLine(new string('#', 20));
            Console.WriteLine("Задание 2");
            Console.WriteLine(new string('#', 20));

            int cost_num;
            while (true)
            {
                Console.WriteLine("Введите цену товара:");
                string cost = Console.ReadLine();

                if (!int.TryParse(cost, out cost_num))
                    Console.WriteLine("Вы ввели не целое число, повторите ввод!");
                else break;

            }


            int count_num;
            while (true)
            {
                Console.WriteLine("Введите количество товара:");
                string count = Console.ReadLine();

                if (!int.TryParse(count, out count_num))
                    Console.WriteLine("Вы ввели не целое число, повторите ввод!");
                else break;
            }

            double sp = count_num * cost_num;
            double discount = 0;

            if (count_num > 100)
            {
                discount = 0.1;
            }
            else if (count_num > 50)
            {
                discount = 0.05;
            }

            sp -= sp * discount;

            Console.WriteLine($"К оплате: {sp}");


            /*
                задание 3
                Написать программу, которая вычисляет сумму и произведение числа.
                Предусмотреть случаи, когда пользователь вводить не число. Не нужно
                зацикливать программу чтобы он ввел число просто аккуратно
                обработать и выдать сообщение – “Вы ввели не число”

                Пример:
                Вводим – 456
                Выводим – сумма 15 (4 + 5 + 6), произведение – 120 (4 * 5 * 6)
            */
            Console.WriteLine(new string('#', 20));
            Console.WriteLine("Задание 3");
            Console.WriteLine(new string('#', 20));

            int e_num;

            Console.WriteLine("Введите целое число:");
            string c_num = Console.ReadLine();

            int summa_num = 0;
            int mult_num = 1;

            if (int.TryParse(c_num, out e_num))
            {
                string s_num = e_num.ToString();

                foreach (var item in s_num)
                {
                    summa_num += int.Parse(item.ToString());
                    mult_num *= int.Parse(item.ToString());
                }

                Console.WriteLine($"Вы ввели число {e_num}, сумма чисел: {summa_num}, произведение чисел: {mult_num}");
            }
            else
            {
                Console.WriteLine("Вы ввели не целое число");
            }

            Console.ReadLine();
        }
    }
}