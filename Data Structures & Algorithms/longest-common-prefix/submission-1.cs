public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if (strs.Length == 1) return strs[0];

        string result = strs[0];
        int j = 1; 

        while (j < strs.Length)
        {
            result = GetCommon(result, strs[j]);
            j++;
        }
        
        return result;
    }

    public string GetCommon(string s1 , string s2) {

        int smallest = Math.Min(s1.Length, s2.Length);
        int i = 0;

        while (smallest > 0)
        {
            if(s1[i] != s2[i]) break;
            smallest--;
            i++;
        }

        return s1.Substring(0, i);
    }

}