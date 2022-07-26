﻿// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] CreateStringArr(int n)
{
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Enter the string array element number: " + (i + 1) + " ");
        string? newElem = Convert.ToString(Console.ReadLine());
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

string[] СoncatenationArr (string[] arrOne, string[] arrTwo) {
    int lengArr = arrOne.Length;
    string[] newArr = new string[lengArr];
    for (int i = 0; i < lengArr; i++)
    {
        newArr[i] = arrOne[i] + arrTwo[i];
    }
    return newArr;
}

Console.Write("Enter the number of words for the two arrays: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] userArrFirst = CreateStringArr(n);

string[] userArrSecond = CreateStringArr(n);

PrintArr(userArrFirst);

PrintArr(userArrSecond);

string[] concatArr = СoncatenationArr(userArrFirst, userArrSecond);

PrintArr(concatArr);