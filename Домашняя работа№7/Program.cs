using System;
using static Домашняя_работа_7.Classes.BankAccount;
using static Домашняя_работа_7.Classes.ReverseStringProgram;
using static Домашняя_работа_7.Classes.CheckFormat;

using Домашняя_работа_7.Classes;
using System.Diagnostics.Metrics;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        static void Task1()
        {
            /*Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить метод,
            который переводит деньги с одного счета на другой. У метода два параметра: ссылка на объект класса банковский счет
            откуда снимаются деньги, второй параметр – сумма.*/
            Console.WriteLine("Упражнение 8.1");
            BankAccount account1 = new BankAccount(2500, AccType.Current);
            BankAccount account2 = new BankAccount(1000, AccType.Savings);
            Console.WriteLine("Информация о счетах до перевода:");
            account1.PrintAccountInfo();
            account2.PrintAccountInfo();

            account1.Transfer(account2, 500);
            Console.WriteLine("Информация о счетах после перевода:");
            account1.PrintAccountInfo();
            account2.PrintAccountInfo();
        }
        static void Task2()
        {
            /*Упражнение 8.2 Реализовать метод, который в качестве входного параметра принимает строку string,
            возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.*/
            Console.WriteLine("Упражнение 8.2");
            string testString = "Технология программирования";
            string reversedString = ReverseString(testString);

            Console.WriteLine($"Исходная строка: {testString}");
            Console.WriteLine($"Измененная строка: {reversedString}");
        }
        static void Task3()
        {
            /*Упражнение 8.3 Написать программу, которая спрашивает у пользователя имя файла. Если такого файла не существует,
            то программа выдает пользователю сообщение и заканчивает работу, иначе в выходной файл записывается
            содержимое исходного файла, но заглавными буквами.*/
            Console.WriteLine("Упражнение 8.3");
            string inputFileName = FileName.GetFileName();
            if (FileName.FileExists(inputFileName))
            {
                string content = FileName.ReadFileContent(inputFileName);
                string upperContent = FileName.ConvertToUpper(content);
                FileName.WriteToFile("output.txt", upperContent);
                Console.WriteLine("Содержимое файла было успешно записано в 'output.txt' в заглавных буквах.");
            }
        }
        static void Task4()
        {
            /*Упражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр метода интерфейс System.
            IFormattable. Использовать оператор is и as. (Интерфейс IFormattable обеспечивает функциональные возможности
            форматирования значения объекта в строковое представление.)*/
            Console.WriteLine("Упражнение 8.4");
            object a = 123;  
            object b = 3.14f; 
            object c = "Hello";
            object d = DateTime.Now;
            Console.WriteLine("Проверка через оператор IS: ");
            CheckFormat.CheckIfIFormattable(a);
            CheckFormat.CheckIfIFormattable(b);
            CheckFormat.CheckIfIFormattable(c);
            CheckFormat.CheckIfIFormattable(d);
            Console.WriteLine("Проверка через оператор AS: ");
            CheckFormat.CheckIfIFormattableAS(a);
            CheckFormat.CheckIfIFormattableAS(b);
            CheckFormat.CheckIfIFormattableAS(c);
            CheckFormat.CheckIfIFormattableAS(d);
        }
        static void Task5()
        {
            /*Домашнее задание 8.2 Список песен. В методе Main создать список из четырех песен. В цикле вывести информацию
            о каждой песне. Сравнить между собой первую и вторую песню в списке. Песня представляет собой класс с методами
            для заполнения каждого из полей, методом вывода данных о песне на печать, методом, который сравнивает между собой два объекта. */
            Console.WriteLine("Домашнеее задание 8.2");
            List<Song> songs = new List<Song>();
            Song song1 = new Song();
            song1.SetName("Espresso");
            song1.SetAuthor("Sabrina Carpenter");

            Song song2 = new Song();
            song2.SetName("APT");
            song2.SetAuthor("Rose ft. Bruno Mars");

            Song song3 = new Song();
            song3.SetName("Rockstar");
            song3.SetAuthor("Lisa");

            Song song4 = new Song();
            song4.SetName("Solo");
            song4.SetAuthor("Jenny Kim");

            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);

            foreach (Song song in songs)
            {
                Console.WriteLine(song.Title());
            }
            if (song1.Equals(song2))
            {
                Console.WriteLine("Первая и вторая песни одинаковые.");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни разные.");
            }
        }

    }
}