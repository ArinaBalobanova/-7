using System;
using Задание_по_лекции_ТП.Classes;

namespace Задание_по_лекции_ТП.Classes
{
    class ZhEK
    {
        private Stack<Resident> residentsQueue = new Stack<Resident>();
        private Queue<Resident> heatingIssues = new Queue<Resident>();
        private Queue<Resident> paymentIssues = new Queue<Resident>();
        private Queue<Resident> otherIssues = new Queue<Resident>();

        public void AddResident()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите номер паспорта:");
            string passportNumber = Console.ReadLine();

            Console.WriteLine("Введите номер проблемы:");
            int issueNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите описание проблемы:");
            string description = Console.ReadLine();

            Console.WriteLine("Введите степень скандальности (0-10):");
            int scandalousness = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите уровень ума (0 - тупой, 1 - умный):");
            int intelligence = int.Parse(Console.ReadLine());

            Issue problem = new Issue(issueNumber, description);
            Temperament temperament = new Temperament(scandalousness, intelligence);
            Resident resident = new Resident(name, passportNumber, problem, temperament);

            residentsQueue.Push(resident);
            Console.WriteLine("Житель добавлен в очередь.");
        }

        public void ProcessQueue()
        {
            while (residentsQueue.Count > 0)
            {
                Resident currentResident = residentsQueue.Pop();
                Console.WriteLine($"{currentResident.Name} подходит к Зине.");
                AssignToWindow(currentResident);
            }
        }

        private void AssignToWindow(Resident resident)
        {
            string assignedWindow = "";
            Random random = new Random();

            if (resident.Temper.Scandalousness >= 5)
            {
                Console.WriteLine($"{resident.Name},сколько человек вам нужно обогнать?");
                int skipCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < skipCount && residentsQueue.Count > 0; i++)
                {
                    residentsQueue.Pop();
                }
            }

            if (resident.Temper.Intelligence == 0)
            {
                int randomWindow = random.Next(1, 4);
                assignedWindow = randomWindow == 1 ? "отопление" : randomWindow == 2 ? "оплата" : "другие проблемы";
                Console.WriteLine($"{resident.Name} заходит в окно: {assignedWindow} (ошибка из-за низких умственных способностях)");
            }
            else
            {
                switch (resident.Problem.IssueNumber)
                {
                    case 1:
                        heatingIssues.Enqueue(resident);
                        assignedWindow = "отопление";
                        break;
                    case 2:
                        paymentIssues.Enqueue(resident);
                        assignedWindow = "оплата";
                        break;
                    default:
                        otherIssues.Enqueue(resident);
                        assignedWindow = "другие проблемы";
                        break;
                }
                Console.WriteLine($"{resident.Name} заходит в окно: {assignedWindow}");
            }
        }
    }
}
