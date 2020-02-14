using ExampleAppRazorTemplates.Models;
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
            var html = await razorViewToStringRenderer.RenderViewToStringAsync("/Views/ExampleView.cshtml", new ExampleModel() { PlainText = "Bla bla bla", HtmlContent = "<em>Bla bla bla</em>" });

            // Assert
            Assert.IsNotNull(html);
        }
    }
}
