using System.Collections;
using System.Collections.Generic;

namespace EnumeratorEnumerable
{
    partial class FiveIntegers: IEnumerable<int>
    {
        int[] _values;
        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _values)
            {
                yield return item;

            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        // yield replacd the Manually Enumerator class
        //public IEnumerator GetEnumerator() => new Enumerator(this);


    }
}
