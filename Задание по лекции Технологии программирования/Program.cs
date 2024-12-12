using System;

namespace LectureHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ZhEK zhEK = new ZhEK();
            string command;

            do
            {
                Console.WriteLine("Введите команду (add/exit):");
                command = Console.ReadLine();
                if (command.ToLower() == "add")
                {
                    zhEK.AddResident();
                }
            } while (command.ToLower() != "exit");

            zhEK.ProcessQueue();
        }
    }
}