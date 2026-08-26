public class Solution {
    public int LongestConsecutive(int[] nums) {
        int curr_len = nums.Length;

        if (curr_len == 0 || curr_len == 1) return curr_len;

        var ip = new HashSet<int>();
        var max_length = 1;

        foreach(var num in nums)
        {
            if(!ip.Contains(num))
                ip.Add(num);
        }

        foreach(var num in nums)
        {
            if (!ip.Contains(num - 1))
            {   
                int curr_length = 1;
                int curr_num = num + 1;

                while (ip.Contains(curr_num)) 
                {
                    curr_length = curr_length + 1;
                    max_length = Math.Max(curr_length, max_length);
                    curr_num += 1;
                }
            }
        }
        return max_length;
    }
}
