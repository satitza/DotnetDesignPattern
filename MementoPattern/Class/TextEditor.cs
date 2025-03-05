using MememtoPattern.Interface;

namespace MememtoPattern.Class
{
    public class TextEditor
    {
        private string _text;

        public void Type(string words)
        {
            _text += words;
        }

        public string GetText()
        {
            return _text;
        }

        // สร้าง Memento เพื่อบันทึกสถานะปัจจุบัน
        public TextMemento Save()
        {
            return new TextMemento(_text);
        }

        // คืนค่าสถานะจาก Memento
        public void Restore(TextMemento memento)
        {
            _text = memento.State;
        }
        
    }
}

