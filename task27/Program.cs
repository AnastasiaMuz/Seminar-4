// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int res;

int sum = 0;

while(number1 > 0)
{
   res = number1 % 10;
   sum = sum + res;
   number1 = number1 / 10;
}


Console.WriteLine ($"Сумма цифр в числе {number} равна {sum}");
