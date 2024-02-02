void writeNumbersInTheInterval(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        writeNumbersInTheInterval(m + 1, n);
    }
}

int m = 3;
int n = 12;
writeNumbersInTheInterval(m, n);