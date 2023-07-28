//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine ("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num >= 1000)
{
    Console.WriteLine ("Введено некорректное значение");
    return;
}
int secondNum = num / 10 % 10;
Console.WriteLine($"Вторая цифра {secondNum}");
*/

// Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).

/*
Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdDigit = GetThirdDigit(num);

if (thirdDigit != -1)
{
    Console.WriteLine ("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine ("Третьей цифры в числе нет");
}

int GetThirdDigit(int num)
{
    num = Math.Abs(num);

int numOfDigits = (int)Math.Log10(num) + 1;

    if (numOfDigits < 3)
    return -1;


while (numOfDigits > 3)
{
    num = num /= 10;
    numOfDigits--;
}
   
    return num % 10;
}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum < 1 || dayNum >= 8)
{
Console.WriteLine ("Введено некорректное значение");
}

bool isWeekend = IsWeekend(dayNum);

if (isWeekend)
{
    Console.WriteLine("Это выходной день");
}
else
{
Console.WriteLine("Это рабочий день");
}

bool IsWeekend (int dayNum)
{
    return dayNum == 6 || dayNum == 7;
}