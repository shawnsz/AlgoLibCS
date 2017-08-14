using System;
using System.Linq;

namespace AlgoLib
{
    public static class SentenceReverse
    {
        public static string GetReversedSentence(string sentence)
        {
			// Returns original input if it is null, is empty, contains white space only or has one word only.
			if (String.IsNullOrWhiteSpace(sentence) || sentence.IndexOf(' ') < 0) return sentence;

            // Split Sentence to array and reverse them.
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return String.Join(" ", words);
        }

    }
}
