using System;


namespace Задание_по_лекции_ТП.Classes
{
    class Resident
    {
        public string Name { get; set; }
        public string PassportNumber { get; set; }
        public Issue Problem { get; set; }
        public Temperament Temper { get; set; }

        public Resident(string name, string passportNumber, Issue problem, Temperament temper)
        {
            Name = name;
            PassportNumber = passportNumber;
            Problem = problem;
            Temper = temper;
        }
    }
}
