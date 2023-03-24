// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int HowManyNumbersYouWant(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int howMany = HowManyNumbersYouWant("Введите требуемое кол-во чисел: ");

int[] numbers = new int[howMany];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = HowManyNumbersYouWant($"Введите число {i + 1}: ");
}

Console.Write("{0}", string.Join(", ", numbers) + " -> ");

int HowManyNumbersHigherZero(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

System.Console.WriteLine(HowManyNumbersHigherZero(numbers));