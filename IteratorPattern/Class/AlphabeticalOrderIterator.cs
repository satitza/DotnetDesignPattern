namespace IteratorPattern.Class
{
    using IteratorPattern.Abstract;
    
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.getItems().Count;
            }
        }
        
        public override object Current()
        {
            return this._collection.getItems().ToList()[this._position];
        }

        
        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override void Reset()
        {
            // if reverse = false position start at index 0
            // if reverse = true position start at count of collection item -1
            this._position = this._reverse ? this._collection.getItems().Count - 1 : 0;
        }
    }
}
