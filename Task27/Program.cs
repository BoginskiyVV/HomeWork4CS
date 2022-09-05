//                              Задача 27 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = 0;

while (Number > 0)
{
    int i = Number % 10;
    Number = Number / 10;
    sumNumbers = sumNumbers + i;
}
Console.WriteLine($"Сумма цифр в цисле равна {sumNumbers}");
