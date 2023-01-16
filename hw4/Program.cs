// Напишите программу которая принимает на ввод три числа и выдает максимум из этих чисел
Console.Write("Enter first number..."); 
 int Number1 = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Enter second number..."); 
 int Number2 = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Enter second number...");
 int Number3 = Convert.ToInt32(Console.ReadLine());

 int max = Number1;
 
if (Number2 > max ) max = Number2;
if (Number3 > max ) max = Number3;

 Console.WriteLine(max);
