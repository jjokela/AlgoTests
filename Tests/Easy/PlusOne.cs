namespace Tests.Easy;

internal class PlusOneTest
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            // inc digit
            digits[i] += 1;

            if (digits[i] != 10)
            {
                return digits;
            }

            // if number is 10 after inc, set it to 0
            digits[i] = 0;
        }

        // in case all numbers are nines, add 1 to the begin
        var numberList = digits.ToList();
        numberList.Insert(0, 1);

        return numberList.ToArray();
    }
}
