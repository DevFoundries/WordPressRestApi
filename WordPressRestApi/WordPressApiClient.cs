using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using WordPressPCL.Models;
using WordPressRestApi.Models;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi
{
    public class WordPressApiClient
    {

        public string Url { get; private set; }
        public RestClient Client => new RestClient(new Uri(this.Url));


        public WordPressApiClient(string url)
        {
            this.Url = url;
        }

        public async Task<Post> GetPost(PostQuery query, int postId)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "posts/"+postId,
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Post>(response.Content);
        }

        public async Task<List<Post>> GetPosts(PostsQuery query)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "posts",
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<List<Post>>(response.Content);
        }

        public async Task<List<Category>> GetCategories(CategoriesQuery query)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "categories",
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<List<Category>>(response.Content);
        }

        public async Task<List<Tag>> GetTags(TagsQuery query)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "tags",
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<List<Tag>>(response.Content);
        }

        public async Task<List<Page>> GetPages(PagesQuery query)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "pages",
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<List<Page>>(response.Content);
        }

        public async Task<Page> GetPage(PageQuery query, int pageId)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "pages/" + pageId,
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Page>(response.Content);
        }
    }
}
