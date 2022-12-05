// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

int xa, xb, ya, yb, za, zb;
Console.Write($"Введите координату X для точки A: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"Введите координату Y для точки А: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"Введите координату Z для точки A: ");
int.TryParse(Console.ReadLine()!, out za);
Console.Write($"Введите координату X для точки B: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"Введите координату Y для точки B: ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($"Введите координату Z для точки A: ");
int.TryParse(Console.ReadLine()!, out zb);

int x = (xa - xb) * (xa - xb);
int y = (ya - yb) * (ya - yb);
int z = (za - zb) * (za - zb);

double ans = Math.Sqrt(x + y + z);

Console.WriteLine($"Расстояние между точками A и B = {Math.Round(ans, 2)}");


