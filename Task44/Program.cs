// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Febbonachi (int n)
{
    int[] arr = new int[n];
    if (n ==1) arr[0]= 0;
    if (n ==2) 
    {
        arr[0] = 0;
        arr[1] = 1;
    }
    for (int i = 2; i < n; i++)
    {
        arr[0] = 0;
        arr[1] = 1;
        arr[i] = arr[i-2] + arr[i-1];
    }
    return arr;

}

void PrintArray (int[] arr)
{
    for(int i=0; i <arr.Length; i++)
    {
        if (i<arr.Length-1 ) Console.Write($"{arr[i]} ");
        else Console.Write(arr[arr.Length-1]);
    }
}


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = Febbonachi(number);
PrintArray (array);

