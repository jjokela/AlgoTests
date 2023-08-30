namespace Tests.Easy;

internal class LinkedListCycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public bool HasCycle(ListNode head)
    {
        var walker = head;
        var runner = head;

        while (runner is not null && runner.next is not null)
        {
            runner = runner.next.next;
            walker = walker.next;

            if (runner is null)
            {
                return false;
            }

            if (walker == runner)
            {
                return true;
            }
        }

        return false;
    }
}