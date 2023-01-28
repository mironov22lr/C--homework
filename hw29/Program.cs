// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}


//int[] MaxMinArray()
//{
  //  Console.Write("Введите размер массива...");
    //int Size = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    //int[] arr = new int[Size];

    //Console.Write("Введите минимальное значение массива...");
    //int minNum = Convert.ToInt32(Console.ReadLine());
    
    //Console.Write("Введите максимальное значение массива...");
    //int maxNum = Convert.ToInt32(Console.ReadLine());

    //for (int i = 0; i <= Size - 1; i++)
    //{
      //  if (minNum <= maxNum) arr[i] = new Random().Next(minNum, maxNum + 1);
        //else arr[i] = new Random().Next(maxNum, minNum + 1);
    //}

    //return arr;
//}

//void SortAndPrintArray(int[] cheking)
//{
  //  for (int i = 0; i < cheking.Length; i++)
    //{
      //  int min = i;
        //for (int j = i + 1; j < cheking.Length; j++)
        //{
          //  if (cheking[min] > cheking[j]) min = j;
        //}

        //int go = cheking[min];
        //cheking[min] = cheking[i];
        //cheking[i] = go;

        //if (i == cheking.Length - 1) Console.Write($"{cheking[i]} ");
        //else Console.Write($"{cheking[i]}, ");
    //}
//}

//int[] array = MaxMinArray();
//SortAndPrintArray(array);
