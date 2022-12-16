// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоночальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// колекциями, лучше обойтись исключительно массивами.

string[] MainArray(int size)
{
    string[] mainarray = new string[size];
    for (int i = 0; i < mainarray.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        mainarray[i] = Console.ReadLine();
    }
    return mainarray;
}
void ShowArray(string[] array)//показать массив
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
string[] SecondArray(string[] mainarray)
{

    int length = 0;
    int count = 0;
    for (int i = 0; i < mainarray.Length; i++)
    {
        length = mainarray[i].Length;
        if (length <= 3)
        {
            count++;
        }
    }
    string[] secondarray = new string[count];
    count = 0;
    for (int i = 0; i < mainarray.Length; i++)
    {
        length = mainarray[i].Length;
        if (length <= 3)
        {
            secondarray[count] = mainarray[i];
            count++;
        }
    }
    return secondarray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] mainarray = MainArray(size);
string[] secondarray = SecondArray(mainarray);
Console.WriteLine("Изначальный массив: ");
ShowArray(mainarray);
Console.WriteLine("Полученный массив: ");
ShowArray(secondarray);
