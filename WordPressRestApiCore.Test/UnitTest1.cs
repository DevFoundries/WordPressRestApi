using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressRestApiStandard;
using WordPressRestApiStandard.QueryModel;

namespace WordPressRestApiCore.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest()
        {
            WordPressRestApiStandard.WordPressApiClient client = new WordPressApiClient("https://wbsimms.com/wp-json/wp/v2/");
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public async Task GetPostsTest()
        {
            WordPressRestApiStandard.WordPressApiClient client = new WordPressApiClient("https://wbsimms.com/wp-json/wp/v2/");
            var result = await client.GetPosts(new PostsQuery() { PerPage = 20 });
            Assert.IsNotNull(result);
        }
    }
}
