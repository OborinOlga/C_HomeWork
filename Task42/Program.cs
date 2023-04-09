// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] ChangeToBinaryNumber (int num)
{
    int[] arr = new int[8];
    if (num == 0) arr[arr.Length-1] = 0;
    int i = 0;
    while (num > 0)
    {
        if (num%2 ==0) arr[arr.Length-1-i] = 0;
        else arr[arr.Length-1-i] = 1;
        num = num/2;
        i++;
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for(int i=0; i <arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}


Console.WriteLine("Введите натуральное десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = ChangeToBinaryNumber(number);
PrintArray (array);
