class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:
        numLength = len(nums)
        if k > numLength:
            return -1
        maxSum = sum(nums[:k])
        tempSum = maxSum
        for i in range(1,numLength - k + 1):
            tempSum = tempSum - nums[i - 1] + nums[i + k - 1]
            maxSum = max(tempSum, maxSum)
       
        return maxSum/k
       
