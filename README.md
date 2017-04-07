# WordPressRestApi

WordPressRestApi : A PCL library to access Wordpress content through the v2 API

## Supports

| .NET Version | Supported |
| ------------ | --------- |
| .NET 4.5     | <font color='green'>Yes</font> |
| ASP.NET Core 1 | <font color='green'>Yes</font> |
| Windows 8 | <font color='green'>Yes</font> |
| Windows Universal 10 | <font color='green'>Yes</font> |
| Xamarin.Android | <font color='green'>Yes</font> |
| Xamarin.iOS | <font color='green'>Yes</font> |
| Xamarin.iOS (Classic) | <font color='green'>Yes</font> |
| Xamarin.Mac | <font color='green'>Yes</font> |


## Usage

```CSharp
using WordPressRestApi;
...
WordPressApiClient client = new WordPressApiClient("https://wbsimms.com/wp-json/wp/v2");
List<Post> result = await client.GetPosts(new PostQuery(){PerPage = "20"});
```

## License
