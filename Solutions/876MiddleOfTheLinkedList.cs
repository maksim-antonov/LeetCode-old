namespace LeetCode.Solutions;

public class MiddleOfTheLinkedList
{
    //https://leetcode.com/problems/middle-of-the-linked-list/
    public ListNode MiddleNode(ListNode head)
    {
        List<ListNode> list = new List<ListNode>();

        while (head != null)
        {
            list.Add(head);
            head = head.next;
        }

        return list[list.Count / 2];
    }

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
}