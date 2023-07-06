using System.IO;


    string path = "C:\\Users\\Polinka\\Desktop\\ДЗ1";
    Console.WriteLine("Текущая директория: " + path);

while (true)
{

    Console.Write("Введите название папки для перехода(или 'выход' для завершения): ");
    string nameDirectory = Console.ReadLine();

    if (nameDirectory == "выход")
    {
        break;
    }

    string newDirectory = Path.Combine(path, nameDirectory);

    if (Directory.Exists(newDirectory))
    {
        path = newDirectory;
        Directory.SetCurrentDirectory(path);
        Console.WriteLine("Текущая директория: " + path);
        
    }
    else
    {
        Console.WriteLine("Папка не найдена.");
    }
}