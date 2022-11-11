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

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// 1 5 2
// 6 3 8
// 4 7 9

// 1 6 4 
// 5 3 7 
// 2 8 9

void ChangeArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
        Console.WriteLine("Impossible to change");
    
    else
        for (int i = 0; i < array.GetLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
}
// int[,] myarray = CreateRandom2dArray();
// Show2dArray(myarray);
// Console.WriteLine();
// ChangeArray(myarray);
// Show2dArray(myarray);

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void ChangeRow(int[,] array, int first, int second)
{
    if(first < array.GetLength(0) && second < array.GetLength(0))
        for (int j = 0; j <array.GetLength(1); j++)
        {
            int temp = array[first, j];
            array[first, j] = array[second, j];
            array[second, j] = temp;
        }
    else
        Console.WriteLine("Невозможно заменить");
}
// int[,] myarray = CreateRandom2dArray();
// Console.Write("Введите 1 строку: ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 1 строку: ");
// int second = Convert.ToInt32(Console.ReadLine());
// Show2dArray(myarray);
// Console.WriteLine();
// ChangeRow(myarray, first - 1, second - 1);
// Show2dArray(myarray);


// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] CutArray(int[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }

        }
    }
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, x = 0; i < array.GetLength(0); i++)
        if(i != iMin)
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++)
                if(j != jMin)
                {
                    newArray[x, y] = array[i,j];
                    y++;
                }
            x++;
        }
    return newArray;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[,] newArray = CutArray(myArray);
Console.WriteLine();
Show2dArray(newArray);