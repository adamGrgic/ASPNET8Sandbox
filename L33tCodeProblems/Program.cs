// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("L33t Code!");


string MergeAlternately(string word1, string word2)
{
    // array of letters w , o , r , d , 1
    // second array of letters w, o , r, d, 2
    var combinedStringLength = word1.Length + word2.Length;

    // split each word into an array of characters
    char[] word1CharArr = word1.ToCharArray();
    char[] word2CharArr = word2.ToCharArray();

    var loopLength = word1.Length > word2.Length ? word1.Length : word2.Length;
    var alternatingString = new StringBuilder();

    for (var i = 0; i <= loopLength; i++)
    {
        if (i <= word1.Length -1)
        {
            alternatingString.Append(word1[i]);
        }

        if (i <= word2.Length -1)
        {
            alternatingString.Append(word2[i]);
        }
    }

    //Console.WriteLine(alternatingString.ToString());
    return alternatingString.ToString();
}

MergeAlternately("foo", "dog");