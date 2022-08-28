namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison program");
            Console.WriteLine("Console Option \n 1.Enter the points");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UC1.GetDistance();
                    break;
            }

        }
    }
}