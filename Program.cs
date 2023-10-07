// Самостоятельная работа
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.



      {
        Console.WriteLine("Введите длины трех сторон треугольника:");

        // Ввод длин сторон
        Console.Write("Сторона A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Проверка условия треугольника
        if (IsTriangle(a, b, c))
        {
            Console.WriteLine("Треугольник существует.");
        }
        else
        {
            Console.WriteLine("Треугольник не существует.");
        }
    }

    // Функция проверки неравенства треугольника
    static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

