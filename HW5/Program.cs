// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = new int[4];

FillArray(array);
PrintArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] %2 ==0)
    count ++;
}

Console.WriteLine();
Console.WriteLine($"Количество четных числе в данном массиве: {count}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-99, 99);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = new int[4];
FillArray(array);
PrintArray(array);


int sumOfOddIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    sumOfOddIndex += array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sumOfOddIndex}");
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-99, 99);
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

double[] array = new double[4];

FillArray(array);
PrintArray(array);

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    max = array[i];
    if (array[i] < min)
    min = array[i];
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным{max} и минимальным{min} значением: {max - min}");