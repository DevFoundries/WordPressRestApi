using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi.Test
{
    [TestClass]
    public class WordPressApiClientTest
    {
        private WordPressApiClient client;

        [TestInitialize]
        public void TestInit()
        {
            client = new WordPressApiClient("https://wbsimms.com/wp-json/wp/v2/");
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public async Task GetPostTest()
        {
            var result = await client.GetPosts(new PostsQuery() { PerPage = "1" });
            Assert.IsNotNull(result);

            var onePost = await client.GetPost(new PostQuery(), result.First().Id);
            Assert.IsNotNull(onePost);
        }

        [TestMethod]
        public async Task GetPostsTest()
        {
            var result = await client.GetPosts(new PostsQuery(){PerPage = "20"});
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetCategoriesTest()
        {
            var result = await client.GetCategories(new CategoriesQuery() { PerPage = "20", HideEmpty = "true"});
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetTagsTest()
        {
            var result = await client.GetTags(new TagsQuery() { PerPage = "20", HideEmpty = "true" });
            Assert.IsNotNull(result);
        }


    }
}
