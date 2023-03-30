/*
Операторы do-while и while позволяют выполнять итерацию блока кода, которая прерывается логикой внутри блока кода.

Предположим, необходимо принимать и обрабатывать вводимые пользователем данные. Этот процесс должен продолжаться до тех пор, пока пользователь не нажмет клавишу q (quit, выход)

Что такое оператор do-while?

    do
    {
        // This code executes at least one time
    } while (true)

Шаг 1. Написание оператора do-while для прерывания цикла при генерировании определенного случайного числа
    Random random = new Random();
    int current = 0;

    do
    {
        current = random.Next(1, 11);
        Console.WriteLine(current);
    } while (current != 7);

Шаг 2. Написание оператора while, который продолжает выполняться, пока случайное число больше определенного значения

    Random random = new Random();
    int current = random.Next(1, 11);

    while (current >= 3)
    {
        Console.WriteLine(current);
        current = random.Next(1, 11);
    }
    Console.WriteLine($"Last number: {current}");

Шаг 3. Использование оператора continue для перехода непосредственно к вычислению логического выражения

    Random random = new Random();
    int current = random.Next(1, 11);

    do
    {
        current = random.Next(1, 11);

        if (current >= 8) continue;

        Console.WriteLine(current);
    } while (current != 7);

Резюме

Из этого урока следует запомнить ряд основных моментов:

    Оператор do-while выполняет итерацию блока кода по крайней мере один раз. Итерации могут продолжаться, пока логическое выражение дает определенный результат. Результат логического выражения обычно зависит от какого-либо значения, генерируемого или получаемого внутри блока кода.
    Оператор while сначала вычисляет логическое выражение и продолжает итерации блока кода, пока значение выражения равно true.
    Ключевое слово continue позволяет перейти непосредственно к вычислению логического выражения.

Задача

Реализуйте описанные ниже правила игры.

Игровые правила

    Изначально герой и монстр имеют по 10 очков здоровья.
    При атаке наносится урон от 1 до 10.
    Первым атакует герой.
    На экран выводится урон, нанесенный монстру, и оставшееся количество его очков здоровья.
    Если уровень здоровья монстра больше нуля, он может атаковать героя.
    На экран выводится урон, нанесенный герою, и оставшееся количество его очков здоровья.
    Последовательность атак продолжается до тех пор, пока уровень здоровья монстра или героя не станет меньше нуля или равен ему.
    На экран выводится победитель.


    int hero = 10;
    int monster = 10;

    Random dice = new Random();

    do
    {
        int roll = dice.Next(1, 11);
        monster -= roll;
        Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

        if (monster <= 0) continue;

        roll = dice.Next(1, 11);
        hero -= roll;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

    } while (hero > 0 && monster > 0);

    Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

*/
