namespace InterviewExercise;

/// <summary>
/// The cost of a stock on each day is given in an array.
/// Find the maximum profit that you can make by buying and selling on those days.
/// You can only buy once before you sell. In other words, you are using all the money available to you to buy the stock every time.
/// If the given array of prices is sorted in decreasing order, then profit cannot be earned at all.
/// </summary>
public class StockBuySell
{
    static int MaxProfit(IEnumerable<int> stockPrices)
    {
            int[] anPrices = stockPrices.ToArray();
            int nTotalProfit = 0;

            for (int a = 1; a < anPrices.Length; a++)
                // If the current price is higher than the previous one, we can make a profit
                if (anPrices[a] > anPrices[a - 1])
                    // Add the profit from this transaction to the total profit
                    nTotalProfit += anPrices[a] - anPrices[a - 1];
                    
            return nTotalProfit;
    }

    [Test]
    public void Test1()
    {
        var stockPrices = new int[] { 100, 180, 260, 310, 40, 535, 695 };

        var result = MaxProfit(stockPrices);

        Assert.That(result, Is.EqualTo(865));
    }
}