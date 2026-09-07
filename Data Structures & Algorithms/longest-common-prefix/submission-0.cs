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
        var sp = new StringBuilder();

        int s1Len = s1.Length;
        int s2Len = s2.Length;

        int smallest = s1Len > s2Len ? s2Len : s1Len;
        int i = 0;

        while (smallest > 0)
        {
            if(s1[i] != s2[i]) break;
            sp.Append(s1[i]);
            smallest--;
            i++;
        }

        return sp.ToString();
    }

}