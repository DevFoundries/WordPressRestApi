using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using WordPressPCL.Models;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi
{
    public class WordPressApiClient
    {

        public string Url { get; private set; }
        


        public WordPressApiClient(string url)
        {
            this.Url = url;
        }

        public async Task<List<Post>> GetPosts(PostQuery query)
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

        public RestClient Client => new RestClient(new Uri(this.Url));
    }

}
