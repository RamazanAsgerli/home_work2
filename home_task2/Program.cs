namespace home_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 13;
            bool check = false;
            if (n < 2)
            {
                Console.WriteLine("ne sade ededdir,ne de murekkeb ededdir");
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    check = false;
                    Console.WriteLine("murekkeb ededdir");
                    break;
                }
                else
                {
                    Console.WriteLine("sade ededdir");
                    break;
                }
            }
        }
    }
}
