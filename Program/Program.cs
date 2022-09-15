
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
