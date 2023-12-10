using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule16
{
    class Program
    {
        static string directoryPath;
        static string logFilePath;

        static void Main()
        {
            Console.WriteLine("Welcome!");

            Console.Write("Введите путь к отслеживаемой директории: ");
            directoryPath = Console.ReadLine();

            Console.Write("Введите путь к лог-файлу: ");
            logFilePath = Console.ReadLine();

            try
            {
                using (var watcher = new FileSystemWatcher(directoryPath))
                {
                    watcher.IncludeSubdirectories = true;

                    watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                    watcher.Changed += OnChanged;
                    watcher.Created += OnChanged;
                    watcher.Deleted += OnChanged;
                    watcher.Renamed += OnRenamed;

                    watcher.EnableRaisingEvents = true;

                    Console.WriteLine($"Мониторинг директории {directoryPath} начат. Для остановки нажмите любую клавишу.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Log($"Изменение: {e.ChangeType} - {e.FullPath}");
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Log($"Переименование: {e.OldFullPath} -> {e.FullPath}");
        }

        private static void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now} - {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в лог-файл: {ex.Message}");
            }
        }
    }
}
