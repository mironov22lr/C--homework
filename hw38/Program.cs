// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


//double[] array = new double[15];
//void MinMaxArray(double[] arr)
/{
 // double MinNum= 0;
  //double MaxNum= 0;
  
  //for(int i = 0; i < arr.Length; i++)
 //{
   // arr[i] = new Random().Next(-5,25);
   // Console.Write(arr[i]+" ");
 //}
   //for (int i = 1; i < arr.Length; i++)
 //{
   // if (arr[i] < MinNum) MinNum = arr[i];
    //if (arr[i] > MaxNum) MaxNum = arr[i];
     
 //}
   //  Console.WriteLine($"Min number array {MinNum}\nMax number array {MaxNum}");
     //Console.WriteLine($"{MaxNum - MinNum}");
//}
//MinMaxArray(array);
