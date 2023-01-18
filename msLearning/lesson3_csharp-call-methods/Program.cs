﻿/* 
Что такое библиотека классов .NET?

Вместе с языком программирования C# используется объемная функциональная библиотека классов .NET, с помощью которой вы 
сможете создавать классические и веб-приложения, получать доступ к данным в файлах и в Интернете, выполнять сложные математические операции и 
решать множество других самых разных задач. Чтобы ускорить процесс разработки полнофункциональных приложений, важно научиться 
работать с этой библиотекой.

Библиотека классов .NET — это коллекция из тысяч классов, в которой содержатся десятки тысяч методов. Эти методы созданы 
разработчиками Майкрософт и могут использоваться в ваших приложениях.

Класс представляет собой контейнер для методов. Как правило, в рамках одного класса объединяется набор связанных методов. 
Например, все методы, которые могут обмениваться информацией с окном командной строки, собраны в 
классе System.Console библиотеки классов .NET.

В состав библиотеки классов .NET также входят типы данных.

Что такое пространство имен?

Пространство имен можно рассматривать как "семейство" типов. Класс содержит код, реализующий тип. Сами классы организуются
 в пространства имен, чтобы избежать конфликтов имен. Это связано с тем, что при наличии тысяч классов существует вероятность 
 того, что какие-либо из них будут иметь одинаковые имена. Применение пространства имен позволяет гарантировать, что 
 каждый класс будет иметь уникальное полное имя.

Вызов методов из библиотеки классов .NET

На примере метода Console.WriteLine() вы уже знакомы с основными принципами работы.

    Начните вводить имя класса Console.
    Добавьте символ ., который является оператором доступа к члену.
    Добавьте имя метода WriteLine.
    Добавьте оператор вызова метода, который представляет собой набор круглых скобок ()
    Наконец, добавьте значение, которое метод Console.WriteLine() будет печатать в качестве входного параметра между открывающими и закрывающими круглыми скобками (например, "Hello World!")

В следующем примере генерируется и выводится в консоль случайное число, которое моделирует результат броска кубика:
    Random dice = new Random();
    int roll = dice.Next(1, 7);
    Console.WriteLine(roll);
В первой строке кода создается новый экземпляр класса System.Random из библиотеки классов .NET. Ссылка на этот новый объект 
сохраняется в переменной dice.
Во второй строке кода вызывается метод Next() объекта dice, в который передаются два входных параметра, определяющие минимальную и максимальную величину генерируемого случайного числа. Метод Next() возвращает значение, которое сохраняется в переменной roll.
В третьей строке кода вызывается метод WriteLine(), который выводит значение переменной roll на консоль.

Методы без отслеживания состояния также называются статическими. Они могут работать, не используя хранящиеся в памяти 
значения и не изменяя их. 
    Console.WriteLine() не использует значения, которые хранятся в памяти. 
    Он начинает и завершает работу, не оказывая никакого влияния на текущее состояние приложения.

Mетоды с отслеживанием состояния используют значения, сохраненные в памяти предыдущими, уже выполненными строками кода, 
либо изменяют состояние приложения, обновляя значения или сохраняя в памяти новые. Такие методы также называются 
методами экземпляра.
Экземпляр класса называется объектом. Для создания нового экземпляра класса используется оператор new. 
Обратите внимание на следующую строку кода, в которой создается новый экземпляр класса Random для создания нового объекта 
dice:

    Random dice = new Random();

Оператор new выполняет ряд важных задач.

    Сначала он запрашивает адрес фрагмента памяти компьютера, размера которого достаточно для хранения нового объекта на основе класса Random.
    Он создает новый объект и сохраняет его по указанному адресу в памяти.
    Далее он возвращает адрес в памяти, который можно сохранить в переменной dice.

Некоторые методы сделаны так, что просто выполняют свою функцию и "тихо" завершают работу, то есть не возвращают 
никаких значений. Их называют методами void. Метод может возвращать любой тип данных, в том числе и другой класс. 

    int roll = dice.Next(1, 7);
    Console.WriteLine(roll);
 .....

    int roll1 = dice.Next();
    int roll2 = dice.Next(101);
    int roll3 = dice.Next(50, 101);

    Console.WriteLine($"First roll: {roll1}");
    Console.WriteLine($"Second roll: {roll2}");
    Console.WriteLine($"Third roll: {roll3}");



*/