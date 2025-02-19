using System.Collections.Generic;
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> hashnums = new HashSet<int>(nums1); // hash to check intersect
        HashSet<int> intersect = new HashSet<int>(); // empty list to add unique intersect
        for(int i = 0; i < nums2.Length; i++){
            // to avoid excessive iteration
            if (intersect.Count == nums1.Length){
                return intersect.ToArray();
            }
            // add the nums to list is unique AND intersects
            if (!intersect.Contains(nums2[i]) && hashnums.Contains(nums2[i])){
                intersect.Add(nums2[i]);
            }
        }
       return intersect.ToArray();
    }
}
