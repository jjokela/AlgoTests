using static Tests.Easy.LinkedListCycle;

namespace Tests.Easy;

internal class MergeTwoSortedLists
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

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode();
        var movingPointerNode = dummy;

        while (list1 is not null && list2 is not null)
        {
            if (list1.val >= list2.val) // pick list B
            {
                movingPointerNode.next = list2;
                list2 = list2.next;
            }
            else // pick list A
            {
                movingPointerNode.next = list1;
                list1 = list1.next;
            }

            movingPointerNode = movingPointerNode.next;
        }

        if (list1 is not null)
        {
            movingPointerNode.next = list1;
        } else if (list2 is not null)
        {
            movingPointerNode.next = list2;
        }

        return dummy.next;
    }
}