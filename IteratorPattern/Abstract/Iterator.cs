namespace IteratorPattern.Abstract
{
    using System.Collections;
    
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract bool MoveNext();
        
        public abstract object Current();

        public abstract void Reset();

    }
}

