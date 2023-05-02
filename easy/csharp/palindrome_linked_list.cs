// 234. Palindrome Linked List
// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        List<int> values = new List<int>();
        ListNode node = head;
        for (int i = 0; node != null; i++)
        {
            values.Add(node.val);
            node = node.next;
        }
        return IsPalindrome(values);
    }

    private bool IsPalindrome(List<int> values)
    {
        for (int i = 0, j = values.Count - 1; i < j; i++, j--)
        {
            if (values[i] != values[j])
            {
                return false;
            }
        }
        return true;
    }
}