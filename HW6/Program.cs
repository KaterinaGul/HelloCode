//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Сколько чисел вы хотите ввести? (Введите количество) ");
// int M = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[M];

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     Console.WriteLine($"Введите {M} чисел через пробел для создания массива:");
//             string[] arrayNumber =  Console.ReadLine().Split(' ');

//             for (int index =0; index < arrayNumber.Length; index++)
//             {
//                 array[index] = int.Parse(arrayNumber[index]);
//             }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]}, ");
//         position++;
//     }
// }


// FillArray(array);
// Console.Write("Вот ваш массив: ");
// PrintArray(array);

// int amount = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         amount++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Вот сколько чисел больше нуля вы ввели: {amount} ");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//y = k1 * x + b1
//y = k2 * x + b2
//k1*x + b1 = k2*x + b2
//k1*x - k2*x = b2 - b1
//x = (b2 - b1)/(k1- k2)
//y = k1* (b2 - b1)/(k1- k2) + b1

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;
if (b1 == b2 & k1 == k2) Console.WriteLine("Данные прямые совпадают");
else if (k1 == k2) Console.WriteLine("Точки пересечения нет, прямые параллельны");
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1* (b2 - b1)/(k1- k2) + b1;
    Console.WriteLine($"Координаты точки пересечения: {x}, {y}");
}
