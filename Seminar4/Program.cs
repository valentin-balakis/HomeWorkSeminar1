// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
 Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int B = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < B; i++)
        {
            result *= A;
        }

        Console.WriteLine($"Результат: {result}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
 Console.Write("Введите число: ");
        string input = Console.ReadLine();

        int sum = 0;
        foreach (char digitChar in input)
        {
            if (char.IsDigit(digitChar))
            {
                int digit = int.Parse(digitChar.ToString());
                sum += digit;
            }
        }

        Console.WriteLine($"Сумма цифр числа: {sum}");

*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

Console.Write("Введите количество элементов в массиве (m): ");
        int m = int.Parse(Console.ReadLine());

        int[] array = new int[m];

        Console.WriteLine($"Введите {m} элементов массива:");

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введенный массив:");

        for (int i = 0; i < m; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine();