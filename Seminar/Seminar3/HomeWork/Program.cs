//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom (string number)
// {
//     if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine ($"Число {number} является палиндромом");
//     else Console.WriteLine ($"Число {number} не является палиндромом");
// }

// Console.Write("Введите пятизначное число: ");
// string? num = Convert.ToString(Console.ReadLine());
// if (num.Length == 5 )
// {
//     Palindrom(num);
// }
// else Console.WriteLine ("Число не пятизначное");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double Kat1 = y2 - y1;
//     double Kat2 = x2 - x1;
//     double Kat3 = z2 - z1;
//     double distance = Math.Sqrt(Math.Pow(Kat1,2) + Math.Pow(Kat2, 2) + Math.Pow(Kat3, 2));
//     return distance; 
// }
// Console.Write("Введите координату x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());


// double distance1 = FindDistance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine ($"Расстояние между двумя точками с координатами ({x1};{y1};{z1}) и ({x2};{y2};{z2}) равно {distance1}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void RowSquart (int N)
{
    int count = 1;
    while (count <= N)
    {
        double row = Math.Pow(count, 3);
        Console.Write(row + " ");
        count++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
RowSquart(num);