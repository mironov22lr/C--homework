﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number..."); 
int OverNumber = Convert.ToInt32(Console.ReadLine()); 
int StartNumber = 1; 
while (StartNumber <= OverNumber) 
{ 
    if (StartNumber % 2 == 0) 
    { 
        Console.Write(StartNumber + " "); 
    } 
    StartNumber = StartNumber+1; 
}
