// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// Вариант 1

/*int[] array = {13, 18, 48, 23, 45, 56};
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
    
}

for (int i = 0, j = array.Length - 1; i < array.Length / 2 ; i++, j--)
{
     Console.WriteLine($"\n{array[i]} х {array[j]} равно {array[i] * array[j]} ");
}

// Вариант 2

int [] array = new int[13];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
    Console.Write($" {array[i]} ");
}
for (int i = 0, j = array.Length - 1; i < array.Length / 2 ; i++, j--)
{
     Console.WriteLine($"\n{array[i]} х {array[j]} равно {array[i] * array[j]} ");
}


// Вариант 3

/*Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] array = new int[elementsCount];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
    Console.Write($" {array[i]} ");
}
for (int i = 0, j = array.Length - 1; i < array.Length / 2 ; i++, j--)
{
     Console.WriteLine($"\n{array[i]} х {array[j]} равно {array[i] * array[j]} ");
}*/

// Вариант 4

Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] array = new int[elementsCount];
for (int i = 0; i < array.Length; i++)
{
   Console.Write($"Введите элемент массива под индексом {i}: "); 
   array[i] = int.Parse(Console.ReadLine()); 
}
 Console.WriteLine("\nВывод массива:"); // \n - переводит на новую строку

for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]} ");
}
for (int i = 0, j = array.Length - 1; i < array.Length / 2 ; i++, j--)
{
     Console.WriteLine($"\n{array[i]} х {array[j]} равно {array[i] * array[j]} ");
}