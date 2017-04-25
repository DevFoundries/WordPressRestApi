using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using WordPressRestApi.CreateModel;
using WordPressRestApi.Models;
using WordPressRestApi.QueryModel;
using WordPressRestApi.UpdateModel;

namespace WordPressRestApi
{
    public interface IWordPressApiClient
    {
        Task<Post> GetPost(PostQuery query, int postId);
        Task<List<Post>> GetPosts(PostsQuery query);
        Task<List<Category>> GetCategories(CategoriesQuery query);
        Task<List<Tag>> GetTags(TagsQuery query);
        Task<List<Page>> GetPages(PagesQuery query);
        Task<Page> GetPage(PageQuery query, int pageId);
        Task<List<User>> GetUsers(UsersQuery query);
        Task<User> GetUser(UserQuery query, int userId);
        Task<List<Media>> GetMedias(MediasQuery query);
        Task<Media> GetMedia(MediaQuery query, int mediaId);
        Task<Settings> GetSettings(AuthenticationTokens tokens);
        Task<Settings> UpdateSettings(AuthenticationTokens tokens, Settings settings);
        Task<Post> CreatePost(AuthenticationTokens tokens, PostCreate post);
        Task<Post> UpdatePost(AuthenticationTokens tokens, PostUpdate post, int postId);
        Task<Post> DeletePost(AuthenticationTokens tokens, int postId);
        Task<Category> CreateCategory(AuthenticationTokens tokens, CategoryCreate category);
        Task<Category> UpdateCategory(AuthenticationTokens tokens, CategoryUpdate category, int categoryId);

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Not implemented in the API
        /// </remarks>
        Task<Category> DeleteCategory(AuthenticationTokens tokens, int categoryId);

        Task<Tag> CreateTag(AuthenticationTokens tokens, TagCreate tag);
        Task<Tag> UpdateCategory(AuthenticationTokens tokens, TagUpdate category, int tagId);

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="tagId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Not implemented in the API
        /// </remarks>
        Task<Category> DeleteTag(AuthenticationTokens tokens, int tagId);

        Task<Page> CreatePage(AuthenticationTokens tokens, PageCreate page);
        Task<Page> UpdatePage(AuthenticationTokens tokens, PageUpdate category, int pageId);
        Task<Page> DeletePage(AuthenticationTokens tokens, int pageId);
        Task<Media> CreateMedia(AuthenticationTokens tokens, MediaCreate media);
        Task<Media> UpdateMedia(AuthenticationTokens tokens, MediaUpdate category, int mediaId);
        Task<Media> DeleteMedia(AuthenticationTokens tokens, int mediaId);
    }

    public class WordPressApiClient : IWordPressApiClient
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

        public async Task<List<User>> GetUsers(UsersQuery query)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "users",
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<List<User>>(response.Content);
        }

        public async Task<User> GetUser(UserQuery query, int userId)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "users/"+userId,
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<User>(response.Content);
        }

        public async Task<List<Media>> GetMedias(MediasQuery query)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "media",
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Media>>(content);
        }

        public async Task<Media> GetMedia(MediaQuery query, int mediaId)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "media/" + mediaId,
            };
            var queryParameters = query.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);

            return JsonConvert.DeserializeObject<Media>(response.Content);
        }
        public async Task<Settings> GetSettings(AuthenticationTokens tokens)
        {
            var request = new RestRequest()
            {
                Method = Method.GET,
                Resource = "settings",
            }.AddHeader("Authorization","Basic "+tokens.CreateHeaderToken());
            //var queryParameters = query.GenerateQueryDictionary();
            //foreach (var pair in queryParameters)
            //{
            //    request.AddQueryParameter(pair.Key, pair.Value);
            //}

            var response = await Client.Execute(request);

            return JsonConvert.DeserializeObject<Settings>(response.Content);
        }

        public async Task<Settings> UpdateSettings(AuthenticationTokens tokens, Settings settings)
        {
            var body = JsonConvert.SerializeObject(settings, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore

            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "settings",
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken()).AddBody(body);

 
            var response = await Client.Execute(request);

            return JsonConvert.DeserializeObject<Settings>(response.Content);
        }

        public async Task<Post> CreatePost(AuthenticationTokens tokens, PostCreate post)
        {
            var body = JsonConvert.SerializeObject(post, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore

            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "posts",
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = post.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }

            var response = await Client.Execute(request);

            return JsonConvert.DeserializeObject<Post>(response.Content);
        }

        public async Task<Post> UpdatePost(AuthenticationTokens tokens, PostUpdate post, int postId)
        {
            var body = JsonConvert.SerializeObject(post, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "posts/"+postId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = post.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }

            var response = await Client.Execute(request);

            return JsonConvert.DeserializeObject<Post>(response.Content);
        }


        public async Task<Post> DeletePost(AuthenticationTokens tokens, int postId)
        {
            var request = new RestRequest()
            {
                Method = Method.DELETE,
                Resource = "posts/" + postId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var response = await Client.Execute(request);

            return JsonConvert.DeserializeObject<Post>(response.Content);
        }


        public async Task<Category> CreateCategory(AuthenticationTokens tokens, CategoryCreate category)
        {
            var body = JsonConvert.SerializeObject(category, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "categories",
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = category.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Category>(response.Content);
        }

        public async Task<Category> UpdateCategory(AuthenticationTokens tokens, CategoryUpdate category, int categoryId)
        {
            var body = JsonConvert.SerializeObject(category, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "categories/"+categoryId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = category.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Category>(response.Content);
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Not implemented in the API
        /// </remarks>
        public async Task<Category> DeleteCategory(AuthenticationTokens tokens, int categoryId)
        {
            throw new NotImplementedException();
            //var request = new RestRequest()
            //{
            //    Method = Method.DELETE,
            //    Resource = "categories/" + categoryId,
            //}.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            //request.AddBody("force", true);

            //var response = await Client.Execute(request);
            //return JsonConvert.DeserializeObject<Category>(response.Content);
        }

        public async Task<Tag> CreateTag(AuthenticationTokens tokens, TagCreate tag)
        {
            var body = JsonConvert.SerializeObject(tag, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "tags",
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = tag.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Tag>(response.Content);
        }

        public async Task<Tag> UpdateCategory(AuthenticationTokens tokens, TagUpdate category, int tagId)
        {
            var body = JsonConvert.SerializeObject(category, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "tags/" + tagId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = category.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Tag>(response.Content);
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="tagId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Not implemented in the API
        /// </remarks>
        public async Task<Category> DeleteTag(AuthenticationTokens tokens, int tagId)
        {
            throw new NotImplementedException();
            //var request = new RestRequest()
            //{
            //    Method = Method.DELETE,
            //    Resource = "categories/" + categoryId,
            //}.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            //request.AddBody("force", true);

            //var response = await Client.Execute(request);
            //return JsonConvert.DeserializeObject<Category>(response.Content);
        }

        public async Task<Page> CreatePage(AuthenticationTokens tokens, PageCreate page)
        {
            var body = JsonConvert.SerializeObject(page, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "pages",
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = page.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Page>(response.Content);
        }

        public async Task<Page> UpdatePage(AuthenticationTokens tokens, PageUpdate category, int pageId)
        {
            var body = JsonConvert.SerializeObject(category, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "pages/" + pageId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = category.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Page>(response.Content);
        }

        public async Task<Page> DeletePage(AuthenticationTokens tokens, int pageId)
        {
            var request = new RestRequest()
            {
                Method = Method.DELETE,
                Resource = "pages/" + pageId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Page>(response.Content);
        }


        public async Task<Media> CreateMedia(AuthenticationTokens tokens, MediaCreate media)
        {
            var body = JsonConvert.SerializeObject(media, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "media",
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = media.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Media>(response.Content);
        }

        public async Task<Media> UpdateMedia(AuthenticationTokens tokens, MediaUpdate category, int mediaId)
        {
            var body = JsonConvert.SerializeObject(category, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            });

            var request = new RestRequest()
            {
                Method = Method.POST,
                Resource = "media/" + mediaId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var queryParameters = category.GenerateQueryDictionary();
            foreach (var pair in queryParameters)
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Media>(response.Content);
        }

        public async Task<Media> DeleteMedia(AuthenticationTokens tokens, int mediaId)
        {
            var request = new RestRequest()
            {
                Method = Method.DELETE,
                Resource = "media/" + mediaId,
            }.AddHeader("Authorization", "Basic " + tokens.CreateHeaderToken());

            var response = await Client.Execute(request);
            return JsonConvert.DeserializeObject<Media>(response.Content);
        }


    }
}
