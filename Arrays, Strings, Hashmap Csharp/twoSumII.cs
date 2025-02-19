public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> complements = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++){
            int current = numbers[i];
            int complement = target - current;
            if (complements.ContainsKey(complement)){
                return new int [] {complements[complement]+1, i+1};
            }
            complements[current] = i;
        }
        return new int[0];
    }
}
