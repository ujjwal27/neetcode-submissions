public class Solution {
    public bool hasDuplicate(int[] nums) {

        var uniqueset = new HashSet<int>();

        foreach(var num in nums)
        {
            if(uniqueset.Contains(num))
                return true;
            else 
                uniqueset.Add(num);
        }
        return false;
    }
}