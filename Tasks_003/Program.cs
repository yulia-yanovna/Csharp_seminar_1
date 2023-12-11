// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

int ReadInt(string text)

{
     Console.Write(text);
     return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введите размер массива: ");
double[] array = new double[size];
Random rand = new Random();
for(int i = 0; i < array.Length; i++){
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
}

double maxNumber = array[0];
double minNumber = array[0];

foreach (double num in array)
{
    if (num > maxNumber)
                maxNumber = num;
    
    if (num < minNumber)
                minNumber = num;
}
double diff = maxNumber - minNumber;
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Разница между максимальным {maxNumber} и минимальным {minNumber} элементами массива = {diff}");
