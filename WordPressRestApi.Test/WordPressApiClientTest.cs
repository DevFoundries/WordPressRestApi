using System;
using System.Collections.Generic;
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
            var result = await client.GetPosts(new PostsQuery() { PerPage = 1 });
            Assert.IsNotNull(result);

            var onePost = await client.GetPost(new PostQuery(), result.First().Id);
            Assert.IsNotNull(onePost);
        }

        [TestMethod]
        public async Task GetPostsTest()
        {
            var result = await client.GetPosts(new PostsQuery(){PerPage = 20});
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetPostsWithAuthorAndCateogoryTest()
        {
            var result = await client.GetPosts(new PostsQuery() { Author = new List<int>() { 1 }, Categories = new List<int>(){512}});
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public async Task GetCategoriesTest()
        {
            var result = await client.GetCategories(new CategoriesQuery() { PerPage = 20, HideEmpty = true});
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetTagsTest()
        {
            var result = await client.GetTags(new TagsQuery() { PerPage = 20, HideEmpty = true });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetPagesTest()
        {
            var result = await client.GetPages(new PagesQuery() { PerPage = 20, Author = new List<int>() { 1 } });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetPageTest()
        {
            var result = await client.GetPage(new PageQuery(),2551);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetUsersTest()
        {
            var result = await client.GetUsers(new UsersQuery() {PerPage = 30});
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetUserTest()
        {
            var result = await client.GetUser(new UserQuery() { Context = Context.View }, 1);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetMediasTest()
        {
            var result = await client.GetMedias(new MediasQuery() { PerPage = 30});
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetMediaTest()
        {
            var result = await client.GetMedia(new MediaQuery() { Context = Context.View }, 8845);
            Assert.IsNotNull(result);
        }


    }
}
