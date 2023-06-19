/* Вид 1 (ничего не принимает, ничего не выводит)

void Method1()
{
    Console.WriteLine("Автор…");
}
Method1();
*/

/*

// Вид 2 (что-то принимает, ничего не возвращает)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
*/

// или

// void Method2.1(string msg, int count)
// {
//     int i = 0;
//     while (i < count) ;
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2.1("Текст", 4);

// Вид 3 (ничего не принимает, что-то возвращает)
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10,"z");
// Console.WriteLine(res);

// Вид 4 (что-то принимает, что-то возвращает)
/*
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

// Цикл FOR. Делаем таблицу умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

// Сортировка в массиве с помощью цикла FOR
/*
int[] arr = { 1, 2, 3, 5, 6, 7, 8, 9, 2, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/