using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using WordPressPCL.Models;

namespace WordPressRestApi
{
    public class WordPressApiClient
    {

        public string Url { get; private set; }
        


        public WordPressApiClient(string url)
        {
            this.Url = url;
        }

        public async Task<List<Post>> GetPosts(int perPage = 10)
        {
            var response = await Client.Execute(new RestRequest()
            {
                Method = Method.GET,
                Resource = "posts",
            }.AddQueryParameter("per_page",perPage));

            return JsonConvert.DeserializeObject<List<Post>>(response.Content);
        }

        public RestClient Client => new RestClient(new Uri(this.Url));
    }

}
