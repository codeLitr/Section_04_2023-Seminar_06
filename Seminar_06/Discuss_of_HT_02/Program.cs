// Обсуждение домашнего задания к Семинару №4:

// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// МОЙ Вариант решения: 

// System.Console.Write("Введите число, состоящее минимум из двух цифр: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// if(digit < 10)
// {
//     System.Console.WriteLine("Ошибка ввода - введено число, состоящее из одной цифры, введите другое число!");
//     return;
// }

// char[] convert = digit.ToString().ToCharArray();
// int[] numbers = new int[convert.Length];

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = convert[i] - '0';
//     //Console.WriteLine("[{0}]={1}", i, numbers[i]);
// }
// int summ = Summ(numbers);
// Console.Write($"Сумма цифр в введенном числе {digit} -> " + summ);

// int Summ(int[] numbers)
// {
//     int summ = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         summ += numbers[i];
//     }
//     return summ;
// }

// ВАРИАНТ Решения преподавателя:

System.Console.Write("Введите число, состоящее минимум из двух цифр: ");
int digit = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (digit != 0)
{
    summ += digit % 10;
    digit /= 10;
}

System.Console.WriteLine($"Сумма цифр в введенном числе -> " + summ);
