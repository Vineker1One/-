//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int Count (int m)
// {
//     int count = 0;
//     int step = 1;
//     while (step <= m){
//         Console.Write($"Введите {step} число: ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         step++;
//         if (a > 0) count++;
//     }

//     return count;
// }
// Console.Write("Введите количество желаемых чисел: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int result = Count(m);
// Console.WriteLine("Количество чисел больше 0: " + result);


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// void Math()
// {
//     Console.Write("Добавьте k1: ");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Добавьте b1: ");
//     double b1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Добавьте k2: ");
//     double k2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Добавьте b2: ");
//     double b2 = Convert.ToDouble(Console.ReadLine());
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     Console.WriteLine($"Точка пересечения двух прямых воординате {(x, y)}");
// }
// Math();

