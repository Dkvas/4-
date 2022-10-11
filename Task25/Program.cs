// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();
Write("Введите число: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите натуральную степень: ");
int B = Convert.ToInt32(ReadLine());
int Res=A;
for(int i=1; i<B; i++) 
    {
        Res= Res*A;
    }
  WriteLine($"Число {A} в степени {B} равняется {Res}");