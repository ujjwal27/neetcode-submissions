public class Solution {
    public bool IsAnagram(string s, string t) {

        var ip = new Dictionary<char, int>();

        foreach (var ch in s)
        {
            if (ip.ContainsKey(ch)) ip[ch]++;
            else {
                ip.Add(ch, 1);
            }
        }

        var ip2 = new Dictionary<char, int>();

        foreach (var ch in t)
        {
            if (ip2.ContainsKey(ch)) ip2[ch]++;
            else {
                ip2.Add(ch, 1);
            }
        }

        foreach(var i in ip)
        {
            if( ip2.Count() != ip.Count() || !ip2.ContainsKey(i.Key) || ip2[i.Key] != ip[i.Key])
                return false;

        }

        return true;
    }
}
