// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num2;

if (num2 > num1) max = num2; 
if (num2 > num1) min = num1;

Console.Write("max= ");
Console.WriteLine(max);

Console.Write("min= ");
Console.WriteLine(min);