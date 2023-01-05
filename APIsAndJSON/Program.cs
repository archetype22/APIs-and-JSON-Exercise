using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);


            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");
                Thread.Sleep(300);
                Console.WriteLine($"Kanye: {quote.Kanye()}");
                Thread.Sleep(500);                 
            }
        }
    }
}
