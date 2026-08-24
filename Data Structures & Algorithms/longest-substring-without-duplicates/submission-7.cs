public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        if (s.Length == 0) return 0;
        if (string.IsNullOrWhiteSpace(s)) return 1;

        int i = 0;
        int j = 0;
        int max_length = 0;
        var unique = new HashSet<char>();

        while (i <= j && j < s.Length)
        {
            if (!unique.Contains(s[j])) {
                // Not found duplicate
                unique.Add(s[j]);
                max_length = Math.Max(max_length, j - i + 1);
                j++;
            } else {
                i++;
                unique.Remove(s[i-1]);
                max_length = Math.Max(max_length, j - i + 1);
            }
        }

        return max_length;
    }
}
