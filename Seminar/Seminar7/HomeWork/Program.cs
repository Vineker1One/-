int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows,colums];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}



//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// void Show2dArrayDouble(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] Double2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double [rows,colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             int a = new Random().Next(minValue, maxValue);
//             double b = new Random().NextDouble();
//             array[i,j] = a + b;
//             array[i,j] = Math.Round(array[i,j], 2);
//         }
//     }
//     return array;
// }

// double [,] myArray = Double2dArray();
// Show2dArray(myArray);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// void FindElement (int[,] array)
// {
//     Console.Write("Введите номер строки: ");
//     int i = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите номер столбца: ");
//     int j = Convert.ToInt32(Console.ReadLine());

//     if(i < array.GetLength(0) && j < array.GetLength(1)) Console.WriteLine("Число с такими индексами: " + array[i,j]);
//     else Console.WriteLine("Числа с такими индексами в массиве нет");
// }

// int[,] myArray = CreateRandom2dArray();
// FindElement (myArray);
// Console.WriteLine();
// Show2dArray(myArray);


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void ShowArray (double[] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write(array[i] + " ");
    }
}

double[] Average (int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++, count++)
        {
            newArray[j] += array[i,j];
        }

        newArray[j] = Math.Round(newArray[j] / count, 2);
    }
    return newArray;
}

int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] result = Average(myArray);
ShowArray(result);