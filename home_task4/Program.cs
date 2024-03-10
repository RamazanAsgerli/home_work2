namespace home_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1221;
            int b = n;
            int ters = 0;
            int qaliq;
            while (n > 0)
            {
                qaliq = n % 10;
                n = n - qaliq;
                ters = ters * 10 + qaliq;
                n = n / 10;
            }
            if (b == ters)
            {
                Console.WriteLine("verilmis eded polindromdur");
            }
            else
            {
                Console.WriteLine("polindrom deyil");
            }
        }
    }
}
