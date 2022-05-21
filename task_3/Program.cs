// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[7];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
    Console.Write($" {array[i]} ");
}
int count = 0;
int count2 = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i] % 2 == 0)
   {
        count++; 
   } 
    else if (array[i] % 2 == 1)
   {
       count2++; 
   } 

}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел массива равно {count} ");
Console.WriteLine();
Console.WriteLine($"Количество нечётных чисел массива равно {count2} ");


