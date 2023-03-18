// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

bool CheckSquare(int num1, int num2)
{
    return num1==num2*num2 || num2==num1*num1;
}
   
Console.WriteLine("Введите первое натуральное число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:  ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool checkSquare = CheckSquare(number1, number2);
Console.WriteLine(checkSquare ? "Да": "Нет");
    