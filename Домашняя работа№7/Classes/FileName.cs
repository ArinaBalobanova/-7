using System;

namespace Домашняя_работа_7.Classes
{
    class FileName
    {
        public static string GetFileName()
        {
            Console.Write("Введите имя файла: ");
            return Console.ReadLine();
        }

        public static bool FileExists(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл не найден. Программа завершает работу.");
                return false;
            }
            return true;
        }
        public static string ReadFileContent(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        public static string ConvertToUpper(string content)
        {
            return content.ToUpper();
        }
        public static void WriteToFile(string outputFileName, string content)
        {
            File.WriteAllText(outputFileName, content);
        }

    }
}
