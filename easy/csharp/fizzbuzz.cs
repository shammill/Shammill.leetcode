// 412. Fizz Buzz
// Given an integer n, return a string array answer (1-indexed) where:
// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
// answer[i] == "Fizz" if i is divisible by 3.
// answer[i] == "Buzz" if i is divisible by 5.
// answer[i] == i(as a string) if none of the above conditions are true.

using System;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        List<String> results = new List<String>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                results.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                results.Add("Buzz");
            }
            else
            {
                results.Add(i.ToString());
            }
        }
        return results;
    }
}