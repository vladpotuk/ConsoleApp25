using System;

class Program
{
    static void Main(string[] args)
    {
        

        // Завдання 1: Метод, який повертає добуток чисел у вказаному діапазоні
        int product = MyModel.GetProductInRange(1, 5);
        Console.WriteLine("Добуток чисел у вказаному діапазоні: " + product);

        // Завдання 2: Метод, який перевіряє, чи є число числом Фібоначчі
        int number = 13;
        bool isFibonacci = MyModel.IsFibonacci(number);
        Console.WriteLine(number + " чи є числом Фібоначчі: " + isFibonacci);

        // Завдання 3: Метод, який сортує масив за зменшенням або зростанням
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6 };
        MyModel.SortArray(array, sortOrder: "asc"); 
        Console.WriteLine("Відсортований масив за зростанням:");
        PrintArray(array);

        MyModel.SortArray(array, sortOrder: "desc"); 
        Console.WriteLine("Відсортований масив за зменшенням:");
        PrintArray(array);
    }

    
    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
