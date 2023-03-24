// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InvitationToInput(String message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

void PrintArrayInConsosole(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int[] ResizeArray(int[] array, int newSize) // Разворот массива
{
    int[] newArray = new int[newSize];

    for (int i = 0; i < newArray.Length; i++)
    {
        if (i >= array.Length)
            break;

        newArray[i] = array[i];
    }
    return newArray;
}

void PrintReverseArray(int[] array) // Вывод развернутого массива
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        System.Console.Write(array[i] + " ");
    }
}

int number = InvitationToInput("Введите число: ");

int[] remaindersOfTheDivision = new int[10];
int index = 0;
int courrentRemainderOfTheDivision;

while (number != 0)
{
    courrentRemainderOfTheDivision = number % 2;
    remaindersOfTheDivision[index] = courrentRemainderOfTheDivision;
    number /= 2;
    index++;

    if (index == remaindersOfTheDivision.Length - 1)
        remaindersOfTheDivision = ResizeArray(remaindersOfTheDivision, remaindersOfTheDivision.Length +10);
}

remaindersOfTheDivision = ResizeArray(remaindersOfTheDivision, index);
PrintReverseArray(remaindersOfTheDivision);
