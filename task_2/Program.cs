// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число:");
double namberA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
double namberB = double.Parse(Console.ReadLine());
double max = namberA;
double min = namberB;
if (namberB> namberA)
{
    max = namberB;
    min = namberA;
}
Console.WriteLine("Ответ: ");
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);