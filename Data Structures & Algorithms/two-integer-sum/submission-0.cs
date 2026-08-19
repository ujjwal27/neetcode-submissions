public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        var op = new int[2];

        for (int i = 0; i < nums.Length; i++) {
            var numCheck = target - nums[i];
            if (dict.ContainsKey(numCheck))
            {
                op[0] = dict[numCheck];
                op[1] = i;
            } else {
                dict.Add(nums[i], i);
            }
        }

        return op;
    }
}
