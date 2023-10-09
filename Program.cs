// Задача: Написать программу, которая из 
// имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо 
// равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}

void PrintIntArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
//----------------------------------

Console.WriteLine("введите количество элементов массива ");
string value = Console.ReadLine();
int len = Convert.ToInt32(value);
string[] mass = new string[len];
int LenNewMass = 0;
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = Prompt("введите строку");
    if (mass[i].Length < 4)
    {
        LenNewMass++;
    }
}
string[] NewMass = new string[LenNewMass];
int index = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].Length < 4)
    {
        NewMass[index] = mass[i];
        index++;
    }
}
PrintIntArray(NewMass);



