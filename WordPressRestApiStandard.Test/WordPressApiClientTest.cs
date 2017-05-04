using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressRestApiStandard;
using WordPressRestApiStandard.CreateModel;
using WordPressRestApiStandard.Models;
using WordPressRestApiStandard.QueryModel;
using WordPressRestApiStandard.UpdateModel;

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
            var result = await client.GetPosts(new PostsQuery() { PerPage = 20 });
            Assert.IsNotNull(result);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public async Task GetPostsTooManyTest()
        {
            var result = await client.GetPosts(new PostsQuery() { PerPage = 2000 });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetPostsDefaultTest()
        {
            var result = await client.GetPosts(new PostsQuery());
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Count);
        }

        [TestMethod]
        public async Task GetPostsWithAuthorAndCateogoryTest()
        {
            var result = await client.GetPosts(new PostsQuery() { Author = new List<int>() { 1 }, Categories = new List<int>() { 512 } });
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public async Task GetCategoriesTest()
        {
            var result = await client.GetCategories(new CategoriesQuery() { HideEmpty = true });
            Assert.IsNotNull(result);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public async Task CategoryPerPageTooLargeTest()
        {
            var result = await client.GetCategories(new CategoriesQuery() { PerPage = 200, HideEmpty = true });
        }

        [TestMethod]
        public async Task CategoryDefaultTest()
        {
            var result = await client.GetCategories(new CategoriesQuery() { });
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Count);
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
            var result = await client.GetPage(new PageQuery(), 2551);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetUsersTest()
        {
            var result = await client.GetUsers(new UsersQuery() { PerPage = 30 });
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
            var result = await client.GetMedias(new MediasQuery() { PerPage = 30 });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetMediaTest()
        {
            var result = await client.GetMedia(new MediaQuery() { Context = Context.View }, 8845);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetSettingsTest()
        {
            var result = await client.GetSettings(new AuthenticationTokens() { ApplicationPassword = "Secret", UserName = "wbsimms" });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task UpdateSettingsTest()
        {
            var result = await client.UpdateSettings(
                new AuthenticationTokens() { ApplicationPassword = "Secret", UserName = "wbsimms" },
                new Settings() { Language = "en" });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task PostCreateTest()
        {
            var authToken = new AuthenticationTokens()
            {
                ApplicationPassword = "Secret",
                UserName = "wbsimms"
            };
            var result = await client.CreatePost(
                authToken,
                new PostCreate()
                {
                    Title = "This is a test post",
                    Content = "some content",
                    Excerpt = "unit testing test"
                });
            Assert.IsNotNull(result);

            var result2 = await client.UpdatePost(
                authToken,
                new PostUpdate()
                {
                    Title = "This is a test post 2",
                    Content = "some content 2",
                    Excerpt = "unit testing test 2"
                }, result.Id);
            Assert.IsNotNull(result2);

            var result3 = await client.DeletePost(authToken, result.Id);
            Assert.IsNotNull(result3);
        }


        [TestMethod]
        public async Task CategoryCreateTest()
        {
            var authToken = new AuthenticationTokens()
            {
                ApplicationPassword = "Secret",
                UserName = "wbsimms"
            };
            var result = await client.CreateCategory(
                authToken,
                new CategoryCreate()
                {
                    Description = "Test Category",
                    Name = "TestCategory",
                    Slug = "test-category"
                });
            Assert.IsNotNull(result);

            var result2 = await client.UpdateCategory(
                authToken,
                new CategoryUpdate()
                {
                    Description = "Test Category 2"
                }, result.Id);
            Assert.IsNotNull(result2);

        }

    }
}
