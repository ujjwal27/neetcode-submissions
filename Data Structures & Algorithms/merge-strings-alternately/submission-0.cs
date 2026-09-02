public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var op = new StringBuilder();
        var len1 = word1.Length;
        var len2 = word2.Length;
        var gtLen = len1 > len2 ? len1 : len2;

        for (int i = 0; i < gtLen ; i++)
        {
            if (i < len1) op.Append(word1[i]);
            if (i < len2) op.Append(word2[i]);
        }

        return op.ToString();
    }
}