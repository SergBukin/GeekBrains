/* Оператор if состоит из трех частей:

    ключевое слово if;
    Логическое выражение между круглыми скобками ().
    Блок кода, определяемый фигурными скобками { }.

    Random dice = new Random();

    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int total = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

    if (total > 14)
    {
        Console.WriteLine("You win!");
    }

    if (total < 15)
    {
        Console.WriteLine("Sorry, you lose.");
    }

Что такое логическое выражение?
Логическое выражение — это любой код, возвращающий логическое значение true (истина) или false (ложь). Простейшими 
логическими выражениями являются сами значения true и false. Кроме того, логическое выражение может быть 
результатом метода, возвращающего значение true или false. Например, ниже приведен простой пример кода с использованием 
метода string.Contains(), определяющего, содержит ли одна строка другую строку:

    string message = "The quick brown fox jumps over the lazy dog.";
    bool result = message.Contains("dog");
    Console.WriteLine(result);

    if (message.Contains("fox"))
    {
        Console.WriteLine("What does the fox say?");
    }

Добавление еще одного оператора if :

    Random dice = new Random();

    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int total = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }

    if (total >= 15)
    {
        Console.WriteLine("You win!");
    }
    else 
    {
        Console.WriteLine("Sorry, you lose.");
    }

Здесь мы объединяем три логических выражения, чтобы создать одно большое выражение в одной строке кода. Код такого типа 
иногда называют составным условием.

Следующий урок: Упражнение. Использование операторов "else" и "else if".

    Random dice = new Random();

    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int total = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples!  +6 bonus to total!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles!  +2 bonus to total!");
            total += 2;
        }
    }

    if (total >= 16)
    {
        Console.WriteLine("You win a new car!");
    }
    else if (total >= 10)
    {
        Console.WriteLine("You win a new laptop!");
    }
    else if (total == 7)
    {
        Console.WriteLine("You win a trip for two!");
    }
    else
    {
        Console.WriteLine("You win a kitten!");
    }

Операторы if, else и else if позволяют создавать множество взаимоисключающих условий в виде логических 
выражений. Другими словами, когда имеется несколько возможных условий и результатов, а вам нужно получить 
только один исход, используйте столько операторов else if, сколько хотите. Если ни один из операторов 
if и else if не приведет к выполнению условий, будет выполнен итоговый блок кода else. Этот код else 
является необязательным, но всегда должен идти последним.


ЗАДАЧА1:

    Random random = new Random();
    int daysUntilExpiration = random.Next(12);
    int discountPercentage = 0;

    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired.");
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine("Your subscription expires within a day!");
        discountPercentage = 20;
    }
    else if (daysUntilExpiration <= 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
        discountPercentage = 10;
    }
    else if (daysUntilExpiration <= 10)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }

    if (discountPercentage > 0)
    {
        Console.WriteLine($"Renew now and save {discountPercentage}%.");
    }

ЗАДАЧА 2. Admin|Manager.

    string permission = "Admin|Manager";
    int level = 53;

    if (permission.Contains("Admin"))
    {
        if (level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else
        {
            Console.WriteLine("Welcome, Admin user.");
        }
    }
    else if (permission.Contains("Manager"))
    {
        if (level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }


Шаг 2. Удаление фигурных скобок

    bool flag = true;
    if (flag)
    {
        Console.WriteLine(flag);
    }

    OR 

    bool flag = true;
    if (flag)
        Console.WriteLine(flag);

Шаг 3. Удаление символа перевода строки

    bool flag = true;
    if (flag) Console.WriteLine(flag);


Шаг 4. Указание инструкций else if и else без блоков кода

    string name = "steve";
    if (name == "bob") Console.WriteLine("Found Bob");
    else if (name == "steve") Console.WriteLine("Found Steve");
    else Console.WriteLine("Found Chuck");

Эти строки кода смотрятся слишком плотно расположенными и трудными для восприятия. 

    string name = "steve";

    if (name == "bob")
        Console.WriteLine("Found Bob");
    else if (name == "steve") 
        Console.WriteLine("Found Steve");
    else
        Console.WriteLine("Found Chuck");


** Резюме

Ниже приведено несколько важных аспектов, которые необходимо учитывать при работе с блоками кода.

    Если вы понимаете, что блок кода содержит всего одну строку кода, можно удалить фигурные скобки и пробел.
    Удалять блоки кода следует только тогда, когда это делает код более удобочитаемым.
    Удалять символ перевода строки следует только тогда, когда это делает код более удобочитаемым.

ЗАДАЧА 1.

    int[] numbers = { 4, 8, 15, 16, 23, 42 };
    int total = 0;
    bool found = false;

    foreach (int number in numbers)
    {
        total += number;
        if (number == 42) found = true;
    }

    if (found) Console.WriteLine("Set contains 42");

    Console.WriteLine($"Total: {total}");

Задача3
Условия FizzBuzz:

    Необходимо вывести значения от 1 до 100, по одному в каждой строке.
    Если текущее значение делится на 3, рядом с числом выводится слово Fizz.
    Если текущее значение делится на 5, рядом с числом выводится слово Buzz.
    Если текущее значение делится как на 3, так и на 5, рядом с числом выводится слово FizzBuzz.


    for (int i = 1; i < 101; i++)
    {
        if ((i % 3 == 0) && (i % 5 == 0))
            Console.WriteLine($"{i} - FizzBuzz");
        else if (i % 3 == 0)
            Console.WriteLine($"{i} - Fizz");
        else if (i % 5 == 0)
            Console.WriteLine($"{i} - Buzz");
        else
            Console.WriteLine($"{i}");
    }



    */
    int[] numbers = { 4, 8, 15, 16, 23, 42 };
    int total = 0;
    bool found = false;

    foreach (int number in numbers)
    {
        total += number;
        if (number == 42) found = true;
    }

    if (found) Console.WriteLine("Set contains 42");

    Console.WriteLine($"Total: {total}");