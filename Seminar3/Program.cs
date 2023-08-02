// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 10000 || num > 99999) Console.WriteLine("Введено некорректное значение");
else if (IsPalindrome(num))
{
    Console.WriteLine("Число является палидромом ");
}
else
{
Console.WriteLine("Число не является палиндромом");
}

bool IsPalindrome(int num)
    {
     string numberString = num.ToString();

        for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }


/* Console.WriteLine("Введите пятизначное число:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (IsPalindrome(number))
                {
                    Console.WriteLine("Да, число является палиндромом.");
                }
                else
                {
                    Console.WriteLine("Нет, число не является палиндромом.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое пятизначное число.");
            }
        

        // Функция для проверки, является ли число палиндромом
        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();

            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
*/


//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double DecartDistanceFinder(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

double x1;
double y1;
double z1;
double x2;
double y2;
double z2;

Console.WriteLine ("Ведите координаты первой точки: ");
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Ведите координаты второй точки: ");
x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToDouble(Console.ReadLine());
z2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Растояние между точками {0:f2}",  DecartDistanceFinder(x1, y1, z1, x2, y2, z2));
*/


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int n;
Console.Write ("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

void PowerPrinter(int n)
{
    for (int i = 1; i <=n; i++)
    {
        Console.WriteLine(i + " - " + Math.Pow(i, 3));
    }
}

PowerPrinter(n);
*/