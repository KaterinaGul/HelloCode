// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату x для первой точки");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для первой точки");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для первой точки");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x для второй точки");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для второй точки");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для второй точки");
int zb = Convert.ToInt32(Console.ReadLine());

double l = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za));
Console.WriteLine($"Расстояние между точками {Math.Round(l,2)}");