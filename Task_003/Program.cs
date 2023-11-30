// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

using System.Text.RegularExpressions;

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateArray(int size, int leftRange, int rigthRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rigthRange) + rand.NextDouble(), 2);
    }
    return tempArray;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void PrintAnswer(double[] Array)
{
    double Nmin = 0;
    double Nmax = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] > Nmax)
        {
            Nmax = Array[i];
        }        
    }
    Nmin = Nmax;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] < Nmin)
        {
            Nmin = Array[i];
        }
    }    
        Console.WriteLine(Nmax - Nmin);
}

int size = ReadInt("Введите размер массива: ");
double[] myArray = GenerateArray(size, 1, 100);
PrintArray(myArray);
PrintAnswer(myArray);