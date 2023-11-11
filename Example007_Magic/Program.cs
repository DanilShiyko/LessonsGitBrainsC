Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");


int xa = 30, ya = 1;
int xb = 1, yb = 20;
int xc = 60, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }   

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;  
}



//using System;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int left = 50;
//        int top = 35;

//        // Проверяем размеры буфера консоли
//        if (left >= 0 && left < Console.BufferWidth && top >= 0 && top < Console.BufferHeight)
//        {
//            Console.SetCursorPosition(left, top);
//            Console.WriteLine("+");
//        }
//        else
//        {
//            Console.WriteLine("Недопустимые значения позиции курсора.");
//        }
//    }
//}