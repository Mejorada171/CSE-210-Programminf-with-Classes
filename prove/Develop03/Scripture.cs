using System;

class Scripture
{
    private string scriptureText;
    private Reference scriptureReference;
    List<Word> words;

    public Scripture(Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        scriptureText = _scriptureText;
        words = new List<Word>();
        AddWords();
    }

    public void DisplayScriptureText()
    {   
        foreach (Word word in words)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }

    private void AddWords()
    {
        string[] allWords = scriptureText.Split(' ');
        foreach (string _word in allWords)
        {
            Word word = new Word(_word);
            words.Add(word);
        }
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordCount = 3;
        int wordsRemoved = 0;
        int randIndex = 0;
        do
        {
            randIndex = random.Next(words.Count());
            if (!words[randIndex].GetIsHidden())
            {
                words[randIndex].Esconder();
                wordsRemoved++;
            }
        }
        while (wordsRemoved != wordCount && HasWordsLeft());
    }

    public bool HasWordsLeft()
    {

        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                return true;
            }
        }

        return false;
    }
}