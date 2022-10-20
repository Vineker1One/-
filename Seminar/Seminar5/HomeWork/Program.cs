// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
    int[] array = new int[size];
  
    for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minVal, maxVal + 1);
  }

  return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


// int ShowEvenNumber (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count ++;
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, 100, 999);
// ShowArray(myArray);
// int result = ShowEvenNumber(myArray);
// Console.WriteLine("Количество четных чисел в массиве: " + result);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int SumOfElements (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) sum += array[i];
//     }
//     return sum;
// } 

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray (size, min, max);
// ShowArray(myArray);
// int result = SumOfElements(myArray);
// Console.WriteLine("Сумма элементво стоящих на нечетных позициях равна: " + result);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArrayD(int size, int minVal, int maxVal) 
{
    double[] array = new double[size];
  
    for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minVal, maxVal + 1);
  }

    return array;
}

void ShowArrayD(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


double Subtraction (double[] array)
{
    double min = array[0];
    double max = array[0];
    double subtraction;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    subtraction = max - min;
    return subtraction;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArrayD (size, min, max);
ShowArrayD(myArray);
double result = Subtraction (myArray);
Console.WriteLine("Разница между максимальным элементом массива и минимальным равна: " + result);