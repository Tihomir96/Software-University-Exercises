using System.Collections;
using System.Collections.Generic;

namespace _4.Froggy
{
    public class Lake:IEnumerable<int>
    {
        private readonly List<int> stones;

        public Lake(List<int> stones )
        {
            this.stones=new List<int>(stones);
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stones[i];
                }
            }
            int lastIndex = this.stones.Count;
            if (this.stones.Count % 2 != 0)
            {
                lastIndex = this.stones.Count - 1;
            }
            for (int i = lastIndex - 1; i >= 0; i--)
            {
                if (i % 2 == 1) yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
