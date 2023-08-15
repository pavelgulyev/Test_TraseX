using System.Collections.Generic;

Console.WriteLine("Введите массив чисел через пробел:");
string[] numbersInput = Console.ReadLine().Split(' ');

List<int> numbers = new List<int>();
numbers.AddRange(Array.ConvertAll(numbersInput, int.Parse));
InsertionSort(numbers);


Console.WriteLine("Отсортированный список:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

Console.ReadLine();

// Метод сортировки вставками
void InsertionSort(List<int> arr)
{
    int n = arr.Count;
    for (int i = 1; i < n; i++)
    {
        int key = arr[i];
        int j = i - 1;

        // Перенос элементов списка, которые больше key, на одну позицию вперед
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }

        arr[j + 1] = key;
    }
}
