// public class Save {
//     private Entry _entry;

//     public Save(Entry entry) {
//         _entry = entry;
//     }

//     // Method to save the entry to a file
//     public void SaveToFile() {
//         // Prompt the user for a filename and file location
//         Console.Write("Enter a filename to save the entry: ");
//         string filename = Console.ReadLine();
//         Console.Write("Enter a file location to save the entry: ");
//         string fileLocation = Console.ReadLine();

//         // Create a StreamWriter object to write to the file
//         // Use $ to concatenate the filename and file location
        
//         using (StreamWriter sw = new StreamWriter($"{fileLocation}\\{filename}")) {
//             // Write the entry and the text to the file
//             sw.WriteLine(_entry.GetEntry());
//         }
//   // Print a message indicating that the entry was saved
//     string filePath = $"{fileLocation}\\{filename}";
//     Console.WriteLine($"Entry saved to {filePath}.");
    
//     Console.WriteLine($"{filePath}");
//     }
// }

using System;
using System.IO;

class Save
{
    public static void SaveJournalToFile(List<Entry> journal)
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("Journal is empty. Nothing to save.");
            return;
        }

        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in journal)
            {
                writer.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
            }
        }

        Console.WriteLine("Journal saved to file.");
    }
}
