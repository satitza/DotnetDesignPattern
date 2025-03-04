using System.Collections;

namespace IteratorPattern.Abstract
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}

