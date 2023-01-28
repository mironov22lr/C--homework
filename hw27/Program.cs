// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Console.WriteLine("введите число");
//int i = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

//while (i > 0)
//{
//int num = i % 10;
//i = i / 10;
//sum = sum + num;
//}
//Console.WriteLine("сумма всех цифр в числе равна: " + sum);



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummDigits (string number)
{     
   int summ = 0;
   
   for(int i=0;i < number.Length; i++)
   {
       summ = summ + Convert.ToInt32(Char.GetNumericValue(number[i]));
   }
   return summ;
}

Console.WriteLine("введите число...");
int SumNumber = SummDigits(Console.ReadLine());
Console.WriteLine($"сумма всех чисел в числе равна {SumNumber}");


