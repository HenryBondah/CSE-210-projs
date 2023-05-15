// Load - prompt-filename, retrieve file from file location


// public class Quote
// //
// {

//     private string _author = "";
//     private string _quote = "";
//     private Source _source;

//     public Quote(string person, string quote, Source source)
//     {
//         _author = person;
//         _quote = quote;
//         _source = source;
//     }

//     public bool HasAuthor(string name)
//     {
//         if(_author.ToUpper().Contains(name.ToUpper()))
//         {
//             return true;
//         }
//         return false;
//     }

//     public string GetQuote()
//     {
//         return $"\"{_quote}\"n{_author} - {_source.Stringify}";
//     }

// }

using System;
using System.Collections.Generic;
using System.IO;

class Load
{
    public static List<Entry> LoadJournalFromFile()
    {
        List<Entry> journal = new List<Entry>();

        Console.Write("Enter a filename to load the journal from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return journal;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    DateTime date = DateTime.Parse(parts[2]);
                    Entry entry = new Entry(prompt, response, date);
                    journal.Add(entry);
                }
            }
        }

        Console.WriteLine("Journal loaded from file.");
        return journal;
    }
}
