public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int numsLength = nums.Length;
        for (int i = 0; i < numsLength; i++){
            freq[nums[i]] = freq.GetValueOrDefault(nums[i],0)+1;
        }
        foreach (var kvp in freq){
            if (kvp.Value > numsLength/2){
                return kvp.Key;
            }
        }
        return 0;
    }
}
