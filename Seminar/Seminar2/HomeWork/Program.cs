// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondNum (int num)
// {
//     int result;
//         int hun = num / 10;
//         int ed = hun % 10;
//         result = ed;
//     return result;
// }
// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secnum = SecondNum(number);
// Console.WriteLine($"Второя цифра из числа {number} - {secnum}");

//ПРИМЕР РЕШЕНИЯ 1 ЗАДАЧИ, ЕСЛИ ЧИСЛО НЕ ТРЕХЗНАЧНОЕ(НЕ ПОЛУЧАЕТСЯ):

// int SecondNum (int num)
// {
//     int result;
//     if (num >= 100)
//     {
//         int hun = num / 10;
//         int ed = hun % 10;
//         result = ed;
//     }
//     else{
//         Console.WriteLine("Число не трехзначное");
//     }
//     return result;
// }
// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secnum = SecondNum(number);
// Console.WriteLine($"Второя цифра из числа {number} - {secnum}");

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThreeNum (int num)
// {
//     if (num < 100)
//     {
//         return -1;
//     }
//     else
//     {
//         while (num >= 1000)
//         {
//             num = num / 10;
//             int three = num;
//         }
//     }
//     return num % 10;
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int three = ThreeNum (number);
// if(three == -1)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//    Console.WriteLine($"Третья цифра из числа {number}: {three}"); 
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void Weekend (int num)
// {
//     if (num < 6) Console.WriteLine("Это не выходной");
//     else 
//     {
//         Console.WriteLine("Это выходной");
//     }
// }
// Console.Write("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Weekend (number);