namespace home_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            int n = 6;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
        }
    }
}
