﻿/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
System.Console.WriteLine("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1-k2);
var y = k1 * x + b1;
Console.WriteLine($"Точка пересечения прямых имеет координаты {"x = " + "[" + x + "]"} {"y = " + "[" + y + "]"}");


/* Console.WriteLine(x);
Console.WriteLine(y); */