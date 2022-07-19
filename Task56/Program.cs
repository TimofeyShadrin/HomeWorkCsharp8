namespace Seminar8
{
    // Задайте прямоугольный двумерный массив. Напишите программу,
    // которая будет находить строку с наименьшей суммой элементов.
    class Program
    {
        public static void Main(string[] args)
        {
            Decision Matrix = new Decision(6, 4, 0, 11);
            int[,] digits = Matrix.CreateIntArray();
            Console.WriteLine();
            Matrix.PrintArray(digits);
            int index = Matrix.IndexOfMinSumInString(digits);
            Console.WriteLine($"\nMin sum in line No {index}\n");
        }
    }

    class Decision
    {
        public Decision(byte height, byte length, int minDigit, int maxDigit)
        {
            if (height > 0 && height < 11)
                Height = height;
            else
                Height = 10;
            if (length > 0 && length < 11)
                Length = length;
            else
                Length = 10;
            if (minDigit >= 0 && minDigit < 6)
                MinDigit = minDigit;
            else
                MinDigit = 0;
            if (maxDigit > 5 && maxDigit < 10)
                MaxDigit = maxDigit;
            else
                MaxDigit = 10;
        }

        public static byte Height;
        public static byte Length;
        public static int MinDigit;
        public static int MaxDigit;

        public int[,] CreateIntArray()
        {
            int[,] randomArray = new int[Height, Length];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    randomArray[i, j] = new Random().Next(MinDigit, MaxDigit);
                }
            }
            return randomArray;
        }

        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{i}: ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public int IndexOfMinSumInString(int[,] array)
        {
            int minResult = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                minResult += array[0, i];
            }

            int index = 0;
            int result = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                result = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j];
                }
                if (result < minResult)
                {
                    minResult = result;
                    index = i;
                }
            }
            return index;
        }
    }
}
