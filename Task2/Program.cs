// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Write("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max= ");
Console.WriteLine(max);