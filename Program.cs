using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество слагаемых для вычисления числа π: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double pi = 0.0;

        // Вычисление π по формуле
        for (int i = 0; i < n; i++)
        {
            // Каждый член ряда: (-1)^i / (2*i + 1)
            double term = (i % 2 == 0 ? 1.0 : -1.0) / (2 * i + 1);
            pi += term;
        }

        // Умножаем на 4 для получения значения π
        pi *= 4;

        Console.WriteLine($"Приближенное значение числа π с использованием {n} слагаемых: {pi}");
    }
}