// //Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.

// int FindBiggerDigit(int num)
// {
//     int result;

//     // if(num < 10 || num >=10)
//     //     return 0;
//     // else
//     // {
//     int ed = num % 10;
//     int dec = num / 10;

//     if (ed > dec)
//         result = ed;
//     else
//         result = dec;

//     return result;
// }

// Console.Write("Input a two-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // Вызываем метод(1)
// int biggerDigit = FindBiggerDigit(number);
// Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// int Num(int num)
// {
//     int result;

//     int hund = num / 100;
//     int ed = num % 10;
//     result = hund * 10 + ed;

//     return result;
// }

// int number = new Random().Next(100, 1000);
// Console.WriteLine("Сгенерируем трех-значное число: " + number);
// // int number = Convert.ToInt32(Console.ReadLine());
// int number2 = Num(number);
// Console.WriteLine($"Двухзначное число = {number2}");

//Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b(целочисленные делители, также задаются пользователем).

bool Del(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num2 == 0) return true;
    return false;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первый делитель: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй делитель: ");
int b = Convert.ToInt32(Console.ReadLine());
bool suc = Del(number, a, b);
Console.WriteLine($"Ответ: {suc}");

