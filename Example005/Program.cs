// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] numbers = {13, 25, 142, 1223, 11, 24, 22};
int Sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0) {
        Sum = Sum + numbers[i];
    }
}

Console.WriteLine(Sum);