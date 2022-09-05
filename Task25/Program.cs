//                    Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(A);

Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(B);

int ExponentA = A;

for (int i = 1; i < B; i++)
{
    ExponentA = ExponentA * A;
}

Console.WriteLine($"{A} в степени {B} = {ExponentA}");



