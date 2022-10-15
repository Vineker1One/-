// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double WhileMulti (double numA, double numB)
// {
//     double count = numA;
//     for (int i = 1; i < numB; i++)
//     {
//         count = count * numA;
//     }
    
//     return count;
// }
// Console.Write("Введите первое число: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double b = Convert.ToDouble(Console.ReadLine());
// double multi = WhileMulti(a,b);
// Console.WriteLine($"При возведении числа {a} в число {b} получается {multi}");

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNumber (int num)
// {
//     int result = 0;
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = num % 10;
//         num /=10;
//         result += sum;
//     }
//     return result;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int n = SumNumber(a);
// Console.WriteLine($"Сумма цифр в числе {a}: {n}");


// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray (int m)
{

    int[] array = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(m);
ShowArray(myArray);
