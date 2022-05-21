// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,999);
    Console.Write($" {array[i]} ");
}

int count = 0;
foreach (int element in array)
if ( element >= 10 && element <= 99)
{
  count++; 
}
Console.WriteLine();
Console.WriteLine($"Количество элементов из отрезка [10,99] равно {count} ");

