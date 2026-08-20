public class Solution {
    public bool IsPalindrome(string s) {
        var input = s.ToLower().ToCharArray();
        int l = 0;
        int r = input.Length - 1;

        while (l < r)
        {
            if (!char.IsLetterOrDigit(input[l])) {
                l++;
                continue;
            }

            if (!char.IsLetterOrDigit(input[r])) {
                r--;
                continue;
            }

            if (input[l] == input[r]){
                l++;
                r--;
            } else return false;
        } 

        return true;
    }
}
