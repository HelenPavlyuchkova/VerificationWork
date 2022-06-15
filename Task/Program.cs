string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };
int n = 3;//количество символов

void Print(string[] array)
{
    System.Console.Write("Исходный массив: [ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length-1]} ]");
}

string[] ResArray(string[] array, int count = 0)
{
    string[] newarray = new string[count];
    count = 0;
    Console.Write($"Искомый массив:[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            newarray[count] = array[i];
            Console.Write(newarray[count] + "  ");
            count++;
        }
    }
    Console.WriteLine("]");
    return newarray;
}

Print(array2);
System.Console.WriteLine();
ResArray(array2, n);
