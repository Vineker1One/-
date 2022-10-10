// // Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.
// int FindQuart(double x, double y)
// {
//     int num = 0;

//     if(x > 0 && y > 0) num = 1;
//     if(x < 0 && y > 0) num = 2;
//     if(x < 0 && y < 0) num = 3;
//     if(x > 0 && y < 0) num = 4;

//     return num;
// }

// Console.Write("Input x-coordinate: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y-coordinate: ");
// double y = Convert.ToDouble(Console.ReadLine());

// int quartNum = FindQuart(x,y);
// Console.WriteLine($"The point A({x},{y}) is in {quartNum} quart");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double FindDistance (double x1, double y1, double x2, double y2)
// {
//     double Kat1 = y2 - y1;
//     double Kat2 = x2 - x1;
//     double distance = Math.Sqrt((Kat1*Kat1)+(Kat2*Kat2));
//     return distance; 
// }
// Console.Write("Введите координату x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// double distance1 = FindDistance(x1, y1, x2, y2);
// Console.WriteLine ($"Расстояние между двумя точками с координатами ({x1};{y1}) и ({x2};{y2}) равно {distance1}");


// Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

// void RowSquart (int N)
// {
//     int count = 1;
//     while (count <= N)
//     {
//         double row = Math.Pow(count, 2);
//         Console.Write(row + " ");
//         count++;
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// RowSquart(num);


