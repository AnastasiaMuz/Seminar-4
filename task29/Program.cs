﻿//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вводим массив через консоль


int [] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
     Console.WriteLine ("Введите элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.Write (string.Join(", ", array));