using ExampleAppRazorTemplates.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorRenderer;
using System.Threading.Tasks;

namespace RazorRendererTest
{
    [TestClass]
    public class RazorViewToStringRendererTest
    {
        [TestMethod]
        public async Task RenderViewToStringAsync_CompiledRazorTemplateAndModel_Html()
        {
            // Arrange
            var razorViewToStringRenderer = RazorViewToStringRendererFactory.CreateRenderer();

            // Act
            var html = await razorViewToStringRenderer.RenderViewToStringAsync(
                "/Views/ExampleView.cshtml",
                new ExampleModel() { PlainText = "Some text", HtmlContent = "<em>Some emphasized text</em>" },
                new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary()) { { "Value1", 123 }, { "Value2", "Some view data" } });

            // Assert
            Assert.IsNotNull(html);
        }
    }
}
