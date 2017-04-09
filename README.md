# WordPressRestApi

WordPressRestApi : A PCL library to access Wordpress content through the v2 API

## Supports

| .NET Version | Supported |
| ------------ | --------- |
| .NET 4.5     | <font style='color:green'>Yes</font> |
| ASP.NET Core 1 | <font style='color:green'>Yes</font> |
| Windows 8 | <font style='color:green'>Yes</font> |
| Windows Universal 10 | <font style='color:green'>Yes</font> |
| Xamarin.Android | <font style='color:green'>Yes</font> |
| Xamarin.iOS | <font style='color:green'>Yes</font> |
| Xamarin.iOS (Classic) | <font style='color:green'>Yes</font> |
| Xamarin.Mac | <font style='color:green'>Yes</font> |


## Roadmap

I'm prioritizing retreiving data for now. Add, then modify, will come later.

| Feature | Status | Read | Update | Add |
| ------- | ------ | ----- | ---- | ---- | --- | 
| Posts | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Categories | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Tags | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Pages | <font style='color:red'>Not Started</font> | <font style='color:green'>Done</font> | | |
| Comments | <font style='color:red'>Not Started</font> | | | |
| Taxonomies | <font style='color:red'>Not Started</font> | | | |
| Media | <font style='color:red'>Not Started</font> |  | | |
| Users | <font style='color:red'>Not Started</font> | <font style='color:orange'>In Progress</font> | | |
| Post Types | <font style='color:red'>Not Started</font> |  | | |
| Post Statuses | <font style='color:red'>Not Started</font> | | | |
| Settings | <font style='color:red'>Not Started</font> | | | |
| Posts | <font style='color:red'>Not Started</font> | <font style='color:orange'>In Progress</font> | | |


## Usage

### Creating the client
```CSharp
using WordPressRestApi;
...
WordPressApiClient client = new WordPressApiClient("https://wbsimms.com/wp-json/wp/v2");
```

### Fetching posts

#### Fetch the last 20 posts
```CSharp
List<Post> result = await client.GetPosts(new PostQuery(){PerPage = 20});
```

#### Fetch posts with authorId = 1 and catetory = programming
```CSharp
List<Post> result = await client.GetPosts(new PostQuery(){Categories = 531, Author = 1});
```

#### Fetch posts with authorId = 1 and tags = 152 and 131
```CSharp
List<Post> result = await client.GetPosts(new PostQuery(){Tags = new List<int>(){152,131}, Author = 1});
```

#### Fetch the first 20 non-empty categories
```CSharp
List<Category> result = await client.GetCategories(new CategoriesQuery(){HideEmpty = true, PerPage = 20});
```

#### Fetch the first 20 non-empty tags
```CSharp
List<Tag> result = await client.GetTags(new TagsQuery() { PerPage = 20, HideEmpty = true });
```

## License
