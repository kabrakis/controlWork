# Задача :

 *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*


**Описание решения алгоритма:**

1. Объявляется два массива: 
изначальный массив и вторый с длинной равной изначальному массиву. 


2. Создаем метод создания второго массива из эллементов первого которые соответствуют заданному условию, он принимает два массива. Изначальный и второй. Объявляем переменную *count* и присваиваем ей значение 0 (ноль), она нам нужна для переноса эллементов изначального массива во второй массив (счетчик эллементов). Внутри метода проходим и проверяем каждый эллемент изначального массива по условию: **длинна изначального эллемента массива меньше или равно трем?**, если true то элемент изначального массива заносится в *count* элемент второго массива. После выполнения условия переменная *count*  увеличивается на 1. Таким образом мы запишем все эллементы подходящие под наше условие, сколько бы не было эллементов в изначальном массиве.

3. Создаем метод печати массива. Он принимает массива и выводит его на экран. Перебираем каждый элемент массива и выводим каждый из них по мере движения в цикле. От 0 (нуля) к его длине

4. Запускаем метод создания второго массива из эллементов первого которые соответствуют заданному условию, передавая данные в него изначального массива и второго массива.

5. Запускаем метод печати массива, передаем в него данные второго, уже измененного массива. 

Графическое представление метода в папке Dioram в двух файлах разных расширениях.

Код алгоритма находится по пути TaskForControlWork/Program.cs