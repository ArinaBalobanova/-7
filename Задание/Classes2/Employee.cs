using System;


namespace Задание.Classes2
{
    class Employee
    {
        public string Name { get; private set; }
        public string Position { get; private set; }
        public Employee Manager { get; private set; }
        public Employee(string name, string position, Employee manager = null)
        {
            Name = name;
            Position = position;
            Manager = manager;
        }
        public bool CanTakeTask(string assignTo)
        {
            if (assignTo == "Системщики" && (Position.Contains("Системщик") || Position.Contains("Заместитель") || Position.Contains("Главный")))
                return true;
            if (assignTo == "Разработчики" && (Position.Contains("Разработчик") || Position.Contains("Заместитель") || Position.Contains("Главный")))
                return true;
            if (assignTo == "Начальство" && (Position.Contains("Начальник") || Position.Contains("Заместитель")))
                return true;

            return false;
        }
    }
}
