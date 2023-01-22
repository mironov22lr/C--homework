// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int[] arrayPalindrom = {0, 0, 0, 0, 0}; 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[0] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[1] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[2] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[3] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[4] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Your array is: " + arrayPalindrom[0] + arrayPalindrom[1] + arrayPalindrom[2] + arrayPalindrom[3] + arrayPalindrom[4]); 
 
if ((arrayPalindrom[0] == arrayPalindrom[4]) && (arrayPalindrom[1] == arrayPalindrom[3])) 
{ 
    Console.WriteLine("Number is palindrome!!!!!!"); 
} 
else 
{ 
    Console.WriteLine("Number is normal"); 
}


//Console.WriteLine ("Введите 5-ти значное число: ");
//string = = Console.ReadLine();
//int = = number.Length;

//if (len == 5)
//{
//    if (number [0] == number [4] && number [1] == number [3])
  //  {
    //    Console.WriteLine(number + " Палиндром");
    //}

    //else
    //{
     //   Console.WriteLine(number + " Не палиндром");
    //}
//}
//else
//{
//    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
//}