/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.*/


//Cоздать строковый массив. 

string[] CreateArray(int size)
{
    string [] result = new string [size];

    return result;
}


//Заполнить массив через консоль.

void FillArrayFromConsole(string[] array)
{
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        Console.Write($" array[{i}]:   ");

        array[i] = Console.ReadLine ();

        Console.WriteLine();
    }
    Console.WriteLine();
}

//Печать массива в консоль.

void PrintArray(string[] array)
{
    int len = array.Length;
    Console.Write ($"Исходный массив :   ");
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}{' '}");
    }
    Console.WriteLine();
}

// Создаем и печатаем новый массив в консоль.

void CreateAndPrintNewArray(string[] array)
{
         
    Console.Write ($"Новый массив :   ");
    
    int len = new Random(). Next (0, 3);

    for (int i = 0; i <= len; i++)
    {
        i = new Random(). Next (0, array.Length);
        Console.Write($"{array[i]}{' '}");
    }
    
    Console.WriteLine();
}

string[] inarr = CreateArray(4);
FillArrayFromConsole(inarr);
PrintArray(inarr);
CreateAndPrintNewArray(inarr);


