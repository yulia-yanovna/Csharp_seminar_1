// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.

static int[] MyArray(int num)
{
    int tempNum = num;
    int Count = (int)Math.Floor(Math.Log10(num) + 1);
    int[] newArray = new int[Count];

    for (int i = Count - 1; i >= 0; i--)
    {
        newArray[i] = tempNum % 10;
        tempNum /= 10;
    }
    Array.Sort(newArray);
    Array.Reverse(newArray);
    return newArray;
}

Console.Write("Введите натуральное число в диапазоне от 1 до 100000: ");
if (int.TryParse(Console.ReadLine(), out int number)&& number >= 1 && number <=100000){
    int[] array = MyArray(number);
    Console.WriteLine("[" + string.Join(", ", array) + "]");
} 
else{
    Console.WriteLine("Введите корректное число в указанном диапазоне");
}
