# WordPressRestApi

WordPressRestApi : A PCL library to access Wordpress content through the v2 API

## Donations

This open source project is user supported. Please donate what you can if you find the code useful. Thanks!

<form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="QF5QX6CLW6FJA">
<input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_donate_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">
</form>

## Installation
```
Install-Package WmBarrettSimms.WordPressRestApi 
```

## Supported Platforms

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

| Feature | Status | Read | Add | Update |
| ------- | ------ | ----- | ---- | ---- | 
| Posts | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | <font style='color:green'>Done</font> | |
| Categories | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Tags | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Pages | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Comments | <font style='color:red'>Not Started</font> | | | |
| Taxonomies | <font style='color:red'>Not planned</font> | | | |
| Media | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Users | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |
| Post Types | <font style='color:red'>Not planned</font> | | | |
| Post Statuses | <font style='color:red'>Not planned</font> | | | |
| Settings | <font style='color:green'>Done</font> | <font style='color:green'>Done</font> | N/A | <font style='color:green'>Done</font> |
| Posts | <font style='color:orange'>Partial</font> | <font style='color:green'>Done</font> | | |


## Usage

### Creating the client
```CSharp
using WordPressRestApi;
...
WordPressApiClient client = new WordPressApiClient("https://wbsimms.com/wp-json/wp/v2");
```

### Fetching data

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

### Creating data

All create, update, delete operations require authentictaion. Currently, I'm supporting the [Application Passwords](https://wordpress.org/plugins/application-passwords/) plugin. You must install this pugin to authenticate. One installed, you need to generate an application password for the API user. All data modification calls require an instance of AuthenticationTokens populated with the WP username and application password. See below for examples.  

#### Create a new Posts
```CSharp
var result = await client.CreatePost(
    new AuthenticationTokens() { ApplicationPassword = "Secret", UserName = "wbsimms" },
    new PostCreate(){Title = "This is a test post",Content = "some content", Excerpt = "unit testing test"});
```
## License
