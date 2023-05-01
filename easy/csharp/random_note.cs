// 383. Ransom Note
// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
// Each letter in magazine can only be used once in ransomNote.
using System;
using System.Collections;
using System.Linq;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (magazine.Contains(ransomNote[i]))
            {
                magazine = magazine.Remove(magazine.IndexOf(ransomNote[i]), 1);
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}