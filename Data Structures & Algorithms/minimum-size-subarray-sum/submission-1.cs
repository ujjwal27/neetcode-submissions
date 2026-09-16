public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int len = nums.Length;
        
        if (len == 0) return 0;

        int i = 0;
        int curr_sum = 0;
        int min_len = Int32.MaxValue;

        if (len == 1 && nums[0] != target) return 0;
        if (len == 1 && nums[0] == target) return 1;

       // Loop through the array with the right pointer 'j'
        for (int j = 0; j < len; j++) {
            curr_sum += nums[j]; // Expand the window
            
            // Shrink the window from the left as long as the condition is met
            while (curr_sum >= target) {
                min_len = Math.Min(min_len, j - i + 1);
                curr_sum -= nums[i];
                i++; // Move the left pointer forward
            }
        } 

        return min_len == Int32.MaxValue ? 0 : min_len;
        
    }
}