int[] array = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write("{0} ", col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);


