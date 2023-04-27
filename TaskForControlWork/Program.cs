
string[] array1 = new string[] {"Hello", "2", "World", ":-)"};
string[] array2 = new string[array1.Length];

//метод создания второго массива из элементов первого согласно условию
void BuilderSecArrWhithElmLessThreeOnFistArr(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
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
