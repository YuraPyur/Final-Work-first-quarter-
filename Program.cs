// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите значения через запятую: ");
string x = Console.ReadLine();
var array = x.Split(',').ToArray();
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        j++;
    }
}
Console.WriteLine("Вывод элементов, длина которых меньше или равна 3: ");
string[] array2 = new string[j];
int e = 0;
for (int i = 0, b = 0; i < array.Length; i++)
{

    if (array[i].Length <= 3)
    {
        array2[b] = array[i];
        Console.Write(array2[b] + " ");
        b++;
    }
}
