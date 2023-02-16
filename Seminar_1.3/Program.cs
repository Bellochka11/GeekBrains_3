// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24  5 -> 120


int Mult(int arg)
{
    int x = 1;
    for (int i = 1; i <= arg; i++) // i = i + 1 // i += 1
    {
        x *= i; // sum = sum + i
    }

    return x;
}

Console.Write("Введите N: ");
int a = int.Parse(Console.ReadLine()!);
int total = Mult(a);
Console.WriteLine($"{total}");



