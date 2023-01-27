Console.WriteLine("Подсчитаем сумму элементов на нечетных позициях");
Console.WriteLine("Введите число - длину массива");
if(!int.TryParse(Console.ReadLine(), out int n))
{
Console.WriteLine("Введено нецелое число");
return;
}
int[] FillArray(int n)
{
    int[] array = new int[n];
    Random random = new Random();
        for (int i = 0; i < n; i++) {
        array[i] = random.Next(-100,101);
        }
    return array;
}
void PrintArray(int[] array)
{
 for (int i = 0; i < n; i++)
 {
  Console.Write(array[i] + " ");
}
}
int[] arr = FillArray(n);
Console.WriteLine("Внимание, ваш массив:");
PrintArray(arr);
Console.WriteLine();

int SumOfOddPlaces(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}

int result = SumOfOddPlaces(arr);
Console.WriteLine($"Сумма чисел на нечетных позициях равна {result}");