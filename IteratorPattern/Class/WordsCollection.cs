using System.Collections;
using IteratorPattern.Abstract;

namespace IteratorPattern.Class
{
    public class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
        {
            this._direction = !this._direction;
        }

        public ICollection<string> getItems()
        {
            return this._collection;
        }

        public void AddItem(string item)
        {
            this._collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, this._direction);
        }
    }
}
