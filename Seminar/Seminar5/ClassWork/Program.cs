//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}



int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
    int[] array = new int[size];
  
    for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minVal, maxVal + 1);
  }

  return array;
}

int SumOfNegatives (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if( array [i] < 0)
            sum += array [i];
    }

    return sum;
}

// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a ax possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// int result = SumOfNegatives(myArray);
// Console.WriteLine("Sum of neganive elements " + result);



// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] Replace (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// // void ShowReplace(int[] array)
// // {
// //     for(int i = 0; i < array.Length; i++)
// //         Console.Write(array[i] + " ");

// //     Console.WriteLine();
// // }
// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a ax possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// int[] replace = Replace(myArray);
// ShowArray(replace);



// Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


// int Find (int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         result++;
//     }
//     return result;
// }

// Console.Write("Input a number of elements: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(12, 0, 120);
// ShowArray(array);
// int find = Find(array);
// Console.Write(find);



// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindNumber (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}
Console.Write ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(12, 1, 12);
ShowArray(myArray);
if (FindNumber(myArray, num))
{
    Console.Write("Число входит");
}
else {
    Console.Write("Число не входит");
}