// напимать программу на ввод принимает 2 числа и выдает, какое число больше
Console.Write("Enter first number..."); 
 int Number1 = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Enter second number..."); 
 int Number2 = Convert.ToInt32(Console.ReadLine()); 
 int max = 0;

 if (Number1 > Number2)
 {
     max = Number1;
 }
 else
 {
     max = Number2;
 }
 Console.WriteLine("max" + max);

