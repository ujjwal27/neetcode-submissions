public class Solution {
    public bool IsPalindrome(string input) {
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

            if (char.ToLower(input[l]) == char.ToLower(input[r])){
                l++;
                r--;
            } else return false;
        } 

        return true;
    }
}
