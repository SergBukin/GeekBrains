# Команды C#

- Типы данных **int** и **double**: целый тип данных (integer) и вещественный тип данных (double). 
различаются не только по возможности хранить вещественные числа, но и по объёму памяти, который занимают. 
Если целые числа позволяют хранить диапазон от -2 147 483 648 до 2 147 483 647, то тип «double» может хранить числа от ±5,0 × 10-324 до ±1,7 × 10308.
- Тип данных **string**: Также важно помнить, что есть строки (тип данных «string»). Он может содержать от 0 (это называется
пустой строкой) до большого количества символов, в общем случае до 2 Гб. Это много. Для сравнения,
например, один том «Война и мир» весит около 13 Мб, хотя, возможно, это вес всех книг серии «Война
и мир». То есть строки могут быть очень и очень большими.
- Тип данных **bool**: Четвёртый тип данных, с которым нужно познакомиться на старте, это логический тип данных. Он
записывается, как bool и позволяет хранить только 2 значения: либо истина, либо ложь.

-  **new Random().Next(мin, маx)** -  оператор new даст случайное целое число в полуинтервале  [min, max-1] или [min, max)

- **if** (условие) { Набор действий 1} **else**
{ Набор действий 2}

- int i – объявить целочисленную переменную i.
- string s – строковая переменная s.
- int.Parse(“1”) – сконвертировать строку в число
- 11 % 5 – деление по модуля числа 11 на число 5
- 51 / 10 – деление 51 на 10 (делятся целые числа – результат целое число)
- for (int i = 0; i < 10; i++) {/*Ваш код*/} – цикл for, повторяющийся 10 раз
- While (условие) {/*Ваш код*/}  - цикл while
- Console.WriteLine(“”) – вывести в консоль текст
- Console.ReadLine() – прочитать из консоли текст

 - i ++: i = i + 1
 - i += 2: i = i + 2
 - i --: i = i – 1
 - if (условие) {/*Ваш код*/}  else {/*Ваш код*/} – оператор ветвления
 - switch (i)
      { 
      case 1: /*Ваш код*/; break; 
      case 2: /*Ваш код*/; break; 
     default: /*Ваш код*/; break;
      }

 - (true && true) – true, Логическое И
 - (true && false) – false, Логическое И
 - (true || false) – true, Логическое ИЛИ
 - (1 == 1) – true, Равно
 - (1 != 1) – false, НЕ Равно
 - int[] array = new int[5];
 - int[] array = new int[] {1,2,3,4,5};
 - array.Length – Длина массива
 - array[i] – элемент массива под индексом I
 - array[,] array = new int[2,2]; - создание двумерного массива
 - array[i, j] – получение элемента двумерного массива
 - Math.Pow(5, 2) – возведение числа 5 в квадрат
 - Math.Sqrt(4) – получение корня числа 4

- while( УСЛОВИЕ ПРОДОЛЖЕНИЯ)
{
Набор действий
}
Int count = 0;
while( count < 100)
{
Набор действий
count = count + 1
}