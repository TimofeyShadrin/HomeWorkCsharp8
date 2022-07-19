namespace Seminar8
{
    // Задайте две матрицы. Напишите программу,
    // которая выведет матрицу произведения элементов двух предыдущих матриц.
    class Program
    {
        public static void Main(string[] args)
        {
            Decision Matrix = new Decision(5, 4, 0, 11);
            int[,] digits = Matrix.CreateIntArray();
            Decision Array = new Decision(4, 6, 0, 11);
            int[,] numbers = Array.CreateIntArray();
            Console.WriteLine();
            Decision.PrintArray(digits);
            Console.WriteLine("\nand\n");
            Decision.PrintArray(numbers);
            Console.WriteLine("\nis\n");
            int[,] array = Decision.GetProductOfArrays(digits, numbers);
            Decision.PrintArray(array);
            Console.WriteLine();
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

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод создает новый массив из двух путем их произведения
        /// </summary>
        /// <param name="digits">Первый массив</param>
        /// <param name="numbers">Второй массив</param>
        /// <returns></returns>
        public static int[,] GetProductOfArrays(int[,] digits, int[,] numbers)
        {
            int sizeOfHeight = digits.GetLength(0);
            if (sizeOfHeight > numbers.GetLength(0))
                sizeOfHeight = numbers.GetLength(0);

            int sizeOfLength = digits.GetLength(1);
            if (sizeOfLength > numbers.GetLength(1))
                sizeOfLength = numbers.GetLength(1);

            int[,] array = new int[sizeOfHeight, sizeOfLength];
            for (int i = 0; i < sizeOfHeight; i++)
            {
                for (int j = 0; j < sizeOfLength; j++)
                {
                    array[i, j] = digits[i, j] * numbers[i, j];
                }
            }
            return array;
        }
    }
}
