// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] CreateStringArr(int n)
{
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент массива строк номер: " + (i + 1) + " ");
        string newElem = Convert.ToString(Console.ReadLine());
        arr[i] = newElem;
    }
    return arr;
}

void PrintArr(string[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write(arr[i] + ";");
    }
    Console.WriteLine();
}

int CountWords(string[] arr)
{
    int len = arr.Length;
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (arr[i][0] == vowels[0] || arr[i][0] == vowels[1] || arr[i][0] == vowels[2] || arr[i][0] == vowels[3] || arr[i][0] == vowels[4] || arr[i][0] == vowels[5])
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество слов: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] userArr = CreateStringArr(n);

PrintArr(userArr);

Console.WriteLine("Количество слов на гласную букву: " + CountWords(userArr));