// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();
Write("Введите число: ");
int num = Convert.ToInt32(ReadLine());
int temp = num;
int sum = 0;
while (temp>0)
{
    sum = sum + temp%10;
    temp = temp/10 ;
}
WriteLine($"Сумма цифр в числе {num} будет {sum}");