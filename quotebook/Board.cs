public class Board
{
    List<Quote> _quotes = new List<Quote>();

    private void NicePrint(string item)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("--------------------------");
    }

    public void ShowQuote()
    {
        foreach (Quote quote in _quotes)
        {
           Console.WriteLine(quote.GetQuote());
           Console.WriteLine(); 
        }
    }

    public void AddQuote(Quote quote)
    {
        _quotes.Add(quote);
    }
    public void GetRandomQuote()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_quotes.Count);
        NicePrint(_quotes[randomNumber].GetQuote());
    }

    public void FindQuotesByAuthor(string author)
    {
        foreach (Quote quote in _quotes)
        {
            if(quote.HasAuthor(author))
            {
                NicePrint(quote.GetQuote());
            }
        }
    }

}