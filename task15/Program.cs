﻿// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет,
//   является ли этот день выходным.
//   6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите день :");
int day = Convert.ToInt32(Console.ReadLine());
if(day < 6)
{
    Console.WriteLine("Нет");
} else
{
    Console.WriteLine("Да");
}
