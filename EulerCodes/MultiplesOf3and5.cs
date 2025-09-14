using System;

namespace EulerCodes;

public class MultiplesOf3and5
{
    public static int Solve(int limit)
    {
        int sum = 0;
        for (int i = 0; i < limit; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    public static int SolveInLINQ(int limit)
    {
        var numbers = Enumerable.Range(0, limit);
        return numbers.Where(_ => _ % 3 == 0 || _ % 5 == 0).Sum();
    }
}
