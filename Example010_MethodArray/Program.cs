int[] array = { 11, 21, 31, 14, 53, 31, 17, 85 };

int n = array.Length;
int find = 31;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"индекс {index}");
        break;
    }
    index++;
}