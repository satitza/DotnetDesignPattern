using MememtoPattern.Class;

namespace MememtoPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Mememto pattern).");

            TextEditor editor = new TextEditor();
            Caretaker history = new Caretaker();

            editor.Type("Hello, ");
            history.Save(editor);  // บันทึกสถานะ

            editor.Type("World!");
            // history.Save(editor);  // บันทึกสถานะอีกครั้ง

            Console.WriteLine("Current Text: " + editor.GetText());  // Output: Hello, World!

            history.Undo(editor);  // ย้อนกลับ 1 ครั้ง
            Console.WriteLine("After Undo: " + editor.GetText());  // Output: Hello, 

            history.Undo(editor);  // ย้อนกลับอีกครั้ง
            Console.WriteLine("After Undo Again: " + editor.GetText());  // Output: (ว่างเปล่า)

        }
    }

}


