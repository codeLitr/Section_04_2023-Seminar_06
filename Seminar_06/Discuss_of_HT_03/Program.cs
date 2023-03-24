// Обсуждение домашнего задания к Семинару №4:

// Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// МОЙ Вариант решения: 

// int[] numbers = new int[8];
// Random rnd = new Random();

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = rnd.Next(0, 100); // Диапазон случайный, т.к. у в условиях задачи нет уточнения.
// }
// // Далее делает вывод, как это показано в примере задачи, т.е. сначала выводит выбранные числа ("Random"), затем выводит массив в [] скобках.
// Console.Write("{0}", string.Join(", ", numbers) + " -> "); 
// Console.Write("[{0}]", string.Join(", ", numbers));

// ВАРИАНТ Решения преподавателя:

int Promt(String message) // Метод вывода числа на экран
{
    System.Console.WriteLine(message); // Приглошение ко вводу чисел
    string ReadInput = System.Console.ReadLine(); // Конструкция для считывания вводимых данных
    int result = int.Parse(ReadInput); // Приводим к числу
    return result; // Возвращаем результат
}

int[] GenerateArray(int Lenght, int minValue, int maxValue) // Метод для генирации массива случайных чисел
{
    int[] array = new int[Lenght]; // Обьявления массива
    Random random = new Random(); // Герератор случайных чисел
    for (int i = 0; i < Lenght; i++) // Оператор/условия
    {
        array[i] = random.Next(minValue, maxValue +1); // Заполняем масив случайными числами от min to max
    }
    return array;
}

void PrintArray(int[] array) // Функция для вывода массива
{
    System.Console.Write("[");
    for (int i =0; i < array.Length -1; i++)
    {
        System.Console.Write($"{array[i]}, "); // Вывод значения масива
    }
    System.Console.Write($"{array[array.Length-1]}"); // Вывод значения масива
    System.Console.WriteLine("]");
}

int lenght = Promt("Длина массива: ");
int min = Promt("Начальное значение, случайного числа: ");
int max = Promt("Конечсное значение, случайного числа: ");
int[] array = GenerateArray(lenght, min, max); // Заполнение масива случайными числами

PrintArray(array);
