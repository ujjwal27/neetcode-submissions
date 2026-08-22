public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var op = new Dictionary<string, List<string>>();

        foreach(var ch in strs)
        {
            var charArray = ch.ToCharArray();
            Array.Sort(charArray);
            var curr_key = new string(charArray);

            if(op.ContainsKey(curr_key))
                op[curr_key].Add(ch);
            else
                op.Add(curr_key, new List<string>(){ ch } );
        }

        return op.Values.ToList();
    }
}
