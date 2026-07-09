namespace bubbleSort
{
    internal class Program
    {
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            int temp;
            for(int i = 0; i < n-1; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if (array[j]> array[j+1])
                    {
                         temp = array[j];
                        array[j] = array[j+1];
                        array[j+1]= temp;
                    }
                }
            }

         

        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 7, 5, 8, 6 };

           BubbleSort(array);
            Console.WriteLine("After Sorting: ");
            foreach(int i in array)
            {
                Console.Write(i+" ");
            }


            Console.ReadKey();
        }
    }
}
