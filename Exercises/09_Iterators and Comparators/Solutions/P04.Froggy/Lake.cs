namespace P04.Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var evenPositions = new List<int>();
            var oddPositions = new List<int>();

            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenPositions.Add(stones[i]);
                }
                else
                {
                    oddPositions.Add(stones[i]);
                }
            }

            for (int i = 0; i < evenPositions.Count; i++)
            {
                yield return evenPositions[i];
            }

            for (int i = oddPositions.Count - 1; i >= 0; i--)
            {
                yield return oddPositions[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
