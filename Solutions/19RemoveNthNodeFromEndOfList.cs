using System.Collections;

namespace LeetCode.Solutions;

public class RemoveNthNodeFromEndOfList
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // Empty list
        if (head == null) return head;
        // Illegal input
        if (n <= 0) return head;

        // Prep variables
        Stack tree = new Stack();
        ListNode currentNode = head;

        // Find the end of the list
        while (currentNode != null)
        {
            tree.Push(currentNode);
            currentNode = currentNode.next;
        }

        // Impossible size
        if (tree.Count < n)
            return head;

        // If we simply remove head, skip the popping
        if (tree.Count == n)
            return head.next;

        // Move down the list nth amount of nodes
        for (int i = 0; i < n; i++)
        {
            currentNode = tree.Pop() as ListNode;
        }

        // Link the predecessor with the successor
        ListNode predecessor = tree.Pop() as ListNode;
        predecessor.next = currentNode.next;

        // Return the head
        return head;
    }
    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
}