namespace Design_Patterns.Behavioral_Patterns.Memento;
// Memento class
class TextEditorMemento
{
    public string Content { get; }

    public TextEditorMemento(string content)
    {
        Content = content;
    }
}

// Originator class
class TextEditor
{
    public string Content { get; set; }

    public TextEditorMemento Save()
    {
        return new TextEditorMemento(Content);
    }

    public void Restore(TextEditorMemento memento)
    {
        Content = memento.Content;
    }
}

// Caretaker class
class History
{
    private Stack<TextEditorMemento> _history = new Stack<TextEditorMemento>();

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
    }
}

// Usage
//class Program
//{
//    static void Main()
//    {
//        var editor = new TextEditor();
//        var history = new History();

//        editor.Content = "First version";
//        history.Save(editor); // Save state

//        editor.Content = "Second version";
//        history.Save(editor); // Save state

//        editor.Content = "Third version";
//        Console.WriteLine(editor.Content); // "Third version"

//        history.Undo(editor); // Undo to previous state
//        Console.WriteLine(editor.Content); // "Second version"

//        history.Undo(editor); // Undo again
//        Console.WriteLine(editor.Content); // "First version"
//    }
//}