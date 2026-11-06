public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void WriteNewEntry(PromptGenerator promptGenerator)
    {
        Entry newEntry = new Entry();

        newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");
        newEntry._promptText = promptGenerator.GetPrompt();
        Console.WriteLine($"{newEntry._promptText}");
        newEntry._entryText = Console.ReadLine();
        Entries.Add(newEntry);

        Console.WriteLine("Entry saved successfully.");
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"{entry._date}\nPrompt: {entry._promptText}\nResponse: {entry._entryText}\n");
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"Date: {entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    public void LoadJournalFromFile(string filename)
    {
        Entries.Clear(); // Clear entries.

        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue; // Skip empty lines
                    }

                    string[] parts = line.Split('|');
                    
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry
                        {
                            _date = parts[0].Trim(),
                            _promptText = parts[1].Trim(),
                            _entryText = parts[2].Trim()
                        };
                        Entries.Add(entry);
                    }

            }
            Console.WriteLine($"Journal loaded from {filename} successfully.");

            
        }
        else
        {
            Console.WriteLine($"File {filename} not found.");
        }
        
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}");
        }
    }
}
