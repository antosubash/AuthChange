using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Anto.AuthChange.Pages
{
    public class Index_Tests : AuthChangeWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
