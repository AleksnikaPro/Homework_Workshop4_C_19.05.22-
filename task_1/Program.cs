// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


// Вариант 1
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write($" {array[ i ]} ");
}

// Вариант 2
/*int[] array = new int [8] {0, 1, 0, 0, 1, 1, 1, 0};
int length = array.Length;
for (int i = 0; i < length; i++)
{
    Console.Write($" {array[ i ]} ");
}*/