using System;
using static System.Console;

string[] array = { "Hello,", "2,", "world,", "1234,", "1567,", "123,", "qws", "+_)", "computer science,","1" };
PrintArray(array);
WriteLine();
string[] outputArray = CreateNewArray(array);
PrintArray(outputArray);

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]} ");
    }
}


string[] CreateNewArray(string[] inArray)
{
    int temp = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3) temp++;
    }
    string[] newArray = new string[temp];
    temp = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            newArray[temp] = inArray[i];
            temp++;
        }
        if (temp == newArray.Length) break;
    }
    return newArray;

}