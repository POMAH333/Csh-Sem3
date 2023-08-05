// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки А ");
Console.Write("x: ");
int numAx = int.Parse(Console.ReadLine());
Console.Write("y: ");
int numAy = int.Parse(Console.ReadLine());
Console.Write("z: ");
int numAz = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");
Console.Write("x: ");
int numBx = int.Parse(Console.ReadLine());
Console.Write("y: ");
int numBy = int.Parse(Console.ReadLine());
Console.Write("z: ");
int numBz = int.Parse(Console.ReadLine());

double numD = Math.Sqrt(Math.Pow((numBx - numAx), 2) + Math.Pow((numBy - numAy), 2) + Math.Pow((numBz - numAz), 2));

Console.WriteLine($"Расстояние между точками A({numAx}, {numAy}, {numAz}) и B({numBx}, {numBy}, {numBz}) равно: {numD}");

