// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трем символам.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] EnterMassive(string message)
{
    Console.WriteLine(message);
    string[] array = new string[1];
    int i = 0;
    string element;
    while (true)
    {
        element = Console.ReadLine();
        if (element != "")
        {
            Array.Resize(ref array, i + 1);
            array[i] = element;
            i++;
        }
        else return array;
    }
}

string[] NewMassive(string[] massive)
{
    string[] newArray = new string[1];
    int i = 0;
    foreach (string item in massive)
    {
        if (item.Length <= 3)
        {
            Array.Resize(ref newArray, i + 1);
            newArray[i] = item;
            i++;
        }
    }
    return newArray;
}

string[] firstMassive = EnterMassive("Введите элументы массива через enter");
PrintArray(firstMassive);
string[] secondMassive = NewMassive(firstMassive);
PrintArray(secondMassive);

