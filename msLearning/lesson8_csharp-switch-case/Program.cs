/* Цели обучения

В этом модуле вы:

    Использование конструкции switch-case, чтобы сопоставить переменную или выражение с несколькими возможными результатами.
    Преобразование кода, использующего конструкцию if-elseif-else, в конструкцию switch-case.

Switch лучше использовать в следующих случаях.

    У вас есть одно значение, которое нужно сопоставить со множеством возможных значений.
    При этом для любого соответствия достаточно выполнить лишь несколько строк кода.

Возможно, соответствий будет несколько. Однако C# выбирает первое совпадающее выражение.

    int employeeLevel = 200;
    string employeeName = "John Smith";

    string title = "";

    switch (employeeLevel)
    {
        case 100:
            title = "Junior Associate";
            break;
        case 200:
            title = "Senior Associate";
            break;
        case 300:
            title = "Manager";
            break;
        case 400:
            title = "Senior Manager";
            break;
        default:
            title = "Associate";
            break;
    }

    Console.WriteLine($"{employeeName}, {title}");


Ключевое слово switch определяет назначение блока кода ниже. Рядом с ключевым словом — 
выражение соответствия в круглых скобках (employeeLevel).

Можно выполнить только один раздел switch. Ключевое слово break — это один из нескольких способов завершения раздела switch, оно буквально проистекает из оператора switch. Если вы забыли ключевое слово break (или, возможно, ключевое слово return), компилятор выдаст ошибку.

Если соответствующие метки отсутствуют, будет сопоставлена необязательная метка default. Если метка default не определена, то инструкция switch будет выполнена только при совпадении одного из вариантов.

Метку default необязательно определять после всех остальных вариантов. Однако большинство разработчиков указывают ее последней, так как логически она имеет смысл "по умолчанию" или "последний вариант".

Задача.
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");


    */

