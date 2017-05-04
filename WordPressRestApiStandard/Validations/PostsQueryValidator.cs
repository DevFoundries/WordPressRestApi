using WordPressRestApiStandard.QueryModel;

namespace WordPressRestApiStandard.Validations
{
    public class PostsQueryValidator
    {
        public ValidationResult Validate(PostsQuery model)
        {
            ValidationResult retval = new ValidationResult();
            var val = PerPageValidation.Validate(model.PerPage);
            if (val != null) retval.Responses.Add(val);
            return retval;
        }
    }

    public class CategoriesQueryValidator
    {
        public ValidationResult Validate(CategoriesQuery model)
        {
            ValidationResult retval = new ValidationResult();
            var val = PerPageValidation.Validate(model.PerPage);
            if (val != null) retval.Responses.Add(val);
            return retval;
        }
    }

}