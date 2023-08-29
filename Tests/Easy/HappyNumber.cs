namespace Tests.Easy;

public class HappyNumber
{
    public bool IsHappy(int n)
    {
        var powerMap = new HashSet<int>();

        while (true)
        {
            var sum = 0;
            while (n != 0)
            {
                var digit = n % 10;
                n = n / 10;
                sum += (int)Math.Pow(digit, 2);
            }

            if (sum == 1)
            {
                return true;
            }

            if (powerMap.Contains(sum))
            {
                return false;
            }

            powerMap.Add(sum);
            n = sum;
        }
    }
}