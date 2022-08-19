/*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/

Console.Clear();

Console.Write("Введите число -> размер массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = CreateArray(length);
int sumElements = SumOfElementsOfEvenArrayPositions(array);
PrintArray(array, sumElements);

int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rend = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rend.Next(-100, 100);
    }

    return array;
}

int SumOfElementsOfEvenArrayPositions(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 ==1)
        {
            sumElements += array[i]; 
        }
    }
    return sumElements;
}

void PrintArray(int[] array, int sumElements)
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
    Console.WriteLine($"] сумма чисел на не четных позициях: {sumElements}");
    Console.ResetColor();
}