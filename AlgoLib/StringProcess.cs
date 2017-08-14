using System;
using System.Linq;

namespace AlgoLib
{
    public static class StringProcess
    {
		// Returns a string containing only the characters found in both strings.
		// Throws ArgumentNull Exception if one of the parameters is null.
		public static string GetCommonInStrings(string firstStr, string secondStr)
        {
            return new string((firstStr.Intersect(secondStr)).ToArray());
        }


    }
}

