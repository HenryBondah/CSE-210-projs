public class Menu
{
    private Board _board;
    public  Menu(Board board)
    {
        _board = board;
    }

    public void Display()
    {
        string response = "";
        string[] options = {"A","S","Q","F","R"};
        while(response!="Q")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("[A]dd quote\n[S]how quotes\n[F]ind Quote by Author\n[R]andom Quote\n[Q]uit\n\nwhat do you want to do? ");
                response = Console.ReadLine() ?? string.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.WriteLine("please enter  your quote: ");
                    string quote = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("please enter  your author: ");
                    string author = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("please enter  your source: ");
                    string source = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("please enter  your source url: ");
                    string sourceUrl = Console.ReadLine() ?? string.Empty;

                    _board.AddQuote(new Quote(author,quote,new Source(source,sourceUrl)));
                    break;
                case "S":
                    _board.ShowQuote();
                    break;
                case "F":
                    Console.Write("Please enter your author: ");
                    author = Console.ReadLine() ?? string.Empty;
                    _board.FindQuotesByAuthor(author);
                    break;
                case "R":
                    _board.GetRandomQuote();
                    break;

            }
            response = "";
        }
    }
}