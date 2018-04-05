using System.Collections;
using System.Collections.Generic;

public class Lake : IEnumerable<int>
{
    public Lake(params int[] stones)
    {
        this.stones = new List<int>(stones);
    }

    private List<int> stones;

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.stones.Count; i += 2)
        {
            yield return this.stones[i];
        }

        bool countIsOdd = this.stones.Count % 2 != 0;
        var start = this.stones.Count - 1;
        if (countIsOdd)
            start--;

        for (int i = start; i >= 0; i -= 2)
        {
            yield return this.stones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = 0; i < this.stones.Count; i += 2)
        {
            yield return this.stones[i];
        }

        bool countIsOdd = this.stones.Count % 2 != 0;
        var start = this.stones.Count - 1;
        if (countIsOdd)
            start--;

        for (int i = start; i >= 0; i -= 2)
        {

        }
    }
}