// Задача 67: Показать натуральные числа от N до 1, N задано.
// N = 5. -> "5, 4, 3, 2, 1"

int n = 10;

void ShowNatural(int i)
{
    if (i == 0) return;
    Console.Write($"{i} ");
    ShowNatural(i -1);
}
Console.Write($"N = {n}. -> ");
ShowNatural(n);
Console.WriteLine();