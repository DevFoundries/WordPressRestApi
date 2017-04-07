using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi.Test
{
    [TestClass]
    public class WordPressApiClientTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            WordPressApiClient client = new WordPressApiClient("https://wbsimms.com/wp-json/v2");
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public async Task GetPostsTest()
        {
            WordPressApiClient client = new WordPressApiClient("https://wbsimms.com/wp-json/wp/v2");
            Assert.IsNotNull(client);
            var result = await client.GetPosts(new PostQuery(){PerPage = "20"});
            Assert.IsNotNull(result);
        }
    }
}
