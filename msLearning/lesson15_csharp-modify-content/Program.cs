/*
Упражнение. Использование вспомогательных методов IndexOf() и Substring() строки?

    string message = "Find what is (inside the parentheses)";

    int openingPosition = message.IndexOf('(');
    int closingPosition = message.IndexOf(')');

    Console.WriteLine(openingPosition);
    Console.WriteLine(closingPosition);

Шаг 2. Добавление кода для извлечения значения между двумя символами скобки?

Шаг 2. Добавление кода для извлечения значения между двумя символами скобки


string message = "Find what is (inside the parentheses)";

    int openingPosition = message.IndexOf('(');
    int closingPosition = message.IndexOf(')');

    // Console.WriteLine(openingPosition);
    // Console.WriteLine(closingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

В следующем фрагменте кода показано, как найти значение внутри открывающего и закрывающего тега <span>.

    string message = "What is the value <span>between the tags</span>?";

    int openingPosition = message.IndexOf("<span>");
    int closingPosition = message.IndexOf("</span>");

    openingPosition += 6;
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
__________________________________________________________________________________________
    string message = "(What if) I am (only interested) in the last (set of parentheses)?";
    int openingPosition = message.LastIndexOf('(');

    openingPosition += 1;
    int closingPosition = message.LastIndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));


Избегание магических значений?
Кроме того, если вы измените строку "<span>" на "<div>", но забудете изменить число 6, код выдаст нежелательные результаты.

Вместо этого следует использовать константу с ключевым словом const. Константа позволяет определить и инициализировать переменную, значение которой никогда не изменяется. 

    string message = "What is the value <span>between the tags</span>?";

    const string openSpan = "<span>";
    const string closeSpan = "</span>";

    int openingPosition = message.IndexOf(openSpan);
    int closingPosition = message.IndexOf(closeSpan);

    openingPosition += openSpan.Length;
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

Шаг 5. Изменение примера кода для извлечения любого значения между одним или несколькими наборами круглых скобок в строке?

    string message = "(What if) there are (more than) one (set of parentheses)?";
    while (true)
    {
        int openingPosition = message.IndexOf('(');
        if (openingPosition == -1) break;

        openingPosition += 1;
        int closingPosition = message.IndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));

        // Note how we use the overload of Substring to return only the remaining 
        // unprocessed message:
        message = message.Substring(closingPosition + 1);
    }

В этом уроке мы рассмотрели важные вопросы. Ниже приведены наиболее важные моменты, которые следует запомнить.

    IndexOf() предоставляет первую позицию символа или строки внутри другой строки.
    IndexOf() возвращает -1, если не удается найти совпадение.
    Substring() возвращает только указанную часть строки с использованием начальной позиции и необязательной длины.
    LastIndexOf() возвращает последнюю позицию символа или строки внутри другой строки.
    IndexOfAny() возвращает первую позицию любого символа из массива char, который находится внутри строки.
    Часто проблему можно решить сразу несколькими способами. Мы использовали две отдельных методики для поиска всех экземпляров заданного символа или строки.
    Избегайте жестко заданных магических значений. Вместо этого определите переменную const. Значение константной переменной невозможно изменить после инициализации.

Упражнение. Использование методов Remove() и Replace()?

Шаг 1. Написание кода для удаления символов из определенных расположений в строке

Если из строки требуется удалить символы со стандартной и последовательной позицией, обычно применяется Remove().

    string data = "12345John Smith          5000  3  ";
    string updatedData = data.Remove(5, 20);
    Console.WriteLine(updatedData);

Шаг 2. Написание кода для удаления символов вне зависимости от того, в каком месте строки они находятся


    string message = "This--is--ex-amp-le--da-ta";
    message = message.Replace("--", " ");
    message = message.Replace("-", "");
    Console.WriteLine(message);

Ниже приведены наиболее важные моменты, которые следует запомнить из этого урока.

    Метод Remove() работает как метод Substring(), за исключением того, что он удаляет указанные символы из строки.
    Метод Replace() заменяет все экземпляры строки новой строкой.

Задача
Завершено XP: 100

    10 мин

Дополнительные задания в этих модулях помогут вам закрепить изученный материал и подготовиться к дальнейшей работе.


    const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

    string quantity = "";
    string output = "";

    // Your work here

    const string spanTag = "<span>";

    // Extract the quantity
    int quantityStart = input.IndexOf(spanTag);
    int quantityEnd = input.IndexOf("</span>");
    quantityStart += spanTag.Length;
    int quantityLength = quantityEnd - quantityStart;
    quantity = input.Substring(quantityStart, quantityLength);

    // Set output to input, replacing the trademark symbol with the registered trademark symbol
    output = input.Replace("&trade;", "&reg;");

    // Remove the opening <div> tag
    int divStart = input.IndexOf("<div");
    int divEnd = input.IndexOf(">");
    int divLength = divEnd - divStart;
    divLength += 1;
    output = output.Remove(divStart, divLength);

    // Remove the closing <div> tag
    int divCloseStart = output.IndexOf("</div");
    int divCloseEnd = output.IndexOf(">", divCloseStart);
    int divCloseLength = divCloseEnd - divCloseStart;
    divCloseLength += 1;
    output = output.Remove(divCloseStart, divCloseLength);

    Console.WriteLine($"Quantity: {quantity}");
    Console.WriteLine($"Output: {output}");




*/


