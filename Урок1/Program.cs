// Задача алгоритмически не самая сложная,
// однако для полноценного выполнения
// проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма 
// (можно обойтись блок-схемой основной содержательной части, 
// если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом
// (не должно быть так, что всё залито одним коммитом,
// как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: 
// Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
int i = 0;
while (i < array.Length)
{
    Console.WriteLine($"Введите {i + 1}ю строку: ");
    array[i] = Console.ReadLine();
    i++;
}
Console.WriteLine();
PrintArray(array);
Console.Write(" -> ");
string[] result = FilterByStringLength(array);
PrintArray(result);


void PrintArray(string[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"'{arr[i]}'{sep} ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.Write("]");
}

string[] FilterByStringLength(string[] input)
{
    int count = 0;
    int i = 0;
    while (i < input.Length)
    {
        if (input[i].Length <= 3) count++;
        i++;
    }
    string[] output = new string[count];
    int j = 0;   
    for (int k = 0; k < input.Length; k++)
    {
        if (input[k].Length <= 3) 
        {
            output[j] = input[k];
            j++;
        }
    }
    return output;
}

