// // int n1 = 47;

// // // double n2 = 32.15;
// // // string name = "Ivan";
// // // bool check = true;

// // Console.Write("My number is " + n1 + " and it is good!");

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// // "25" -> 25

// Console.WriteLine("Your number is " + num);



// Console.Write("Input a first number: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int q2 = n2 * n2;
// if(n1 == q2)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


// Console.Write("Input a number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = -n;

// if(n < 0)
// {
//     current = n;
//     n = -n;
// }

// while(current <= n)
// {
//     Console.Write(current + " ");
//     current++;
// }


// 3162 % 10 -> 2
// 3162 % 100 -> 62
// 3162 % 1000 -> 162


// 3162 / 10 -> 316
// 3162 / 100 -> 31
// 3162 / 1000 -> 3

// 82736 / 100 -> 827 % 100 -> 27
// 5243 / 10 % 10 -> 2

Console.Write("Input a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if( n >= 100 && n < 1000)
{
    int lastdigit = n % 10;
    Console.WriteLine("Last digit of " + n + " is " + lastdigit );
    Console.WriteLine($"Last digit of {n} is {lastdigit}");
}
else
{
    Console.WriteLine("Uncorrect input!");
}