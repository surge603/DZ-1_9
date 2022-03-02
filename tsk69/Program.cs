// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
// M = 1; N = 4 -> 10
// M = 4; N = 8. -> 30

int M = 4, N = 8, sum = 0;

void Sum(int i)
{
    if (i > N) return;
    sum += i;
    Sum(i + 1);
}
Sum(M);
Console.WriteLine($"M = {M}; N = {N} -> {sum}");