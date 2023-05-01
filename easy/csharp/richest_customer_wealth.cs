// 1672. Richest Customer Wealth
// You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the ith customer has in the jth bank.
// Return the wealth that the richest customer has.
// A customer's wealth is the amount of money they have in all their bank accounts.
// The richest customer is the customer that has the maximum wealth.
using System;


public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int highestNumber = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
                if (highestNumber < sum)
                {
                    highestNumber = sum;
                }
            }
        }
        return highestNumber;
    }
}