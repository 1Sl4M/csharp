using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HWModule16
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Просмотр содержимого директории");
                Console.WriteLine("2. Создание файла/директории");
                Console.WriteLine("3. Удаление файла/директории");
                Console.WriteLine("4. Копирование файла/директории");
                Console.WriteLine("5. Перемещение файла/директории");
                Console.WriteLine("6. Чтение из файла");
                Console.WriteLine("7. Запись в файл");
                Console.WriteLine("8. Логирование действий");
                Console.WriteLine("9. Выход");

                Console.Write("Выберите действие (введите соответствующую цифру): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowDirectoryContents();
                        break;
                    case "2":
                        CreateFileOrDirectory();
                        break;
                    case "3":
                        DeleteFileOrDirectory();
                        break;
                    case "4":
                        CopyFileOrDirectory();
                        break;
                    case "5":
                        MoveFileOrDirectory();
                        break;
                    case "6":
                        ReadFromFile();
                        break;
                    case "7":
                        WriteToFile();
                        break;
                    case "8":
                        LogActions();
                        break;
                    case "9":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        break;
                }

                Console.WriteLine("\n--------------------------------\n");
            }
        }

        static void ShowDirectoryContents()
        {
            Console.Write("Введите путь к директории: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                Console.WriteLine($"Содержимое директории {path}:\n");

                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);

                Console.WriteLine("Файлы:");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("\nДиректории:");
                foreach (var directory in directories)
                {
                    Console.WriteLine(directory);
                }
            }
            else
            {
                Console.WriteLine("Директория не существует.");
            }
        }

        static void CreateFileOrDirectory()
        {
            Console.Write("Введите путь: ");
            string path = Console.ReadLine();

            Console.Write("Выберите тип (1 - файл, 2 - директория): ");
            string typeChoice = Console.ReadLine();

            if (typeChoice == "1")
            {
                File.Create(path);
                Console.WriteLine($"Файл создан по пути {path}.");
            }
            else if (typeChoice == "2")
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Директория создана по пути {path}.");
            }
            else
            {
                Console.WriteLine("Некорректный выбор типа.");
            }
        }

        static void DeleteFileOrDirectory()
        {
            Console.Write("Введите путь: ");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"Файл по пути {path} удален.");
            }
            else if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine($"Директория по пути {path} удалена.");
            }
            else
            {
                Console.WriteLine("Файл или директория не существует.");
            }
        }

        static void CopyFileOrDirectory()
        {
            Console.Write("Введите путь к исходному файлу/директории: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Введите путь к новому файлу/директории: ");
            string destinationPath = Console.ReadLine();

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath);
                Console.WriteLine($"Файл скопирован из {sourcePath} в {destinationPath}.");
            }
            else if (Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(destinationPath);
                CopyDirectory(sourcePath, destinationPath);
                Console.WriteLine($"Директория скопирована из {sourcePath} в {destinationPath}.");
            }
            else
            {
                Console.WriteLine("Файл или директория не существует.");
            }
        }

        static void CopyDirectory(string sourceDir, string destDir)
        {
            foreach (string file in Directory.GetFiles(sourceDir, "*.*"))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
                CopyDirectory(subDir, destSubDir);
            }
        }

        static void MoveFileOrDirectory()
        {
            Console.Write("Введите путь к исходному файлу/директории: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Введите путь к новому файлу/директории: ");
            string destinationPath = Console.ReadLine();

            if (File.Exists(sourcePath))
            {
                File.Move(sourcePath, destinationPath);
                Console.WriteLine($"Файл перемещен из {sourcePath} в {destinationPath}.");
            }
            else if (Directory.Exists(sourcePath))
            {
                Directory.Move(sourcePath, destinationPath);
                Console.WriteLine($"Директория перемещена из {sourcePath} в {destinationPath}.");
            }
            else
            {
                Console.WriteLine("Файл или директория не существует.");
            }
        }

        static void ReadFromFile()
        {
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine($"Содержимое файла {filePath}:\n{content}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }

        static void WriteToFile()
        {
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            Console.Write("Введите текст для записи в файл: ");
            string content = Console.ReadLine();

            try
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine($"Текст успешно записан в файл {filePath}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
            }
        }

        static void LogActions()
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true)) { writer.WriteLine("Логируемое действие"); }
            Console.WriteLine("Логирование действий...");
        }
    }

}
