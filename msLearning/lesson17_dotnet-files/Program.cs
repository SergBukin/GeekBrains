/*
Цели обучения

К концу этого модуля вы научитесь выполнять следующие задачи:

    работать с каталогами;
    создавать и удалять файлы;
    выполнять чтение из файлов;
    выполнять запись в файлы;
    анализировать данные в файлах.

.NET содержит встроенные типы для работы с файловой системой, расположенные в пространстве имен System.IO.

Пока мы сосредоточимся лишь на том, что нужно знать для работы с каталогами с помощью класса 
Directory из пространства имен System.IO. Класс Directory предоставляет статические методы для 
создания, перемещения и перечисления элементов в каталогах и вложенных каталогах.

1) Для чтения и перечисления имен каталогов верхнего уровня используйте
функцию Directory.EnumerateDirectories.

    IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");

    foreach (var dir in listOfDirectories) {
        Console.WriteLine(dir);
    }

    // Outputs:
    // stores/201
    // stores/202

2) Получение списка файлов в указанном каталоге

Для получения списка имен всех файлов в каталоге можно использовать функцию Directory.EnumerateFiles.

IEnumerable<string> files = Directory.EnumerateFiles("stores");

foreach (var file in files)
{
    Console.WriteLine(file);
}

// Outputs:
// stores/totals.txt
// stores/sales.json

3) Получение списка всего содержимого в каталоге и всех подкаталогах

Функции Directory.EnumerateDirectories и Directory.EnumerateFiles имеют перегрузку, которая принимает параметр для указания шаблонов поиска файлов и каталогов.

    // Find all *.txt files in the stores folder and its subfolders
    IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

    foreach (var file in allFilesInAllFolders)
    {
        Console.WriteLine(file);
    }

    // Outputs:
    // stores/totals.txt
    // stores/201/inventory.txt



*/


