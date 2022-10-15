// Задать массив, заполнить случайными положительными трехзначными числами. Показать количество нечетных/четных чисел
int[] array = { 123, 222, 154, 163, 178, 192, 111 };
int evensCount = array.Count(n => n % 2 == 0);
Console.WriteLine("Количество четных чисел " + evensCount);
Console.WriteLine("Количество нечетных чисел " + (array.Length - evensCount));
