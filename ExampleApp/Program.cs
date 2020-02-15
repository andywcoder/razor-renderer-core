using System.Threading.Tasks;
using ExampleAppRazorTemplates.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RazorRenderer;

namespace ExampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var renderer = RazorViewToStringRendererFactory.CreateRenderer();
            var html = await renderer.RenderViewToStringAsync(
                "/Views/ExampleView.cshtml",
                new ExampleModel() { PlainText = "Some text", HtmlContent = "<em>Some emphasized text</em>" },
                new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary()) { { "Value1", 123 }, { "Value2", "Some view data" } });
            System.Console.Write(html);
        }
    }
}
