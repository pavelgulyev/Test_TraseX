
using ConsoleApp1;
class Program
{
    public static int SumMod(int[] numbers)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                count++;
                if (count % 2 == 0)
                    sum += numbers[i];
            }
        }
        return Math.Abs(sum);
    }
    static void Main()
    {
        Console.WriteLine("Приложение, которое предоставит функционал сложения каждого второго нечетного числа из массива чисел тела запроса и вернёт их сумму по модулю.\n");
        Console.WriteLine("Введите массив чисел через пробел:");
        string[] numbersInput = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(numbersInput, int.Parse);

        // Проверка массива на наличие нечетных чисел
        bool oddNumbersExist = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                oddNumbersExist = true;
                break;
            }
        }

        if (!oddNumbersExist)
        {
            Console.WriteLine("В массиве нет нечетных чисел.");
            return;
        }

        Console.WriteLine("1. Сумма каждого второго нечетного числа: " + SumMod(numbers));
    }
}