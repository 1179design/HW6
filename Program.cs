// Самостоятельная работа
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.



    //   {
    //     Console.WriteLine("Введите длины трех сторон треугольника:");

    //     // Ввод длин сторон
    //     Console.Write("Сторона A: ");
    //     double a = Convert.ToDouble(Console.ReadLine());

    //     Console.Write("Сторона B: ");
    //     double b = Convert.ToDouble(Console.ReadLine());

    //     Console.Write("Сторона C: ");
    //     double c = Convert.ToDouble(Console.ReadLine());

    //     // Проверка условия треугольника
    //     if (IsTriangle(a, b, c))
    //     {
    //         Console.WriteLine("Треугольник существует.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Треугольник не существует.");
    //     }
    // }

    // // Функция проверки неравенства треугольника
    // static bool IsTriangle(double a, double b, double c)
    // {
    //     return a + b > c && a + c > b && b + c > a;
    // }

//Напишите программу, которая будет преобразовывать десятичное число в двоичное


    // {
    //     Console.Write("Введите десятичное число: ");
    //     int DesyatichnoyeChislo = Convert.ToInt32(Console.ReadLine());

    //     string binaryNumber = DecimalToBinary(DesyatichnoyeChislo);

    //     Console.WriteLine($"Двоичное представление: {binaryNumber}");
    // }

    // static string DecimalToBinary(int DesyatichnoyeChislo)
    // {
    //     if (DesyatichnoyeChislo == 0)
    //     {
    //         return "0";
    //     }

    //     string binary = "";

    //     while (DesyatichnoyeChislo > 0)
    //     {
    //         int remainder = DesyatichnoyeChislo % 2;
    //         binary = remainder + binary;
    //         DesyatichnoyeChislo /= 2;
    //     }

    //     return binary;
    // }

//Задача 44: не используя рекурсию, выведи первые N числе Фибоначчи (0,1)
// Если N = 5-> 0 1 1 2 3
// Если N = 3-> 0 1 1
// Если N = 7-> 0 1 1 2 3 5 8


    // {
    //     Console.WriteLine("Введите количество чисел Фибоначчи (N):");

    //     if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
    //     {
    //         PrintFibonacci(n);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Некорректный ввод. Введите положительное целое число.");
    //     }
    // }

    // static void PrintFibonacci(int n)
    // {
    //     int[] fibNum = new int[n];

    //     // Первые два числа Фибоначчи
    //     fibNum[0] = 0;
    //     if (n > 1)
    //     {
    //         fibNum[1] = 1;
    //     }

    //     // Вычисление оставшихся чисел Фибоначчи
    //     for (int i = 2; i < n; i++)
    //     {
    //         fibNum[i] = fibNum[i - 1] + fibNum[i - 2];
    //     }

    //     // Вывод чисел Фибоначчи
    //     Console.WriteLine("Последовательность чисел Фибоначчи:");
    //     foreach (var num in fibNum)
    //     {
    //         Console.Write(num + " ");
    //     }
    // }

//Домашнее задание
//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь
    // {
    //     Console.WriteLine("Введите числа через запятую:");
    //     int count = Array.FindAll(Console.ReadLine().Split(','), s => int.Parse(s) > 0).Length;
    //     Console.WriteLine($"Количество чисел больше 0: {count}");
    // }


// Задача 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + 
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем

    // {
    //     Console.WriteLine("Введите значения k1, b1, k2, b2 через запятую:");

    //     string[] input = Console.ReadLine().Split(',');

    //     if (input.Length != 4)
    //     {
    //         Console.WriteLine("Некорректный ввод. Введите четыре значения.");
    //         return;
    //     }

    //     if (double.TryParse(input[0], out double k1) &&
    //         double.TryParse(input[1], out double b1) &&
    //         double.TryParse(input[2], out double k2) &&
    //         double.TryParse(input[3], out double b2))
    //     {
    //         if (k1 == k2)
    //         {
    //             Console.WriteLine("Прямые параллельны, нет точки пересечения.");
    //         }
    //         else
    //         {
    //             double x = (b2 - b1) / (k1 - k2);
    //             double y = k1 * x + b1;
    //             Console.WriteLine($"Точка пересечения: ({x}, {y})");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Некорректный ввод. Введите числовые значения.");
    //     }
    // }


