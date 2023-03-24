// Обсуждение домашнего задания к Семинару №4:

// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//МОЙ вариант решения:

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numbA = InputNumberWithMessage("Введите число А: ");
int numbB = InputNumberWithMessage("Введите число B: ");

System.Console.WriteLine();

System.Console.Write($"А теперь программа возведет число {numbA} в {numbB}-ую степень -> ");

int raisePow = (int)Math.Pow(numbA, numbB);

System.Console.WriteLine(raisePow);

//ВАРИАНТ преподавателя совпадает.