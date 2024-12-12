using System;


namespace Задание.Classes2
{
    class Task
    {
        public string Title { get; private set; }
        public string AssignTo { get; private set; }

        public Task(string title, string assignTo)
        {
            Title = title;
            AssignTo = assignTo;
        }
    }
}
