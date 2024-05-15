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
        int [] anLevels=elevationLevels.ToArray<int>();
        int nMax=fnMax(anLevels);
        //lowest index of the highest wall:
        int nLeftMax=0;
        //highest index of the highest wall:
        int nRightMax=0;
        //max yet encountered in the loop:
        int nMaxYet=0; 
        //volume of water:
        int nVolume=0;
        //calculate nLeftMax
        for(int a=0;a<anLevels.Length;a++){
            if(anLevels[a]==nMax){
                nLeftMax=a;
                break;
            }
        }
        //calculate nRightMax
        for(int a=anLevels.Length-1;a>=0;a--){
            if(anLevels[a]==nMax){
                nRightMax=a;
                break;
            }
        }
        //calculate ascending section
        if(nLeftMax!=0){
            nMaxYet=anLevels[0];
            for(int a=0; a<nLeftMax; a++){
                if(nMaxYet<anLevels[a]) nMaxYet=anLevels[a];
                nVolume+=nMaxYet-anLevels[a];
            }
        }
        //calculate descending section
        if(nRightMax!=anLevels.Length){
            nMaxYet=anLevels[anLevels.Length-1];
            for(int a=anLevels.Length-1;a>nRightMax;a--){
                if(nMaxYet<anLevels[a]) nMaxYet=anLevels[a];
                nVolume+=nMaxYet-anLevels[a];
            }
        }
        //calculate middle section
        if(nLeftMax!=nRightMax){
            for(int a=nLeftMax+1; a<nRightMax; a++)
                nVolume+=nMax-anLevels[a];
        }
        return nVolume;
    }

    static int fnMax(int[] array){
        int nMax = array[0];

        for (int a = 1; a < array.Length; a++)
            if (array[a] > nMax) 
                nMax = array[a];

        return nMax;
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