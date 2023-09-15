using AspNetCoreWebApplication.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplicationTest.Controllers
{
    public class HelloControllerTest
    {
        [Fact]
        public void NoInputParamGetResponseTest()
        {
            // HelloController controller = new HelloController();
            // var response = controller.Get().Value as Response;
            // Assert.Equal("Hello World!!!", response.output);
        }
      
    }
}
