
int N;
Console.Write($"Введите количество элементов массива: ");
int.TryParse(Console.ReadLine()!, out N);

String[] array = new String[N];

for (int curind = 0; curind < N; curind++)
{
    Console.Write($"Введите элемент номер {curind} ");
    array[curind] = Console.ReadLine()!;
} 


String[] array_new = new String[N];
int i = 0;

for (int curind=0;curind<array.Length;curind++)
{
    if (array[curind].Length <= 3)
    {
        array_new[i] = array[curind];
    }
    i++;
}

for (int j=0;j<i;j++)
{
    Console.Write($"{array_new[j]} ");
}
