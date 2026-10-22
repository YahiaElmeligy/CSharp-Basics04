namespace CSharp_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Answer Question 1

            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);



            // Answer Question 2

            int[,] shelfCopies = {
                { 3, 5 },
                { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);



            // Answer Question 3

            PrintWelcomeMessage();
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
    }
}
