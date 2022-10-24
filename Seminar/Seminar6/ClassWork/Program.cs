// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] CreateRandomArray()
// {
//     Console.Write("Input a number of elements: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a ax possible value: ");
//     int max = Convert.ToInt32(Console.ReadLine());


//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }

//     return array;
// }



// int[] ChangeArray(int[] array)
// {
//     int[] newArray = new int[array.Length];

//     newArray[0] = array[0] + 10;
//     for (int i = 1; i < array.Length; i++)
//       newArray[i] = array[i];

//     return newArray;
// }


// int[] myArray = CreateRandomArray();
// ShowArray(myArray);
// int[] array2 = ChangeArray(myArray);
// ShowArray(array2);


// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void ChangeArray2(int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// int[] myArray = CreateRandomArray();
// ShowArray(myArray);
// ChangeArray2(myArray);
// ShowArray(myArray);

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool Triangle (int a, int b, int c)
// {
//     return a+c > b && b+a > c && c+b > a;
//
// //       bool result = a+c > b && b+a > c && c+b > a;
// //       return result;
// }
// Console.Write("Введи размер первой стороны треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи размер второй стороны треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи размер третьей стороны треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (Triangle(a, b, c))
// {
//     Console.Write("Треугольник существует");
// }
// else {
//     Console.Write("Треугольник не существует");
// }



// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] ChangeArray(int[] array)
// {
//     int[] array2 = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//         array2[i] = array[i];
//     return array2;
// }

// int[] myArray = CreateRandomArray();
// ShowArray(myArray);
// int[] array2 = ChangeArray(myArray);
// ShowArray(array2);

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// int[] Fibonacci (int n, int a, int b)
// {
//     int[] array = new int[n];
//     array[0] = a;
//     array[1] = b;
//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// }
// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первое число фибоначчи: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число фибоначчи: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Fibonacci(n, a, b));
