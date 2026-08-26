public class Solution {
    public void Rotate(int[] nums, int k) {
        int j = k;

        while (j > 0)
        {
            var temp = nums[nums.Length - 1];

            for (int i = nums.Length - 1 ; i > 0 ; i--)
            {
                nums[i] = nums[i-1];
            }

            nums[0] = temp;

            j--;
        }
        
    }
}