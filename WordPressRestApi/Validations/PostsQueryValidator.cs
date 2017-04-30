using WordPressRestApi.QueryModel;

namespace WordPressRestApi.Validations
{
    public class PostsQueryValidator
    {
        public ValidationResult Validate(PostsQuery model)
        {
            ValidationResult retval = new ValidationResult();
            retval.Responses.Add(PerPageValidation.Validate(model.PerPage));
            return retval;
        }
    }
}