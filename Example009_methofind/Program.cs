Console.Clear();

int[] array = {10,18,22,33,14,15,14,16,17,18};

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}