Console.WriteLine("Подсчитаем количество четных числе в массиве");
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
        array[i] = random.Next(100,1000);
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

int NumbersOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int result = NumbersOfEven(arr);
Console.WriteLine($"Количество четных элементов в массиве равно {result}");
