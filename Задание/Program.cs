using System;
using Задание.Classes2;
using static Задание.Classes2.Company;
using static Задание.Classes2.Employee;
using static Задание.Classes2.Task;


namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, содержащую решение следующих задач:
            На совещании у начальства раздавали задачи. Сотрудники фирмы так задолбались, что 
            решили, что будут получать задачи только в том случае, если это их прямое руководство. 
            Все возмущение началось из‐за того, что бухгалтерия решила автоматизировать себе работу, 
            они хотят приходить на работу, нажимать на кнопочку и чтобы все само делалось, а отдел 
            информационных технологий должен сделать эту задачу им. Перейдем к иерархии сотрудников.*/
            Company company = new Company();
            company.InitializeEmployees();
            company.InitializeTasks();
            company.DistributeTasks();
        }
    }
}