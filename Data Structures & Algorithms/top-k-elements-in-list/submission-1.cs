public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var lookup = new Dictionary<int, int>();
        var result = new List<int>();

        foreach(var num in nums)
        {
            if(!lookup.ContainsKey(num)) lookup.Add(num, 1);
            else lookup[num]+=1;
        }

        var topK = lookup.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key);
       
        return topK.ToArray();
    }
}
