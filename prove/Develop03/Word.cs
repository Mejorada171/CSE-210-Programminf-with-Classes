using System;
using System.Collections.Generic;

class Word
{
    string word;
    bool isHidden;
    public Word(string _word)
    {
        word = _word;
        isHidden = false;
    }

    public bool GetIsHidden()
    {
        return isHidden;
    }

    public string GetWord()
    {
        //return isHidden ? new string ('_', word.Length) : word;
        if (isHidden)
        {
            return new string ('_', word.Length);
        }
        else
        {
            return word;
        }
        
    }

    public void Esconder()
    {
        isHidden = true;
    }

    /*private List<string> ConvertTextToList()
    {
        return scripture.ToString()?.Split(' ')?.ToList() ?? new List<string>();
    }

    public void RemoveWordsFromText()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;
        Random rnd = new Random();

        do
        {
            int rndIndex = rnd.Next(0, scriptureTextList.Count);
            scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Length);
            wordsRemoved++;
        } while (wordsRemoved != numWordsToRemove);
    }

    public override string ToString()
    {
        return string.Join(' ', scriptureTextList);
    }

    public bool HasWordsLeft()
    {
        foreach (string word in scriptureTextList)
        {
            if (!word.Contains('_'))
            {
                return true;
            }
        }
        return false;
    }*/

}