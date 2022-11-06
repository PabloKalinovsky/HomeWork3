/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
void Polindrom(int n)
{
    if(n / 10000 == n % 10 && n / 1000 % 10 == n % 100 / 10)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

Console.Write("Input the 5 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number / 100000 == 0)
{
    Polindrom(number);
}
else
{
    Console.WriteLine("Wrong number. Please input 5digit number ");
}
*/
/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double Theorem(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double stor1 = x1 - x2;
    stor1 = Math.Pow(stor1, 2);
    double stor2 = y1 - y2;
    stor2 = Math.Pow(stor2, 2);
    double stor3 = z1 - z2;
    stor3 = Math.Pow(stor3, 2);
    double hipo = stor1 + stor2 + stor3;
    hipo = Math.Sqrt(hipo);
    return hipo;
}

Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());
double result = Theorem(x1, y1, z1, x2, y2, z2);
result = Math.Round(result, 2);
Console.WriteLine(result);
*/
/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Qube(int number)
{
    int current = 1;
    while(current <= number)
    {
        Console.Write(current*current*current + " ");
        current++;
    }
        
}
Console.Write("Input the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Qube(n);
*/