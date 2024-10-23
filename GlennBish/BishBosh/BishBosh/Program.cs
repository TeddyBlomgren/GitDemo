namespace BishBosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bish Bosh");
            Console.WriteLine();
            Console.WriteLine("Hur många nummer? ");
            int test = Console.ReadLine();

            for (int number = 1; number <= test; number++)

            {
                if (number % 4 == 0 && number % 6 == 0)
                {
                    Console.Write("BISH-BOSH" + " ");
                }
                else if (number % 4 == 0)
                {
                    Console.Write("BISH" + " ");
                }
                else if (number % 6 == 0)
                {
                    Console.Write("BOSH" + " ");
                }
                else
                {
                    Console.Write(number + " ");
                }
                
            }
        }
    }
}