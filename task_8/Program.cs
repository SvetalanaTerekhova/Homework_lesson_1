// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
double namber = double.Parse(Console.ReadLine());
double EvenNumber = 1;
Console.Write("Ответ: ");
while(EvenNumber<=namber)
{
    if (EvenNumber%2 == 0)
    {
        Console.Write(EvenNumber);
        Console.Write(";");        
    }
    EvenNumber++; 
}