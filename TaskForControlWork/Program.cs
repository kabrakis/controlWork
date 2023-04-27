
string[] array1 = new string[] {"Hello", "2", "World", ":-)"};
string[] array2 = new string[array1.Length];


// метод печати массива
void Print1DArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-2; i++)
    {
        Console.Write(arr[i]+ ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

