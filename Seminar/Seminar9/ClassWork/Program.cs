// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// void ShowNums (int n)
// {
//     if(n > 1) ShowNums(n - 1);
//     Console.Write(n + " ");

// }

// ShowNums(5);

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// int SumOfDigits (int n)
// {
//     if(n != 0) return SumOfDigits (n / 10) + n % 10;
//     else return 0;
// }

// Console.WriteLine(SumOfDigits(1234));

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowTwoNums (int m, int n)
// {
//     if (n == m) {
//         Console.Write(m + " ");
//     }
//     if(n < m) 
//     {
//         ShowTwoNums (m-1, n);
//         Console.Write(m + " ");
//     }
//     if (n > m)
//     {
//         ShowTwoNums(m, n - 1);
//         Console.Write(n + " ");
//     }
// }
// ShowTwoNums(1,5);

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double Degree (double a, double b)
{
    if(b < 0) 
    {
        return 1/a * Degree (a, b+1);
    }
    if(b > 0) 
    {
        return a * Degree (a, b-1);
    }
    return 1;
}
Console.Write(Degree(2,-3));