using System;
using System.Collections.Generic;

public class Entry
{
    public string Prompt { get; set; }
    public string Text { get; set; }
    public string Date { get; set; }
}







//public class Entry
// {
//     private string _date;
//     private string _promptText;
//     private string _entryText;

//     public string Date
//     {
//         get { return _date; }
//         set { _date = value; }
//     }

//     public string PromptText
//     {
//         get { return _promptText; }
//         set { _promptText = value; }
//     }
//     public string EntryText
//     {
//         get { return _entryText; }
//         set { _entryText = value; }
//     }
//     public void Display()
//     {
//         Console.WriteLine($"Date: {_date}");
//         Console.WriteLine($"Prompt: {_promptText}");
//         Console.WriteLine($"Entry: {_entryText}");
//     }   
// }