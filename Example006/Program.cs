// Найти произведение пар чисел чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int [] numbers = {1,3,4,5,6,7,8,9,12,1,23};
int Proiz;
for(int i = 0; i < numbers.Length; i++) {
    if (i < numbers.Length - i) {
        Proiz = numbers[i] * numbers[numbers.Length - i - 1];
        Console.WriteLine(Proiz);
    }
}