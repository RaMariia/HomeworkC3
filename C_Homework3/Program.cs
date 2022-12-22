//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
int Palindrom5(int num)
{
    if (0 < num/10000 && num/10000< 10)
        {
        int a =(num/10000);
        int b = (num%10);
        if (a == b)
            {
                int c = (num/1000%10);
                int d = (num %100/10);
                if  (c == d)
                    {
                        Console.Write("Да");
                        return num;
                    }     
            }
    Console.Write("Нет");
    return num;
    }
Console.Write("Число не является пятизначным");
return num;    
}

Console.Write("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Pal = Palindrom5(number);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return Math.Round(length, 2);
}
Console.Write("Введите координату х точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату х точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double DistanceBetweenAB = distance(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"Расстояние между точками A и B {DistanceBetweenAB}.");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*
int CubeOfNumber(int number)
{
    for (int i = 1; i <= number; i++)
        {
            Console.Write($"{i * i * i}, ");        
        }
     return number;
  
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Cube = CubeOfNumber(number);
*/

