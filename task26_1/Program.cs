Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(count =0; number > 0; count++)
    {
       number = number / 10; 
    }
Console.WriteLine (count);