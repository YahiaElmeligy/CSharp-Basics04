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



            // Answer Question 4

            PrintBookTitle("Clean Code");



            // Answer Question 5

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);



            // Answer Question 6

            double[] bookPrices = { 25.5, 40.0 };
            ApplyDiscount(bookPrices);
            Console.WriteLine(bookPrices[0]);



            // Answer Question 7

            int pagesByRef = 400;
            AddBonusPagesByRef(ref pagesByRef);
            Console.WriteLine(pagesByRef);
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
    }
}
