namespace Tests.Easy;

internal class LastStoneWeightTest
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>();

        foreach (var stone in stones)
        {
            pq.Enqueue(stone, -stone);
        }

        while (pq.Count > 1)
        {
            var firstStone = pq.Dequeue();
            var secondStone = pq.Dequeue();

            // smash!
            if (firstStone != secondStone)
            {
                var newStone = Math.Abs(firstStone - secondStone);
                pq.Enqueue(newStone, -newStone);
            }
        }

        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
}