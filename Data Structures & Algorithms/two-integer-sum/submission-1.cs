public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var op = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length ; i++)
        {
            if (!op.ContainsKey(target-nums[i])){
                op.Add(nums[i], i);
            } else {
                return new int[] {op[target-nums[i]], i};
            }
        }
        return null;
    }
}
