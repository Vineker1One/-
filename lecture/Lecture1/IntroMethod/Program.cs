int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 16443;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max1 = Max(a1, b1, c1)
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max
    (Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);

// if (b1 > max) max = b1;
// // Технически это надо повторить много раз:
// if (c1 > max) max = c1;
// // Далее воспользуемся копипастом и допишем следующее:
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// /* Главное — избавиться от всех потенциальных ошибок, которые могут быть допущены. Поэтому
// везде вместо 1 поставим 2.
// Таким же образом находим максимум из тройки игроков:*/  
// if (a3>max) max = a3;
// if (b3>max) max = b3;
// if (c3>max) max = c3;
