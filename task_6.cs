using System;


// 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void CounterArray(int[] array)
{
    int sum = 0;

    foreach (int i in array)
    {
        if (i > 0)
        {
            sum += 1;
        }
    }

    Console.WriteLine($"Сумма чисел больше 0 составляет: {sum}");

}


int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива. Введите вещественное число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"[{String.Join("; ", array)}]");


    return array;
}

CounterArray(CreateArray());



/*

// 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//    y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Intersection(int b1, int k1, int b2, int k2)
{
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые совпадают");
        return;
    }

    else if (b1 == b2 || k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
        return;
    }

    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

}

Console.WriteLine("Введите число для b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число для k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число для b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число для k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());


Intersection(b1, k1, b2, k2);

*/


















