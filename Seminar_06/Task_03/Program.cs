// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("start");
int N = Convert.ToInt32(Console.ReadLine());
int firstNumber = 0;
int secondNumber = 1;
System.Console.Write(firstNumber + " ");
for (int i = 2; i <= N; i++)
{
    System.Console.Write(secondNumber + " ");
    int buf = secondNumber;
    secondNumber = secondNumber + firstNumber;
    firstNumber = buf;
}
