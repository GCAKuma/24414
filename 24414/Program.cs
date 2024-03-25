namespace _24414
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 78, 80, 10, 15, 13, 14, 12, 47, 85 };

            double total = 0;

            foreach(int i in numbers)
            {
                total += i;
            }
            double average=total / numbers.Length;
            Console.WriteLine("Total = " + total + " , " + "Average = " + average);
            

        }
    }
}
