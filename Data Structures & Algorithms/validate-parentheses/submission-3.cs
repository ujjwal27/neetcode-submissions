public class Solution {
    public bool IsValid(string s) {

        if (s.Length == 1) return false;

        var st = new Stack<char>();
        var dict = new Dictionary<char, char>() {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach (var ch in s)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                st.Push(ch);
            } else {
                if (!st.Any() || st.Pop() != dict[ch]) return false;
            }
        }

        return !st.Any();
    }
}
