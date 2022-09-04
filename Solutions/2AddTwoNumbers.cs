namespace LeetCode.Solutions;

public class AddTwoNumbers
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

    //https://leetcode.com/problems/add-two-numbers/
    public ListNode Result(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode();
        var temp = head;
        int curval = 0;
        while (l1 != null || l2 != null)
        {
            curval = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + curval;
            temp.next = new ListNode(curval % 10);
            temp = temp.next;
            curval = curval / 10;
            // if next l1/l2 is not null, go to the next node
            l1 = l1?.next;
            l2 = l2?.next;
        }

        // if there is overflow left, add a node
        if (curval != 0)
        {
            temp.next = new ListNode(curval);
        }

        return head.next;
    }
}