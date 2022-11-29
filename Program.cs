





internal class Program
{
  

    private static void Main(string[] args, int count)
    {
        string[] array;
        string[] array2;
        int count = 0;
        Console.WriteLine("Введите массив строк");
        array = new string[count];
        array2 = new string[count];


        for (int i = 0; i < array.Length; i++)
        {
            if (array.Length <= 3)
            {
                array2[count] = array[count];
                count++;

            }

        }
        void PrintArray(string[] array2);
        for (int i = 0; i < array2.Length; i++) ;

        Console.WriteLine($"{array2}");
    }
}