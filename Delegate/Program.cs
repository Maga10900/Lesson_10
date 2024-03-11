using Delegate;


Console.Write("Enter name 1: ");
string? basic = Console.ReadLine();
Console.Write("Enter name 2: ");
string? pro = Console.ReadLine();
Console.Write("Enter name 3: ");
string? expert = Console.ReadLine();

DocumentProgram doc = new (basic!);
ProDocumentProgram prodoc = new(pro!);
ExpertDocument expertdoc = new (expert!);
doc.OpenDocument();
doc.SaveDocument();
doc.EditDocument();
prodoc.SaveDocument();
prodoc.EditDocument();
prodoc.SaveDocument();
expertdoc.SaveDocument();
expertdoc.EditDocument();
expertdoc.OpenDocument();