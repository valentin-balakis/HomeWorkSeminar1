// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} - больше, {num2} - меньше");
}
else 
{
    Console.WriteLine($"{num1} - меньше, {num2} - больше");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNamber = Math.Max(num1, Math.Max(num2, num3));

Console.WriteLine("Максимальное число: " + maxNamber);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isEven = number % 2 == 0;

if (isEven)
{
    Console.WriteLine("Да");
}
else
{
     Console.WriteLine("Нет");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;
Console.WriteLine("Четные числа от 1 до " + number + ":");

while (current <= number)
{
 if (current % 2 == 0)
 {
    Console.Write(current + " ");
 }
    current++;
 }
 