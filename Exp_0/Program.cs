void Method(int maximum)
{
    int minimum;
    minimum = -maximum;
    while (minimum <= maximum)
    {
        Console.WriteLine(minimum + " ");
        minimum++;
    }
}

int[] CreateArray(int N)
{
    int[] arrayA = new int [N*2 + 1];
    for (int i = -N; i < N; i++)
    {
        arrayA[i+ N] = i;
    }
    return arrayA;
}
// Лучший вариант
int Ar(int N)
{
    int x = -N;
    while (x <= N)
    {
        Console.WriteLine(x);
        x++;    
    }
    return x;
}

void Numbers(int n)
{
    int lenght = n + n;
    for (int i = 0; i < lenght +1; i++)
    {
        Console.WriteLine(-n + i);
    }
}
// Худший
string NumShow(int N)
{
    string NumsShow = "";
for (int i = -N; i < N; i++)
{
    NumsShow = NumsShow + i + " ";
}
    return NumsShow;
}

int af = -5;
int nf = 5;
Console.WriteLine($"{af}..{nf}");
