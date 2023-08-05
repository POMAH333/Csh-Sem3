// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Вариант для любого целого положительного числа

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 1;
int numI = num;
int leghtNum = 1;
double maxNum = 0;
double minNum = 0;
bool pal = true;

while (numI > 9)
{
    leghtNum++;
    numI /= 10;
}

if (leghtNum < 2) pal = false;

while (i <= leghtNum / 2)
{
    maxNum = Math.Truncate((num % Math.Pow(10, leghtNum - i + 1)) / Math.Pow(10, leghtNum - i));
    minNum = Math.Truncate((num % Math.Pow(10, i)) / Math.Pow(10, i - 1));

    if (maxNum != minNum) pal = false;

    i++;
}

if (pal)
{
    System.Console.WriteLine($"Введённое число {num} является палиндромом");
}
else
{
    System.Console.WriteLine($"Введённое число {num} не является палиндромом");
}

