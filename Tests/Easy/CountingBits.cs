namespace Tests.Easy;

public class CountingBits
{
    public int[] CountBits(int n)
    { 
        // All whole numbers can be represented by 2N (even) and 2N+1 (odd).
        // For a given binary number, multiplying by 2 is the same as adding a zero at the end
        // when multiplying the number, it has the same bit count as original -> number divided by 2 has the same bit count
        // x2 + 1 => bit count is same+1

        var counter = new List<int> { 0 };

        for (int i = 1; i < n + 1; i++)
        {
            counter.Add(counter[i/2] + i % 2);
        }

        return counter.ToArray();
    }
}