using System.Threading.Tasks;
using ExampleAppRazorTemplates.Models;
using RazorRenderer;

namespace ExampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var renderer = RazorViewToStringRendererFactory.CreateRenderer();
            var html = await renderer.RenderViewToStringAsync("/Views/ExampleView.cshtml", new ExampleModel() { PlainText = "Bla bla bla", HtmlContent = "<em>Bla bla bla</em>" });
            System.Console.Write(html);
        }
    }
}
