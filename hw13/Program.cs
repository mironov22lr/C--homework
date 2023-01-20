Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 100)
 {
    Console.Write("третьей цифры нет");
 }
else
{
while (x >= 1000)
{
    x = x / 10;
}

if (x < 1000)
 { 
    int three = x % 100;
    int tow = three % 10;
    Console.Write(tow);
 }
 }