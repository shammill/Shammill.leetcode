// 344. Reverse String
// Write a function that reverses a string. The input string is given as an array of characters s.
// You must do this by modifying the input array in-place with O(1) extra memory.
using System;

public class Solution
{
    public void ReverseStringInPlace(char[] chars)
    {
        char swap;
        int j;
        for (int i = 0; i < chars.Length; i++)
        {
            swap = chars[i];
            j = chars.Length - 1 - i;
            if (i >= j)
            {
                break;
            }
            chars[i] = chars[j];
            chars[j] = swap;
        }
    }
}

// ideally you'd just use: Array.Reverse(chars);