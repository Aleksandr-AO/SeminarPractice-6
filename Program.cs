/*Задача 41:
Пользователь вводит с клавиатуры М чисел. 
Посчитайте, сколько чисел больше 0 ввел пользователь.
0, 7, 8 , -2, -2, -> 2;
-1, -7, 567, 89, 223 -> 3;
*/
Console.WriteLine($"Enter the number M (Count of numbers):" );
int M = Convert.ToInt32(Console.ReadLine());
int [] size = new int [M];

void InputNumb (int M)
{
    for (int i = 0; i < M; i++)
    {
    Console.Write($"Enter {i + 1} Number: ");
    size [i] = Convert.ToInt32(Console.ReadLine());
    }
}

int  CountNumberPos(int [] size)
{
    int count = 0;
    for (int i = 0; i < size.Length; i++)
    {
        if (size[i] > 0)
        count += 1;
    }
    return count;
}

InputNumb(M); 
Console.WriteLine($"Count the number M more 0 --> {CountNumberPos(size)} ");

/*
Задача 43:
Напишите программу, которая найдет точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
 */

Console.WriteLine ("Enter the coefficient k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter the coefficient k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter a value b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter a value b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

void point(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
Console.WriteLine ("Straight lines are parallel");
    else 
    {
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
Console.WriteLine ($"The intersection point:  {x}; {y}");  
    }   
}

point(k1, k2, b1, b2);



