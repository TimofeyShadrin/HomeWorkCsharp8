namespace Seminar8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Decision Matrix = new Decision(5, 8, 0, 11);
            int[,] digits = Matrix.CreateIntArray();
            Matrix.PrintArray(digits);
            Console.WriteLine();
            Matrix.SortArray(digits);
            Console.WriteLine();
            Matrix.PrintArray(digits);
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
            if (minDigit > 0 && minDigit < 6)
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

        public int[,] SortArray(int[,] array)
        {
            int temp;
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int i = 0; i < array.GetLength(1) - 1; i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        if (array[k, i] > array[k, j])
                        {
                            temp = array[k, i];
                            array[k, i] = array[k, j];
                            array[k, j] = temp;
                        }
                    }
                }
            }
            return array;
        }

        public void PrintArray(int[,] array)
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
    }
}
