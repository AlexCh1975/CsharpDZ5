/*
    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
*/

Console.Clear();

Console.Write("Введите число -> размер массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = CreateArray(length);
int evenNumbers = CheckingEvenNumbers(array);
PrintArray(array, evenNumbers);

int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rend = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rend.Next(100, 1000);
    }

    return array;
}

int CheckingEvenNumbers(int[] array)
{
    int evenNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNumbers++;
        }
    }

    return evenNumbers;
}

void PrintArray(int[] array, int evenNumbers)
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[ ");
    
    for (int i = 0; i<= array.Length -1; i++)
    {
        if (i == array.Length -1)
        {
            Console.Write($"{array[i]} "); 
        }
        else 
        {  
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine($"] четных чисел: {evenNumbers}");
    Console.ResetColor();
}