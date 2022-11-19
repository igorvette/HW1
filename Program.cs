// Задача 1: Задайте значения М и N. Напишите программу, которая выведет все четные натуральные
// числа в промежутке от М до N с ппомощью ракурсии.
// M = 1; N = 5 -> (2,4.)
// M = 4; N = 8 -> (4,6,8.)






void PrintInterval(int m, int n)
{
    int start = m;
    int end = n;
    if(m > n)
    {
        start = n;
        end = m;
    }
    for(int i = start; i <= end; i++)
    {
        Console.Write($"{i%2} ");
    }
}
PrintInterval(22,9);

Console.WriteLine();
