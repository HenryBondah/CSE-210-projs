

using System;

class Program
{
    static void Main(string[] args)
    {
        Source source = new Source("1 Nephi 1:1", "https://www.churchofjesuschrist.org");

// Console.WriteLine(source.stringify());

Quote Hinkley = new Quote("Gorden B. Hinkley", "Cultivate an attitude of happiness. Cultivate a spirit of optimism. Walk with faith.", source);

Quote Alma = new Quote("Alma 32:21", "If ye have faith ye hope for things which are not seen, which are true.", source);

Quote Joseph = new Quote("Elder Joseph B. Wirthlin", "Your Heavenly Father—who knows when even a sparrow falls—knows of your heartache and suffering.", source);

Quote Russell = new Quote("Elder M. Russell Ballard", "Balance your life with spiritual experiences that remind and prepare you for continued, daily ministering to others..", source);

Quote Gary = new Quote("Elder Gary E. Stevenson,", "Do you realize that the Book of Mormon was written for you—and for your day?.", source);


// Console.WriteLine(Hinkley.GetQuote());

Board quoteboard = new Board();
// quoteboard.AddQuote(Hinkley);
// quoteboard.FindQuotesByAuthor("Hinkley");

quoteboard.AddQuote(Joseph);
quoteboard.AddQuote(Alma);
quoteboard.AddQuote(Russell);
quoteboard.AddQuote(Gary);
quoteboard.GetRandomQuote();


Menu _menu = new Menu(quoteboard);
_menu.Display();

    }
}

