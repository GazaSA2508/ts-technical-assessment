
using System.Text.RegularExpressions;

namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        //### Calculate longest sentence
        int result = GetLongestSentance(s);

        return result;

        //throw new NotImplementedException("Not completed yet");
    }

    /// <summary>
    /// Get the word count from the sentence containing the largest number of valid words
    /// Only counting those words that contain only letters (ie: a-z / A-Z)
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    private static int GetLongestSentance(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        int maxCount = 0;

        //### Array of characters used to split sentencess
        char[] delimiters = { '.', '?', '!' };

        //### Split text into sentences
        var sentences = text.Split(delimiters);

        foreach (var sentence in sentences) 
        { 
            string newSentence = sentence.Trim();

            //### Count words in new setence
            var words = newSentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //### Only count words containing letters only
            int wordCount = words.Count(x => Regex.IsMatch(x, "[a-zA-Z]"));

            //Console.WriteLine($"wordCount: {wordCount}");

            if (wordCount > maxCount)
                maxCount = wordCount;

        }

        return maxCount;


    }

}
