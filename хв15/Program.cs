// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 Console.Write("Enter number of day"); 
 int number = Convert.ToInt32(Console.ReadLine()); 
 if (number >= 1 && number <=5) 
 {
     Console.WriteLine("is not Day off");
 }
 else if (number==6 || number ==7)
 {
     Console.WriteLine ("This is Day Off? Yraaa!");
 }
 else 
 {
   Console.WriteLine("data entry error");
 }
// Console.WriteLine ("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
      //Console.WriteLine ("Введите день недели...");
     // int dayofweek = int.Parse (Console.ReadLine());
     // if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Ответ: Выходной день.");
     // else if (dayofweek <= 5) Console.WriteLine ("Ответ: Будний день.");
     // else if (dayofweek > 7) Console.WriteLine ("Ошибка: В неделе всего 7 дней!");
