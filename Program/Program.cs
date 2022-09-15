
string[] ArrayFilling()
{
    Console.WriteLine("Вводите для заполнения массива строки через Enter. Для прекращения введите пустую строку.");
    string result = string.Empty;
    int count = 0;

    while (true)
    {
        string txt = Console.ReadLine();

        if(txt == string.Empty) break;
        result += (count <=0 ? "" : ",") + txt;
        count++;
    }

    string[] array = result.Split(",");

    return array;
}

string[] GetArraySortedbySize(string[] arr, int maxSize)
{
    string sresult = string.Empty;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= maxSize)
        {
            sresult += (i <=0 ? "" : ",") + arr[i];
        }
    }

    string[] result = sresult.Split(",");
    
    return result;
}

string[] array = ArrayFilling();
Console.WriteLine($"{string.Join(", ", array)}");

string[] result = GetArraySortedbySize(array, 3);
Console.WriteLine($"{string.Join(", ", result)}");
