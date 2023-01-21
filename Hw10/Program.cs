//// Напишите программу, которая принимает на вход трёхзначное число 
////и на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1000 && x > 99)
{
int two = x / 10;
int result = two % 10;
Console.Write(result);
}
else
Console.WriteLine("ввели не трехзначное число");

нов вариант
 Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
void Cube(int[] N)
{
    int count = 0;
    int length = N.Length;
    while (count < length)
    {
        N[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}
void PrintArry(int[] coll)
{
    int result = coll.Length;
    int index = 1;
    while (index < result)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}
if (N >= 1)
{

    int[] arry = new int[N + 1];
    Cube(arry);
    PrintArry(arry);
}
else
{
    Console.Write("Введите правильное число: ");
}
Console.WriteLine();
