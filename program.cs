using IronPdf;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Iron PDF Start");

        var renderer = new ChromePdfRenderer();// Instantiate Renderer
        var pdf = renderer.RenderHtmlFileAsPdf("C:/Users/steve/OneDrive/Desktop/ironpdf/index.html");// Create a PDF from an existing HTML file using C#
        pdf.SaveAs("C:/Users/steve//OneDrive/Desktop/ironpdf/output.pdf");// Export to a file or Stream

        Console.WriteLine("Iron PDF End");
    }
}