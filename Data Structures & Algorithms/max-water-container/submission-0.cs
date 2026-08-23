public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int max_volume = 0;

        while (l < r)
        {
            int currVolume = Math.Abs(l - r) * Math.Min(heights[l], heights[r]);
            max_volume = Math.Max(max_volume, currVolume);

            if (heights[l] < heights[r]) l++; else r--;
        }
        return max_volume;
    }
}
