public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int currentBuy = prices[0];


        // skip first price since it is currentBuy
        for(int i = 1; i < prices.Length; i++){
           
            int currentProfit = 0;


            // update currentBuy if theres a lower price
            if (prices[i] < currentBuy){
             currentBuy = prices[i];
            }
           
            // update current profit by subtracting price and current buy
            if (prices[i] > 0){
            currentProfit =  prices[i] - currentBuy;  
            }


            // update max profit
            if(currentProfit > maxProfit){
                maxProfit = currentProfit;
            }


        }
        return maxProfit;
    }
}
