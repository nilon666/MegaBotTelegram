using System;

namespace IT_AcademyEducationHomework
{
    public class Lesson4
    {
        public static void Work()
        {
            /*
            Рассчитать выплаты по кредиту
            Рассчитать месячные выплаты(m) и суммарную выплату(s) по кредиту.
            О кредите известно, что он составляет N рублей, берется на Y лет, под P процентов.

            Сумма кредита(руб.) : 1000000
            Период(количество лет) : 20
            Процент: 15
            Ежемесячные выплаты: 13313 руб.
            Всего будет выплачено: 3195230 руб.
            */
            Console.WriteLine("Введите размер кредита:");
            double credit = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите срок кредита (лет):");
            double mount = double.Parse(Console.ReadLine()) * 12;

            Console.WriteLine("Введите размер процентной ставки:");
            double percent = double.Parse(Console.ReadLine());

            // считаем месячную процентную ставку
            double stavka_mount = percent / 12 / 100;

            // считаем размер платежа по основному долгу
            double all_payment = credit / mount;

            // считаем месячные платежи
            double all_credit = 0;
            double all_pay_summ = 0;

            for (int i = 0; i < mount; i++)
            {
                double percent_part = all_payment * stavka_mount;

                credit -= all_payment;
                Console.WriteLine(
                    $"Месяц: {i + 1}, " +
                    $"Оплатить: {Math.Round((all_payment + percent_part), 2)} руб., " +
                    $"Основной долг: {Math.Round(all_payment, 2)} руб., " +
                    $"Проценты: {Math.Round(percent_part, 2)} руб., " +
                    $"Остаток долга: {Math.Round(credit, 2)} руб.");

                //Подсчет итоговой суммы и переплаты по кредиту
                all_credit += all_payment + percent_part;
                all_pay_summ += percent_part;
            }

            Console.WriteLine($"Итоговая сумма: {all_credit}");
            Console.WriteLine($"Сумма по процентам: {all_pay_summ}");

            Console.ReadLine();
        }
    }
}