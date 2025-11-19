
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        //### Calculate longest sentence


        throw new NotImplementedException("Not completed yet");
    }


    private static int GetMaxWordCount(string text)
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



        }

        return maxCount;


    }



}
