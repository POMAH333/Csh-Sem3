﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    if((num / 10000) == (num % 10) && (num % 10000) / 1000 == (num % 100) / 10)
        {
            System.Console.WriteLine($"Число {num} является палиндромом");
        }
        else
        {
            System.Console.WriteLine($"Число {num} не является палиндромом");
        }
}
else
{
    System.Console.WriteLine("Введённое число не является пятизначным");
}