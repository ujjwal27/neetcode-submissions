public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {

        if (nums.Length <= 1 || k == 0) return false;

        int l = 0;
        var _set = new HashSet<int>();

        for (int r = 0 ; r < nums.Length ; r++)
        {
            if (r - l > k){
                _set.Remove(nums[l]);
                l++;
            }

            if (_set.Contains(nums[r])) return true;

            _set.Add(nums[r]);
        }

       
        return false;
    }
}