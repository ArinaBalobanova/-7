using System;

namespace Домашняя_работа_7.Classes
{
    class CheckFormat
    {
        public static void CheckIfIFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine($"Объект {obj} реализует IFormattable.");
            }
            else
            {
                Console.WriteLine($"Объект {obj} не реализует IFormattable.");
            }
        }
        public static void CheckIfIFormattableAS(object obj)
        {
            IFormattable formattableObj = obj as IFormattable;
            if (formattableObj != null)
            {
                Console.WriteLine($"Объект {obj} реализует IFormattable (проверка через as).");
            }
            else
            {
                Console.WriteLine($"Объект {obj} не реализует IFormattable (проверка через as).");
            }
        }
    }
}
