namespace Tests.Easy;

internal class KthLargestElementInStream
{
    private PriorityQueue<int, int> pq;
    private int capacity;

    //public KthLargest(int k, int[] nums)
    //{
    //    capacity = k;
    //    pq = new(capacity);

    //    foreach (var num in nums)
    //    {
    //        pq.Enqueue(num, num);
    //    }

    //    while (pq.Count > capacity)
    //    {
    //        pq.Dequeue();
    //    }
    //}

    public int Add(int val)
    {
        pq.Enqueue(val, val);

        if (pq.Count > capacity)
        {
            pq.Dequeue();
        }

        return pq.Peek();
    }
}