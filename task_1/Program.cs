// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int [8] {0, 1, 0, 0, 1, 1, 1, 0};
int length = array.Length;
for (int i = 0; i < length; i++)
{
    Console.Write($" {array[ i ]} ");
}
