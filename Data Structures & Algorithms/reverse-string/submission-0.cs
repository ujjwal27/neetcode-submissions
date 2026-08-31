public class Solution {
    public void ReverseString(char[] s) {

        if (s.Length == 1) return;

        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            var temp = s[l];
            s[l] = s[r];
            s[r] = temp;

            l++;
            r--;
        }
    }
}