public class Solution {
    public int RemoveElement(int[] nums, int val) {

        var temp = new List<int>();

        foreach(var num in nums)
        {
            if (num != val) temp.Add(num);
        }

        for(int i = 0 ; i < temp.Count(); i++)
        {
            nums[i] = temp[i];
        }

        return temp.Count();
    }
}