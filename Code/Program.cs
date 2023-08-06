/*Написать программу, которая 
из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] GetArrayWithFilterLength(string[] Array, int LengthValue)
{
    int size = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= LengthValue)
        {
            size++;
        }
    }
    //Console.WriteLine(size);
    string[] ArrayWithFilter = new string[size];
    for (int i = 0; i < size; i++)
    {
        ArrayWithFilter[i] = Array[i];
    }
    return ArrayWithFilter;
}

string[] SortedArrayWithStrings(string[] Array)
{

    for (int i = 0; i < Array.Length; i++)
    {
        string temp = String.Empty;
        for (int k = i + 1; k < Array.Length; k++)
        {
            if (Array[i].Length >= Array[k].Length)
            {
                temp = Array[i];
                Array[i] = Array[k];
                Array[k] = temp;
            }
        }

    }
    return Array;
}

string PrintArray(string[] array)
{
    return string.Join(", ", array);
}


string[] Array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russuia", "Kazan", "1", "+-2"};
int LengthValueForSelect = 3; //условие задачи
string[] SortedArray = SortedArrayWithStrings(Array);
//Console.WriteLine(PrintArray(SortedArray));
string[] FiltredArray = GetArrayWithFilterLength(SortedArray, LengthValueForSelect);
Console.WriteLine(PrintArray(FiltredArray));