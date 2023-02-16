//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28 4 -> 10 8 -> 36

int GetSum(int A)
{
    int sum = 0;
    if (A > 1)
    {
        for (int i = 1; i <= A; i++) // i = i + 1 // i += 1
        {
            sum += i; // sum = sum + i
        }
    }

    return sum;
}

Console.Write("Введите А: ");
int n = int.Parse(Console.ReadLine()!);
int sum = GetSum(n);
Console.WriteLine($"{sum}");