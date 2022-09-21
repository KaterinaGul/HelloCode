// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >99 && num <1000)
{
int a = num / 10 % 10;
Console.WriteLine( a );
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
