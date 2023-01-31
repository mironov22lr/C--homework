// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


//int[] array = new int[10];

//void NotEvenPosArray (int[] arr)
//{
    //int SummPozIndArray = 0;
    //for(int i = 0; i < array.Length; i++)
  //{
   //  arr [i]=new Random().Next(15);

      //if(i % 2!= 0) - если складывать нечетный индекс элемента в массиве
  //    if(i % 2 == 0) // если нечетную позицию.
   //   {
    //    SummPozIndArray+=arr[i];
   //   }
         
 // }

 //Console.WriteLine(string.Join(",", array));
 //Console.WriteLine(SummPozIndArray);
//}
//NotEvenPosArray(array);
