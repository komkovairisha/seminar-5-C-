﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInt("Введите значение числа M: ");
int n = InputInt("Введите значение числа N: ");

    int InputInt(string output)
    {
     Console.Write(output);
    return int.Parse(Console.ReadLine());
    }
        
        int CountNaturalSum(int m, int n)
        {
            if (m == n)
                 return n;
                return n + CountNaturalSum(m, n - 1);
        }
if (n<m)
    {
    Console.WriteLine("Значение числа M должно быть больше, чем N. Попробуйте снова.");
    }                    
    else
Console.WriteLine($"Сумма чисел от {m} до {n} равна {CountNaturalSum(m, n)}");

        
        



