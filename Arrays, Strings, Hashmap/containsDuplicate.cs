public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> scanned = new HashSet<int>();
        foreach (int num in nums){
            if (scanned.Contains(num)){
                return true;
            }
            scanned.Add(num);
        }
        return false;
    }
}
