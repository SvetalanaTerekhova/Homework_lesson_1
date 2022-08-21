// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int namber = int.Parse(Console.ReadLine());
if (namber%2 == 0)
{
    Console.WriteLine("Ответ: ");
    Console.Write(namber);
    Console.Write(" - чётное число");
}
else
{
    Console.WriteLine("Ответ: ");
    Console.Write(namber);
    Console.Write(" - нечётное число");
}