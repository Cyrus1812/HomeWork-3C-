Console.WriteLine("Введите положительное N");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if (!isNumberN)
{
    Console.WriteLine("Не число");
    return;
}

PrintSqares (GetSqares(N));
int[] GetSqares(int n)
{
    int i = 1;
    int[] results = new int[n];
    while (i <= n)
    {
        results[i-1] = (int) Math.Pow (i,3);
        i++;
    }
    return results;
}

void PrintSqares(int[] sqares) 
{
    int i = 0;
    int len = sqares.Length;
    while (i < len)
    {
        Console.WriteLine(sqares[i]);
        i++;
    }
}