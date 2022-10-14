// Необходимо написать программу которая на вход принимает число N, нужно найти сумму чисел от 1 до N

// int GetSum(int num)
// {
//     int sum = 0;

//     for (int current = 1; current <= num; current++)
//     {
//         sum += current; // sum = sum + current
//     }
//     return sum;
// }
// Console.Write("Input a positive integer number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int s = GetSum(a);
// Console.WriteLine($"Sum of numbers from 1 to {a} is {s}");

//Необходимо написать программу которая на вход принимает число N и возвращает количество цифр в числе

// int GetNumbers (int num)
// {
//     int count = 0;
//     if (num < 0) num *= -1;
//     while (num > 0)
//     {
//         num /=10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int n = GetNumbers(a);
// Console.WriteLine($"Количество цифр в числе {a}: {n}");




//Необходимо написать программу которая на вход принимает число N, нужно найти произведение чисел от 1 до N

// int GetMulti (int num)
// {
//     int multi = 1;
//     if (num < 0) return -1;
//     for (int current = 1; current <= num; current++)
//     {
//         multi *= current;
//     }
//     return multi;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int s = GetMulti(a);
// if (s == -1) Console.WriteLine("Факториал не может быть отрицательным");
// else Console.WriteLine($"Факториал числа {a} равен {s}");


// Написать программу, которая выводит массив элементов, заполненный 0 и 1 в случайном порядке


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Console.Readline();
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

//Сгенирировать метод который будет запрашивать массив у пользователя







