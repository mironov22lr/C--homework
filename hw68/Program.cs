// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Console.WriteLine("Введите число m: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число n: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//int Akkerman = A(m, n);

//Console.Write($"A(m,n) = {Akkerman} ");

//int A(int m, int n)
//{
//  if (m == 0) return n + 1;
//  else if ((m > 0) && (n == 0)) return A(m - 1, 1);
//  else return (A(m - 1, A(m, n - 1)));
//}

// 2 variant!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

//int m = InputNumbers("Введите m: ");
//int n = InputNumbers("Введите n: ");

//int functionAkkerman = Ack(m, n);

//Console.Write($"Функция Аккермана = {functionAkkerman} ");

//int Ack(int m, int n)
//{
 // if (m == 0) return n + 1;
 // else if (n == 0) return Ack(m - 1, 1);
 // else return Ack(m - 1, Ack(m, n - 1));
//}

//int InputNumbers(string input) 
//{
 // Console.Write(input);
  //int output = Convert.ToInt32(Console.ReadLine());
 // return output;
//}

//var3!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

//Console.Write("Введите число M: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите число N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//AkkermanFunction(m,n);


// вызов функции Аккермана
//void AkkermanFunction(int m, int n)
//{
//    Console.Write(Akkerman(m, n)); 
//}

// функция Аккермана
//int Akkerman(int m, int n)
//{
    //if (m == 0)
   // {
   //     return n + 1;
   // }
    //else if (n == 0 && m > 0)
    //{
   //     return Akkerman(m - 1, 1);
   // }
   // else
  //  {
  //      return (Akkerman(m - 1, Akkerman(m, n - 1)));
   // }
//}

// var4!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

 
//// функция Аккермана
////static uint A(uint n, uint m)
////{
 //// if (n == 0)
   //// return m + 1;
  ////else
    ////if ((n != 0) && (m == 0))
      ////return A(n - 1, 1);
    ////else
      ////return A(n - 1, A(n, m - 1));
////}

		