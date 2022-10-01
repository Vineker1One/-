// Задача: Сложить два числа (Написать программу на языке C#, 
// для Windows и Mac OS,
// [в которую пользователь вводит два целых числа]
// [в которой записаны два целых числа]
// [два целых числа генерируются случайным образом]
// и получает сумму
// )

// УТОЧНЕНИЕ АЛГОРИТМА!


int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);