public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int i = 0;
        int j = k-1;
        int curr_average = 0;
        int result = 0;

        for (int x = i ; x < k ; x++)
        {
            curr_average += arr[x];
        }

        if (curr_average/k >= threshold) result ++;
        j++;

        while (j < arr.Length) 
        {
            curr_average = curr_average + arr[j] - arr[i];

            if (curr_average/k >= threshold) result ++;
            j++;
            i++;
        }

        return result;
    }
}