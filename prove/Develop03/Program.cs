using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    // Instantiate Random object to be reused
    private static readonly Random random = new Random();
    static void Main(string[] arg)
    {
        // Select a random scripture reference from the file
        ScriptureReference parsedReference = ScriptureReference.SelectRandomScripture("scriptures.txt");
        // Assign the formatted reference to the 'reference' variable
        string reference = parsedReference.GetFormattedReference();
        Scripture scripture = new Scripture(reference, parsedReference.VerseText);

        DisplayScripture(scripture);

        do
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to end:");
            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "quit")
            {
                break;
            }

            string newString = HideRandomWords(scripture);
            // Use the 'reference' variable which now has a value assigned
            Scripture scriptureWithUnderscores = new Scripture(reference, newString);
            DisplayScripture(scriptureWithUnderscores);
        } while (!scripture.AllWordsHidden);
    }

    static void DisplayScripture(Scripture scripture)
    {
        // Console.Clear();
        Console.WriteLine($"{scripture.Reference}  {scripture.Text}");
    }

    

    static string HideRandomWords(Scripture scripture)
    {
        List<string> wordsToHide = scripture.Words.Where(word => !word.IsHidden).Select(word => word.Text).ToList();

        if (wordsToHide.Count > 1)
        {
            int randomIndex1 = random.Next(wordsToHide.Count);
            int randomIndex2;

            do
            {
                randomIndex2 = random.Next(wordsToHide.Count);
            } while (randomIndex2 == randomIndex1);

            string wordToHide1 = wordsToHide[randomIndex1];
            string wordToHide2 = wordsToHide[randomIndex2];

            foreach (Word word in scripture.Words)
            {
                if (word.Text == wordToHide1 || word.Text == wordToHide2)
                {
                    word.Text = ReplaceWithUnderscore(word.Text);
                    word.Hide();
                }
            }
        }
        else
        {
            scripture.HideAllWords();
        }

        // Reconstruct the scripture text from the Words list
        return string.Join(" ", scripture.Words.Select(w => w.Text));
    }

    // static string ReplaceWithUnderscore(string word)
    // {
    //     // Simplified method using string constructor
    //     return new string('_', word.Length);
    // }

    // // ... (rest of the classes remain unchanged)


    static string ReplaceWithUnderscore(string word)
    {
        // Replace each letter of the word with underscore
        char[] underscores = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            underscores[i] = '_';
        }

        return new string(underscores);
    }
}

class Scripture
{
    public string Reference { get; private set; }
    public string Text { get; private set; }
    public List<Word> Words { get; private set; }

    public bool AllWordsHidden => Words.All(word => word.IsHidden);

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = InitializeWords();
    }

    private List<Word> InitializeWords()
    {
        // Split the text into words
        string[] wordArray = Text.Split(' ');
        return wordArray.Select(wordText => new Word(wordText)).ToList();
    }

    public void HideAllWords()
    {
        foreach (Word word in Words)
        {
            word.Hide();
        }
    }
}

class ScriptureReference

{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int? StartVerse { get; private set; }
    public int? EndVerse { get; private set; }
    public string VerseText { get; private set; }

    private ScriptureReference(string reference, string verseText)
    {
        ParseReference(reference);
        VerseText = verseText;
    }

    public static ScriptureReference SelectRandomScripture(string filePath)
    {
        // Create a new Random object for local use within this method
        Random localRandom = new Random();
        try
        {
            var lines = File.ReadAllLines(filePath);
            if (lines.Length == 0)
            {
                throw new InvalidOperationException("The scripture file is empty.");
            }

            string randomLine = lines[localRandom.Next(lines.Length)];
            string[] parts = randomLine.Split('|');
            if (parts.Length != 2)
            {
                throw new FormatException("The scripture file is not in the correct format.");
            }

            return new ScriptureReference(parts[0], parts[1]);
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., file not found, no access, etc.)
            Console.WriteLine($"An error occurred: {ex.Message}");
            Environment.Exit(1);
            return null; // This line will never be reached, but is required to satisfy the compiler.
        }
    }

    // Method to get the formatted scripture reference
    public string GetFormattedReference()
    {
        if (EndVerse == null)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }

    private void ParseReference(string reference)
    {
        // Split the reference into parts
        string[] parts = reference.Split(' ');

        // Assuming the reference format is "Book Chapter:StartVerse-EndVerse"
        if (parts.Length >= 2)
        {
            Book = parts[0];

            // Parse Chapter
            if (int.TryParse(parts[1].Split(':')[0], out int chapter))
            {
                Chapter = chapter;
            }

            // Parse StartVerse and EndVerse if available
            if (parts[1].Contains(':'))
            {
                string[] verseParts = parts[1].Split(':')[1].Split('-');

                if (int.TryParse(verseParts[0], out int startVerse))
                {
                    StartVerse = startVerse;
                }

                if (verseParts.Length == 2 && int.TryParse(verseParts[1], out int endVerse))
                {
                    EndVerse = endVerse;
                }
            }
        }
    }

}

class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }
}
