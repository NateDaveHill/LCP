namespace LCP;

public class MaxProfitAlgo
{
    public int MaxProfit(int[] prices)
    {
        //List<int> buyingValue = new List<int>();
        //IList<int> sellingValue = new List<int>();
        //int count = 0;


        //for (int i = 0; i < prices.Length; i++)
        //{
        //    count++;

        //    for (int j = i + 1; j < prices.Length; j++)
        //    {
        //        if (prices[i] < prices[j])
        //        {
        //            buyingValue.Add(prices[i]);
        //        }
        //        else
        //        {
        //            sellingValue.Add(prices[i]);
        //        }

        //        if (buyingValue.Count == 0)
        //        {
        //            sellingValue.Clear();

        //        }
        //    }
        //}

        //try
        //{
        //    return sellingValue.Max() - buyingValue.Min();
        //}
        //catch (Exception e)
        //{
        //    return 0;
        //}


        if (prices == null || prices.Length == 0) return 0;
        int minPrice = int.MaxValue, maxProfit = 0;

        foreach (var price in prices)
        {
            if (price < minPrice) minPrice = price;
            if (price - minPrice > maxProfit) maxProfit = price - minPrice;
        }

        return maxProfit;
    }
}