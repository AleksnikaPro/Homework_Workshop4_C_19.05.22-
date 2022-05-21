// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,9);
    Console.Write($" {array[ i ]} ");
}
int sum = 0;
int sum2 = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i] > 0)
   {
       sum = sum + array[i]; 
   } 
    else if (array[i] < 0)
   {
       sum2 = sum2 + array[i]; 
   } 

}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {sum} ");
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов массива равна {sum2} ");


