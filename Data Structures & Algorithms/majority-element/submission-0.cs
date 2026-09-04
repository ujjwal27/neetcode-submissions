public class Solution {
    public int MajorityElement(int[] nums) {

        var _hash = new Dictionary<int, int>();
        var len = nums.Length;
        foreach(var num in nums)
        {
            if (!_hash.ContainsKey(num))
                _hash.Add(num, 1);
            else
                _hash[num] += 1;
        }

        foreach(var kp in _hash)
        {
            if (kp.Value > len/2)
            {
                return kp.Key;
            }
        }

        return 0;
    }
}