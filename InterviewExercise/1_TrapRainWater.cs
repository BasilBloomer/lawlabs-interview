namespace InterviewExercise;

/// <summary>
/// Given an array of N non-negative integers arr[] representing an elevation map where the width of each bar is 1,
/// compute how much water it is able to trap after raining.
/// See picture rainwater30204filled.png for example illustrating the problem.
/// </summary>
public class TrapRainWater
{
    static int MaxWater(IEnumerable<int> elevationLevels)
    {
        // TODO: Implement the solution
        return 0;
    }

    [Test]
    public void MaxWater_202_returns_2()
    {
        // See picture rainwater202.png
        var elevationLevels = new int[] { 2, 0, 2 };

        var result = MaxWater(elevationLevels);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void MaxMater_30204_returns_7()
    {
        // See picture rainwater30204.png
        var elevationLevels = new int[] { 3, 0, 2, 0, 4 };

        var result = MaxWater(elevationLevels);

        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void MaxWAter_010210132121_returns_6()
    {
        // See picture rainwater010210132121.png
        var elevationLevels = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

        var result = MaxWater(elevationLevels);

        Assert.That(result, Is.EqualTo(6));
    }
}