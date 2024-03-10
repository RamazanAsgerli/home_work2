namespace home_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                int product = 1;
                int n = 125;
                int qaliq;
                while (n > 0)
                {
                    qaliq = n % 10;
                    n = n - qaliq;
                    product *= qaliq;
                    n = n / 10;
                }
                Console.WriteLine(product);
            
}
    }
}
