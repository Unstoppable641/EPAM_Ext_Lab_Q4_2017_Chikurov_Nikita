﻿/* 
 Задание 5
Если выписать все натуральные числа меньше 10, кратные 3, или 5, то
получим 3, 5, 6 и 9. Сумма этих чисел будет равна 23. Напишите
программу, которая выводит на экран сумму всех чисел меньше 1000,
кратных 3, или 5. 
 */
namespace Task05
{
    using System;

    public class Program
    {
       public static void Main(string[] args)//todo pn частное решение для общей задачи
       {
            var sum = 0;
            for (var i = 1; i < 1000; i++)//todo pn хардкод
            {
                if (i % 3 == 0 || i % 5 == 0)//todo pn хардкод
				{
                    sum += i;
                }
            }

            Console.Write($"The sum of numbers less than 1000, multiples of 3 or 5 is equal to: {sum} \n");
            Console.ReadKey();
        }
    }
}