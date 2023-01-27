Console.WriteLine("Найдем разницу между максимальным и минимальным элементами массива");
Console.WriteLine("Введите число - длину массива");
if(!int.TryParse(Console.ReadLine(), out int n))
{
Console.WriteLine("Введено нецелое число");
return;
}

void FillArray(double[] array)
{
       for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}
double[] arr = new double[n];
FillArray(arr);

void PrintArray(double[] array)
{
 for (int i = 0; i < n; i++)
 {
  Console.Write(array[i].ToString("##.##") + " ");
}
}
Console.WriteLine("Внимание, ваш массив:");
PrintArray(arr);
Console.WriteLine();

double MaxMin(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];
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
    result = max - min;
    return result;
}

double result = MaxMin(arr);
Console.WriteLine($"Разница между максимальным и минимальными элементами массива равна {result.ToString("##.##")}");
