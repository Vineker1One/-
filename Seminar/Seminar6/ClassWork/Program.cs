void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] CreateRandomArray() 
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a ax possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());


    int[] array = new int[size];
  
    for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }

  return array;
}



void ChangeArray(int[] array)
{
    array[0] += 10;
}


int[] myArray = CreateRandomArray();
ShowArray(myArray);
ChangeArray(myArray);
ShowArray(myArray);
