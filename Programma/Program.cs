// Необходимо написать программу, которая из имеющегося 
// массива строк формирует массив из строк, длина которых => 3 
// символа. Первоначальный массив мы будем вводить с клавиатуры.


Console.Clear();
Console.WriteLine("Какова будет длина массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] Array(int m)
{
    string[] array = new string[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите элемент массива {i + 1}:");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i] + "]");
    }
}

string[] LessThan3(string[] array)
{
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            x++;
        }
    }
    string[] array1 = new string[x];
    int y = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[y] = array[i];
            y++;
        }
    }
    return array1;
}

string[] array = Array(n);
Console.Write("Исходный массив: ");
Print(array);
Console.WriteLine();
string[] array1 = LessThan3(array);
Console.Write("Получившийся массив: ");
Print(array1);