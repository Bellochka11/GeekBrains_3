// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3 78 -> 2 89126 -> 5


void main()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.WriteLine(result(num));
}

int result(int number)
{
    if (number < 0) number *= -1; // если пользователь вводит отрицат число то умножаем на -1 чтобы получить положит число
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
 main();



