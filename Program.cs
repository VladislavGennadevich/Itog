void Print(string[] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

string[] mass = { "hello", "2", "world", ":-)" };

Print(mass);

string[] result = new string[mass.Length];
int j = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].Length < 4)
    {
        result[j] = mass[i];
        j++;
    }
}
Array.Resize(ref result, j);
Print(result);