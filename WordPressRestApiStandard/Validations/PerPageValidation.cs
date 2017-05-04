namespace WordPressRestApiStandard.Validations
{
    public class PerPageValidation
    {
        public static ValidationResponse Validate(int value)
        {
            if (value < 1 || value > 100) return new ValidationResponse(){ Message = "PerPage must be between 1 and 100",FieldName = "PerPage"};
            return null;
        }
    }
}
