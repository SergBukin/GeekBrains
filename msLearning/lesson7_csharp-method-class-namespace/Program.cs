/* 
Определение методов, классов и пространств имен с помощью блоков кода

    using System;

    namespace MyNewApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }

    Далее представлены три уровня блоков кода, начиная с внутреннего и заканчивая наружным:

    метод Main();
    класс Program;
    пространство имен MyNewApp.

В пространство имен MyNewApp.Business мы бы хотели добавить классы, реализующие бизнес-логику нашего приложения. 
А в пространство имен MyNewApp.Data мы бы хотели добавить классы, реализующие функции доступа к данным нашего 
приложения. 

    namespace MyNewApp.Business
    {
    // Classes here    
    }

    namespace MyNewApp.Data
    {
    // Classes here    
    }

Можно добавить неограниченное количество пространств имен, в которых может быть сколько угодно уровней. 
Добавлять имена дочерних пространств имен можно с помощью оператора ".".


    using System;

    namespace MyNewApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                string value = "Microsoft Learn";
                string reversedValue = Reverse(value);
                Console.WriteLine($"Secret message: {reversedValue}");
            }

            static string Reverse(string message)
            {
                char[] letters = message.ToCharArray();
                Array.Reverse(letters);
                return new string(letters);
            }
        }
    }
Так как метод Reverse() определен в том же классе, коду, вызывающему метод, не требуется уточнять имя метода
 именем класса.

Вызов метода из другого класса

Что, если переместить метод Reverse() в собственный класс? Рассмотрим следующий пример кода.


    using System;

    namespace MyNewApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                string value = "Microsoft Learn";
                string reversedValue = Utility.Reverse(value);
                Console.WriteLine($"Secret message: {reversedValue}");
            }
        }

        class Utility
        {
            public static string Reverse(string message)
            {
                char[] letters = message.ToCharArray();
                Array.Reverse(letters);
                return new string(letters);
            }
        }
    }

Здесь мы определяем класс Utility и добавляем метод Reverse(). Мы также добавляем ключевое слово public. 
В противном случае метод будет недоступен для метода Main() класса Program. Без ключевого слова public мы 
увидим ошибку компиляции.

Теперь обратите внимание на то, как нам потребовалось использовать имя нового класса Utility при обращении к методу Reverse() из метода Main().

    string reversedValue = Utility.Reverse(value);

Ссылка на класс в другом пространстве имен(!!)

    using System;

    namespace MyNewApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                string value = "Microsoft Learn";
                string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);
                Console.WriteLine($"Secret message: {reversedValue}");
            }
        }
    }

    namespace MyNewApp.Utilities
    {
        class Utility
        {
            public static string Reverse(string message)
            {
                char[] letters = message.ToCharArray();
                Array.Reverse(letters);
                return new string(letters);
            }
        }
    }

Затем обратите внимание на способ вызова метода Reverse():

    string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);

Так как дочернее пространство имен Utilities и класс Program определены в родительском пространстве имен MyNewApp, 
в этом экземпляре можно не указывать пространство имен, что показано в следующем примере:

    string reversedValue = Utilities.Utility.Reverse(value);


Более быстрое разрешение пространств имен в компиляторе с помощью инструкции using.

Лучше будет добавить инструкцию using. Инструкция using добавляется в верхнюю часть файла кода и разрешает 
имена классов, которые используются в файле, указывая компилятору, что необходимо просмотреть список 
пространств имен для поиска всех имен классов.

    using System;
    using MyNewApp.Utilities;

    namespace MyNewApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                string value = "Microsoft Learn";
                string reversedValue = Utility.Reverse(value);
                Console.WriteLine($"Secret message: {reversedValue}");
            }
        }
    }

    namespace MyNewApp.Utilities
    {
        class Utility
        {
            public static string Reverse(string message)
            {
                char[] letters = message.ToCharArray();
                Array.Reverse(letters);
                return new string(letters);
            }
        }
    }



** Резюме

    Блоки кода определяют структуры более высокого уровня, такие как пространства имен, классы и методы.
    Блоки кода влияют как на видимость переменных, определенных внутри таких низкоуровневых структур, как инструкции принятия решений и итераций, так и на видимость методов между классами и классов между пространствами имен.
    Инструкцию using можно добавить в файлы кода, чтобы указать компилятору, где искать ссылки на классы.








*/