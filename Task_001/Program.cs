// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rigthRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rigthRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void PrintAnswer(int[] Array)
{
    int Answer = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] >= 20 && Array[i] <= 90)
        {
            Answer++;
        }
    }
    Console.WriteLine(Answer);
}

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 1, 100);
PrintArray(myArray);
PrintAnswer(myArray);