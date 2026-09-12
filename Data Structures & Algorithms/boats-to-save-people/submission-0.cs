public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);

        int i = 0;
        int j = people.Length - 1;
        int result = 0;

        while (i <= j) {
            //Console.WriteLine(i + ": " + j);
            if (i == j && people[i] <= limit){
                result++;
                return result;
            }

            if (people[i] + people[j] <= limit) {
                i++;
                j--;
                result++;
            } else if (people[j] <= limit) {
                j--;
                result++;
            }
            //Console.WriteLine(i + ": " + j);
        }

        return result;
    }
}