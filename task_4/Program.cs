// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
double namberA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double namberB = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double namberC = double.Parse(Console.ReadLine());
double max = namberA;
if (namberB > max) max = namberB;
if (namberC > max) max = namberC;
Console.WriteLine("Ответ:");
Console.Write("max = ");
Console.WriteLine(max);