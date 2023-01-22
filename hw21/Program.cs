// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 Console.WriteLine("Enter x1...");
 int x1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter y1...");
 int y1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter z1...");
 int z1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter x2...");
 int x2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter y2...");
 int y2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter z2...");
 int z2 = int.Parse(Console.ReadLine());

 double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((y2 - y1), 2));
 Console.WriteLine("длинна отрезка"+result);

 Console.WriteLine($"A ({x1},{y1},{z2}); B ({x2},{y2},{z2}) -> {result}");

 // через другую команду
// internal class Program
//{
  //  private static void Main(string[] args)
    //{
        //Console.WriteLine("Введите координаты точки А через пробел");
        //string xyz = Console.ReadLine()!;
        //string[] partsA = xyz.Split(' ');
        //int xA = int.Parse(partsA[0]);
        //int yA = int.Parse(partsA[1]);
        //int zA = int.Parse(partsA[2]);

        //Console.WriteLine("Введите координаты точки B через пробел");
        //xyz = Console.ReadLine()!;
        //string[] partsB = xyz.Split(' ');
        //int xB = int.Parse(partsB[0]);
        //int yB = int.Parse(partsB[1]);
        //int zB = int.Parse(partsB[2]);

        //double distsnce = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

        //Console.WriteLine($"Расстояние между точкой А и точкой B = {distsnce:F2}");
    //}
//}

