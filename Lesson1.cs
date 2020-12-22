using System;

namespace IT_AcademyEducationHomework
{
    public class Lesson1
    {
        /*
        В коде приложения реализовать
        a. 3 примера явного преобразования типов
        b. 3 примера неявного преобразования типов
        c. 1 пример операции упаковки
        d. 1 пример операции распаковки
        */
        public static void Work()
        {
            // явное преобразование
            double dy_num = 12.5;
            float fy_num = (float)dy_num;

            string sy_desc = "16";
            int iy_num = int.Parse(sy_desc);

            float fy_num1 = 12.88F;
            double dy_num1 = Convert.ToDouble(fy_num1);

            Console.WriteLine($"float - {fy_num}, int - {iy_num}, double - {dy_num1}");

            // неявное преобразование
            byte bn_num = 14;
            short sn_num = bn_num;
            int in_num = bn_num;
            long ln_num = bn_num;

            Console.WriteLine($"byte - {bn_num}, short - {sn_num}, int - {in_num}, long - {ln_num}");

            // упаковка
            short su_num = 32;
            object ou_num = su_num;

            Console.WriteLine($"short - {su_num}, object - {ou_num}");

            // распаковка
            short su_num1 = 45;
            object ou_num1 = su_num1;
            short su_num2 = (short)ou_num1;
            Console.WriteLine($"short - {su_num1}, object - {ou_num1}, short - {su_num2}");

            Console.ReadLine();  
        }
    }
}