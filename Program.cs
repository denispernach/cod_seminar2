// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10,100);
Console.WriteLine ($"Наше случайное число = {number}");
int digit1 = number / 10;
int digit2 = number % 10;
if (digit1 > digit2)
{
    Console.WriteLine($"Цифра {digit1} наибольшая");
}
else
{
    Console.WriteLine($"Цифра {digit2} наибольшая");
}
