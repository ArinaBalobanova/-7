using System;

namespace Задание.Classes2
{
    class Company
    {
        private List<Employee> employees;
        private List<Task> tasks;

        public void InitializeEmployees()
        {
            Employee timur = new Employee("Тимур", "Генеральный директор");
            Employee rashid = new Employee("Рашид", "Финансовый директор", timur);
            Employee ilham = new Employee("Ильхам", "Директор по автоматизации", timur);
            Employee lucas = new Employee("Лукас", "Главный бухгалтер", rashid);
            Employee orkadiy = new Employee("Оркадий", "Начальник отдела ИТ", ilham);
            Employee volodya = new Employee("Володя", "Заместитель начальника отдела ИТ", ilham);

            Employee sysLead = new Employee("Ильшат", "Главный системщик", orkadiy);
            Employee sysDeputy = new Employee("Иваныч", "Заместитель системщика", sysLead);

            List<Employee> sysEmployees = new List<Employee>
        {
            new Employee("Илья", "Системщик", sysLead),
            new Employee("Витя", "Системщик", sysLead),
            new Employee("Женя", "Системщик", sysLead)
        };

            Employee devLead = new Employee("Сергей", "Главный разработчик", orkadiy);
            Employee devDeputy = new Employee("Ляйсан", "Заместитель разработчика", devLead);

            List<Employee> devEmployees = new List<Employee>
        {
            new Employee("Марат", "Разработчик", devLead),
            new Employee("Дина", "Разработчик", devLead),
            new Employee("Ильдар", "Разработчик", devLead),
            new Employee("Антон", "Разработчик", devLead)
        };

            employees = new List<Employee> { timur, rashid, ilham, lucas, orkadiy, volodya, sysLead, sysDeputy, devLead, devDeputy };
            employees.AddRange(sysEmployees);
            employees.AddRange(devEmployees);
        }

        public void InitializeTasks()
        {
            tasks = new List<Task> {
            new Task("Автоматизация отчетности", "Системщики"),
            new Task("Разработка нового модуля", "Разработчики"),
            new Task("Финансовый анализ", "Начальство")
        };
        }

        public void DistributeTasks()
        {
            foreach (Task task in tasks)
            {
                DistributeTask(task);
            }
        }

        private void DistributeTask(Task task)
        {
            List<Employee> targetGroup = GetTargetGroup(task.AssignTo);
            foreach (Employee employee in targetGroup)
            {
                bool takesTask = employee.CanTakeTask(task.AssignTo);
                Console.WriteLine($"{employee.Name} ({employee.Position}) - Задача: \"{task.Title}\" - берет задачу: {(takesTask ? "Да" : "Нет")}");
            }
            Console.WriteLine();
        }

        private List<Employee> GetTargetGroup(string assignTo)
        {
            List<Employee> targetGroup = new List<Employee>();
            if (assignTo == "Системщики")
                targetGroup.AddRange(employees.FindAll(emp => emp.Position.Contains("Системщик")));
            if (assignTo == "Разработчики")
                targetGroup.AddRange(employees.FindAll(emp => emp.Position.Contains("Разработчик")));
            if (assignTo == "Начальство")
                targetGroup.AddRange(employees.FindAll(emp => emp.Position.Contains("Начальник") || emp.Position.Contains("Заместитель")));

            return targetGroup;
        }


    }
}
