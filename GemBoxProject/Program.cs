// See https://aka.ms/new-console-template for more information


// the Key
using GemBox.Document;

ComponentInfo.SetLicense("FREE-LIMITED-KEY");

DocumentModel document = new DocumentModel();

Section section = new Section(document);
document.Sections.Add(section);

Paragraph paragraph = new Paragraph(document);
section.Blocks.Add(paragraph);

Run run = new Run(document, "Hello World!");
paragraph.Inlines.Add(run);

// link
// https://www.gemboxsoftware.com/pdf/examples/c-sharp-vb-net-pdf-library/101
Console.WriteLine("Hello, World!");

