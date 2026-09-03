public class Solution {

    public string Encode(IList<string> strs) {
        var str = new StringBuilder();
        foreach(var ip in strs)
        {
            str.Append(ip.Length);
            str.Append("#");
            str.Append(ip);
        }
        return str.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int ch = 0;

        while(ch < s.Length)
        {
            int j = ch;
            while (s[j] != '#') j++;
            int len = int.Parse(s.Substring(ch, j - ch));
            ch = j + 1;
            result.Add(s.Substring(ch, len));
            ch += len;
        }

        return result;
   }

}
