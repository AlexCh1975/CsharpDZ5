/*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
    максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
*/

Console.Clear();
 
Console.Write("Введите число -> размер массива: ");
int length = int.Parse(Console.ReadLine());

double max, min;
double[] array = CreateArray(length);
double differenceMaxAndMin = DifferenceBetweenMaxAndMinArrayElement(array, out max, out min);
PrintArray(array, differenceMaxAndMin, max, min);

double[] CreateArray(int length)
{
    double[] array = new double[length];
    Random rend = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rend.NextDouble()) * 100, 2);
    }

    return array;
}

double DifferenceBetweenMaxAndMinArrayElement(double[] array, out double max, out double min)
{
    max = array[0];
    min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return Math.Round((max - min), 2);
}


void PrintArray(double[] array, double differenceMaxAndMin, double max, double min)
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
            Console.Write($"{array[i]}; ");
        }
    }
    Console.WriteLine($"] разница между максимальным {max} и минимальным {min} элементами массива: {differenceMaxAndMin}");
    Console.ResetColor();
}