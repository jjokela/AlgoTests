﻿namespace Tests.Easy;

internal class ReverseBits
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        for (var i = 0; i < 32; i++)
        {
            result = (result << 1) | (n & 1);
            n >>= 1;
        }
        return result;
    }
}