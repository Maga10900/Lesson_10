namespace Delegate;

public class DocumentProgram
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document OPened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
    public DocumentProgram()
    {

    }
    public DocumentProgram(string name)
    {

    }
}
