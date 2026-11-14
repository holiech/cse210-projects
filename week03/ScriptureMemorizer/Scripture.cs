using System;

 class Scripture
{
    public Reference Reference { get; }
    private List<Word> Words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();

    }

    public void HideWords(int numWords)
    {
        Random random = new Random();
        for (int i = 0; i < numWords; i++)
        {
            int indexHide = random.Next(Words.Count);
            Words[indexHide].Hide();
        }
    }


    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

        public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(Reference.ToString() + ":");
        foreach (Word word in Words)
        { 
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

}
    
        

    
