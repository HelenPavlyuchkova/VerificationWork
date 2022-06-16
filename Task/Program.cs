string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };


void Print(string[] array)
{
    System.Console.Write("Исходный массив: [ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]} ]");
}

string[] ResArray(string[] array, int n = 3) //n -количество символов строки массива
{
    int count = 0;
    string[] resarray = new string[array.Length];
    Console.Write($"Искомый массив:[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            resarray[count] = array[i];
            Console.Write(resarray[count] + "  ");
            count++;
        }
    }
    Console.WriteLine("]");
    return resarray;
}

Print(array3);
System.Console.WriteLine();
ResArray(array3);
