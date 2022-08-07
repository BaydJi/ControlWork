namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
            string[] array = new string[5] {"123", "hay", "world", "125", "Program"};
            Console.WriteLine("Заданный массив:");
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            IteratArray(array);
        }

        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void IteratArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) Console.Write(array[i] + " ");
            }
        }
    }
}
