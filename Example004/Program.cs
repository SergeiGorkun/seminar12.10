// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int [123];
Random rnd = new Random();
int i = 0;
int count = 0;
while(i<array.Length){
int value = rnd.Next(1, 1000);
    array[i] = value;
    i++;
    Console.WriteLine(value);
}
i = 0;
while(i<array.Length){
    if(array[i] >= 10 && array[i] <= 99){
        count++;    
    }
    i++;
}

Console.WriteLine("Количество элементов  " + count);