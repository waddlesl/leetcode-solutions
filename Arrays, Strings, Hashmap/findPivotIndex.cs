public class Solution {
    public int PivotIndex(int[] nums) {
        for (int i = 0; i < nums.Length; i++){
            int totalLeft = 0;
            int totalRight = 0;
            int currentIndex = i;


            for (int j = currentIndex - 1; j >= 0; j--){
                if (j == -1){
                    continue;
                }
                totalLeft += nums[j];
            }
             for (int j = currentIndex + 1; j < nums.Length; j++){
                totalRight += nums[j];
            }


            if (totalLeft == totalRight){
                return currentIndex;
            }
        }
        return -1;
    }
}
