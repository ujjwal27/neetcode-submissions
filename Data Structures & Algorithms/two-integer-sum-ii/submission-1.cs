public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;

        while (l < r)
        {
            int curr_sum = numbers[l]+ numbers[r];

            if (curr_sum == target){
                return new int[] {l + 1, r + 1};
            } else if (curr_sum > target){
                r--;
            } else {
                l++;
            }
        }

        return null;
    }
}
