using System;

namespace Задание_по_лекции_ТП.Classes
{
    class Temperament
    {
        public int Scandalousness { get; set; }
        public int Intelligence { get; set; }
        public Temperament(int scandalousness, int intelligence)
        {
            Scandalousness = scandalousness;
            Intelligence = intelligence;
        }
    }
}
