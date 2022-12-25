// ВСЕ ДЗ РЕШАТЬ ЧЕРЕЗ РЕКУРСИЮ!
// СДАВАТЬ ССЫЛКОЙ НА СВОЙ РЕПОЗИТОРИЙ В ГИТХАБЕ! 
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

System.Console.WriteLine(Akkerman(3, 2));