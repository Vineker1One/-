// Задайте значени N. Напишите программу, которая выведет все натуральные чилса от N до 1. Выполнить с помощью рекурсии.

void ShowNums (int n)
{
    Console.Write (n + " ");
    if (n > 1) ShowNums(n - 1);
}
// ShowNums(5);

// Зайдайте значения M и N. Напишите программу, которая найдет сумму нарутральных элементов в промежутке от M и N.

int SumNum (int m, int n)
{
    if(m < n)
    {
        return m = m + SumNum (m+1, n);
    }
    if(m > n)
    {
        return m = m + SumNum (m-1, n);
    }

    else return n;
}
// Console.WriteLine(SumNum(1,4));

// Напиште программу для вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write(Akkerman(3, 2));
