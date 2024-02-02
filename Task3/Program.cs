int[] arr = [1, 2, 5, 0, 10, 34, 90];
int i = 0;
void reversArray(int[] arr, int i)
{
    if (i < arr.Length)
    {
        Console.WriteLine(arr[arr.Length - 1 - i]);
        reversArray(arr, i + 1);
    }
}

reversArray(arr, i);