using System;

namespace IT_AcademyEducationHomework
{
    public class Lesson6
    {
        public static void Work()
        {
            /*
            ЗАДАНИЕ 1

            Создать класс с именем Rectangle.
            В теле класса создать два поля, описывающие длины сторон double side1, side2.   
            Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
            Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().  
            Создать два свойства double Area и double Perimeter с одним методом доступа get.
            Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
            */

            Console.WriteLine("Введите длинну прямоугольника:");
            double longRect = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника:");
            double longWidth = double.Parse(Console.ReadLine());

            Rectangle RectItem = new Rectangle(longRect, longWidth);
            Console.WriteLine($"Площадь прямоугольника: {RectItem.Area}");
            Console.WriteLine($"Периметр прямоугольника: {RectItem.Perimeter}");

            /*
            ЗАДАНИЕ 2
            Создать класс Book.Создать классы  Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().  
            Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
            Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
            Как вывести разными цветами на консоль - загуглите!
            */
            Book book = new Book("Вино из одуванчиков", "Рэй Брэдбери",
                "Действие происходит летом 1928 года в вымышленном городе Гринтауне, штат Иллинойс, прототипом которого является родной город Брэдбери — Уокиган.");
            book.Show();

            Console.ReadLine();
        }
    }

    class Rectangle
    {
        private double _side1, _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        private double AreaCalculator()
        {
            return _side1 * _side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }
    }

    class Book
    {
        private Title _stringTitle;
        private Author _stringAuthor;
        private Content _stringContent;

        public Book(string title, string author, string content)
        {
            _stringTitle = new Title(title);
            _stringAuthor = new Author(author);
            _stringContent = new Content(content);
        }

        public void Show()
        {
            Console.Write($"Название: ");
            _stringTitle.Show();

            Console.Write($" Автор: ");
            _stringAuthor.Show();

            Console.Write($" Описание: ");
            _stringContent.Show();
        }
    }

    class Title
    {
        private string _stringTitle;

        public Title(string stroka)
        {
            _stringTitle = stroka;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(_stringTitle);
            Console.ResetColor();
        }
    }

    class Author
    {
        private string _stringAuthor;

        public Author(string stroka)
        {
            _stringAuthor = stroka;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_stringAuthor);
            Console.ResetColor();
        }
    }

    class Content
    {
        private string _stringContent;

        public Content(string stroka)
        {
            _stringContent = stroka;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(_stringContent);
            Console.ResetColor();
        }
    }
}