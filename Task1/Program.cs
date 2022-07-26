// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] CreateStringArr (int n) {
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент массива строк номер: " + i + 1);
        string newElem = Convert.ToString(Console.ReadLine());
        arr[i] = newElem;
    }
    return arr;
}

void PrintArr (string[] arr) {
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine(arr[i]);
    }
}