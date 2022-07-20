namespace Seminar8
{
    // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    // Напишите программу, которая будет построчно выводить массив,
    // добавляя индексы каждого элемента.
    class Program
    {
        public static void Main(string[] args)
        {
            int[,,] digits = Decision.CreateIntArray();
            Decision.PrintArray(digits);
        }
    }

    class Decision
    {
        public static int[,,] CreateIntArray()
        {
            int[,,] array = new int[2, 3, 4];
            int value = new Random().Next(10, 20);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = value + (i + 1) * (j + 2) * (k + 3);
                    }
                }
            }
            return array;
        }

        public static void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine($"{array[i, j, k]}({i}, {j}, {k})");
                    }
                }
            }
        }
    }
}
