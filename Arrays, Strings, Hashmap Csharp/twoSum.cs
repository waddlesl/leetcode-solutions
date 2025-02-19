public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> complements = new Dictionary<int, int>();


	  “2” : “0”
	  “7” : “1”
	  “11” : “2”
          “15” : “3”
	  target: 9
	  return { 0, 1}


        int current;
        int complement;


        for (int i = 0; i < nums.Length; i++){
            current = nums[i];
            complement = target - current;
            if (complements.ContainsKey(complement)){
                return new int[] {complements[complement], i};
            }
            complements[current] = i;
        }
        return new int[0];
    }
}
