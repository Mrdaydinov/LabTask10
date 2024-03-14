namespace LabTask10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int n = 15;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{n} X {i} = {n*i}");
            //}


            //////


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] arr1 = new int[arr.Length / 3];
            int[] arr2 = new int[arr.Length / 3];
            int[] arr3 = new int[arr.Length / 3];

            int index = 0;
            
            for (int i = 2; i < arr.Length; i += 3)
            {
                arr3[index] = arr[i];
                arr2[index] = arr[i-1];
                arr1[index] = arr[i-2];
                index++;
            }

            Console.WriteLine("Arr1 = ");
            foreach (int i in arr1)
                Console.WriteLine(i);

            Console.WriteLine("Arr2 = ");
            foreach (int i in arr2)
                Console.WriteLine(i);

            Console.WriteLine("Arr3 = ");
            foreach (int i in arr3)
                Console.WriteLine(i);
        }
    }
}
