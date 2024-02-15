using System;
using System.Collections.Generic;

class Fibonacci<T>
{
    // Метод генерирует список из первых n чисел Фибоначчи
    public List<T> GenerateFibonacciNumbers(int n)
    {
        List<T> fibonacciList = new List<T>();

        dynamic a = (dynamic)0; // Первое число Фибоначчи
        dynamic b = (dynamic)1; // Второе число Фибоначчи

        for (int i = 0; i < n; i++)
        {
            fibonacciList.Add(a); // Добавление числа в список
            dynamic next = a + b; // Расчет следующего числа Фибоначчи
            a = b; // Обновление первого числа
            b = next; // Обновление второго числа
        }

        return fibonacciList;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел Фибоначчи для сгенерирования:");
        int count = int.Parse(Console.ReadLine());

        Fibonacci<dynamic> fibonacci = new Fibonacci<dynamic>(); // Создание экземпляра обобщенного класса Fibonacci
        List<dynamic> result = fibonacci.GenerateFibonacciNumbers(count); // Генерация чисел Фибоначчи

        Console.WriteLine("Первые " + count + " чисел Фибоначчи:");
        foreach (var number in result)
        {
            Console.Write(number + " "); // Вывод чисел Фибоначчи
        }
    }
}
