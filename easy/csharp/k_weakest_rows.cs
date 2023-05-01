// 1337. The K Weakest Rows in a Matrix
// You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians).
// The soldiers are positioned in front of the civilians.
// That is, all the 1's will appear to the left of all the 0's in each row.
// Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        int[] strengths = getRowStrengths(ref mat);
        int[] lowestValueIndicies = new int[k];
        Array.Fill(lowestValueIndicies, Int32.MinValue);
        for (int i = 0; i < k; i++)
        {
            int? lowestValueIndex = null;
            for (int j = strengths.Length - 1; j >= 0; j--)
            {
                if (strengths[j] <= strengths[lowestValueIndex ?? j] && lowestValueIndicies.Contains(j) == false)
                {
                    lowestValueIndex = j;
                }
            }
            lowestValueIndicies[i] = lowestValueIndex ?? 0;
        }
        return lowestValueIndicies;
    }

    public int[] getRowStrengths(ref int[][] mat)
    {
        int[] strengths = new int[mat.Length];
        for (int i = 0; i < mat.Length; i++)
        {
            int soldierCount = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                soldierCount += mat[i][j];
            }
            strengths[i] = soldierCount;
        }
        return strengths;
    }
}