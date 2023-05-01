// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое значение: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите последнее значение: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");


int CountNaturalSum(int m, int n) // вычисление суммы натуральных элементов от М до N
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}