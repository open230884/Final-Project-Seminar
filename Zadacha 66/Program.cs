// ВСЕ ДЗ РЕШАТЬ ЧЕРЕЗ РЕКУРСИЮ!
// СДАВАТЬ ССЫЛКОЙ НА СВОЙ РЕПОЗИТОРИЙ В ГИТХАБЕ!
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 1;
int N = 15;
Console.Write($"M = {M}; N = {N} -> ");
int Recursion(int x, int y)
{
    if (x == y)
    {
        return y;
    }
    return x + Recursion(x + 1, y);
}
Console.WriteLine(Recursion(M, N));