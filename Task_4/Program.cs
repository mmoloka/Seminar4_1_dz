﻿/*
 Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число больше 1 ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    for(int i = 2; i <= number; i = i + 2)
    {
    Console.Write(i);
    if(i != number) Console.Write(", ");  
    }
}
else
{
   for(int i = 2; i <= number; i = i + 2)
    {
    Console.Write(i);
    if(i != number - 1) Console.Write(", ");  
    } 
}
