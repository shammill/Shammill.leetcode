// 876. Middle of the Linked List
// Given the head of a singly linked list, return the middle node of the linked list.
// If there are two middle nodes, return the second middle node.
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
    public ListNode MiddleNode(ListNode head)
    {
        int count = head.Count();
        ListNode result = head;
        for (int i = 1; i <= count; i++)
        {
            result = result.next;
        }
        return result;
    }
}

public static class ListNodeExtensions
{
    public static int Count(this ListNode node)
    {
        int count = 1;
        ListNode nextNode = node;
        while (nextNode.next != null)
        {
            nextNode = nextNode.next;
            count++;
        }
        return count;
    }
}