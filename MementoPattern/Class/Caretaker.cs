using MememtoPattern.Interface;

namespace MememtoPattern.Class
{
    public class Caretaker
    {
        private readonly Stack<TextMemento> _history = new Stack<TextMemento>();

        public void Save(TextEditor editor)
        {
            _history.Push(editor.Save());
        }

        public void Undo(TextEditor editor)
        {
            if (_history.Count > 0)
            {
                editor.Restore(_history.Pop());
            }
            else
            {
                editor.Restore(new TextMemento(string.Empty));
            }
        }
    }
}

