using System;

namespace Задание_по_лекции_ТП.Classes
{
    class Issue
    {
        public int IssueNumber { get; set; }
        public string Description { get; set; }

        public Issue(int issueNumber, string description)
        {
            IssueNumber = issueNumber;
            Description = description;
        }
    }
}
