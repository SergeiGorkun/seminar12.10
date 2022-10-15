// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] numbers = {1, 2, -4, 5, 6.245, 12/7, 0.1};
double Min = numbers [0];
double Max = numbers [0];

for(int i = 0; i < numbers.Length; i++){
    if(Min > numbers[i]){
        Min = numbers[i];
    }
    if(Max < numbers[i]){
        Max = numbers[i];
    }
}
double Ras = Max - Min;     
Console.WriteLine(Ras);

