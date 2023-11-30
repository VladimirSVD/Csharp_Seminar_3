// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен 
// располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

Random rand = new Random();
int N = rand.Next(1, 10000);
Console.WriteLine($"Сгенерированное число = {N}");

int size = 0;
int i = 1;
int X = 0;

while(X != N)               // ищем size - количество цифр в N = размер массива
{
   i *= 10;
   X = N % i;
   size++;
}

int[] Array = new int[size];
for(int k = 0; k < size; k++)   
{
   X = (N % i) / (i / 10);
   Array[k] = X;
   i /= 10;
}
void PrintArray(int[] array)
{
    Console.WriteLine("Полученный массив: [" + string.Join(", ", array) + "]");
}
PrintArray(Array);