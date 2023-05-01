// 1491. Average Salary Excluding the Minimum and Maximum Salary
//You are given an array of unique integers salary where salary[i] is the salary of the ith employee.
//Return the average salary of employees excluding the minimum and maximum salary.
using System;

public class Solution
{
    public double Average(int[] salaries)
    {
        int? lowest = null;
        int? highest = null;
        foreach (int salary in salaries)
        {
            if (lowest == null || lowest < salary)
            {
                lowest = salary;
            }
            if (highest == null || highest > salary)
            {
                highest = salary;
            }
        }

        double sum = 0;
        double count = 0;
        foreach (int salary in salaries)
        {
            if (salary != lowest && salary != highest)
            {
                sum += salary;
                count++;
            }
        }
        var average = sum / count;
        return average;
    }
}