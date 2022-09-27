// Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

int [] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    Console.WriteLine("Введите 8 чисел через пробел для создания массива:");
            string[] arrayNumber =  Console.ReadLine().Split(' ');
 
            for (int index =0; index < arrayNumber.Length; index++)
            {
                array[index] = int.Parse(arrayNumber[index]);
            }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);