// массив заполнить, печать, ищем индекс



void FillArray(int[] collection) // заполняет массив рандомными числами массив коллекшон
{
    int length = collection.Length; // длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // печатает массив на экран массив кол
{
    int count = col.Length; //длина массива
    int position = 0; //индекс
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // ищем индекс, который совпадет с файнд
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если мы будем искать не существующий элемент, которого нет в массиве то покажет -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int [10];  // массив из 10 элементов, заполненных нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);