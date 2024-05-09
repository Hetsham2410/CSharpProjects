using System;
using System.Collections;

namespace EnumeratorEnumerable
{
    partial class FiveIntegers
    {
        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            FiveIntegers _integers;
            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }
            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException($"Enumeration not started");
                    if(currentIndex == _integers._values.Length)
                        throw new InvalidOperationException($"Enumeration has ended");
                    return _integers._values[currentIndex];
                }
            }

            public bool MoveNext()
            {
                if (currentIndex >= _integers._values.Length - 1)
                    return false;
                return ++currentIndex < _integers._values.Length;
            }

            public void Reset() => currentIndex = -1;
            
        }

    }
}
