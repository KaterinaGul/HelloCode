// Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

int [] array = new int[8];

Console.WriteLine("Введите 8 чисел через 'пробел' для создания массива:");
            string[] arrayNumber =  Console.ReadLine().Split(' ');
 
            for (int i =0; i < arrayNumber.Length; i++)
            {
                array[i] = int.Parse(arrayNumber[i]);
                Console.Write(array[i]);
            }