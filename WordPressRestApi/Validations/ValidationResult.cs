using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordPressRestApi.Validations
{
    public class ValidationResult
    {
        public List<ValidationResponse> Responses { get; set; } = new List<ValidationResponse>();
        public bool HasError { get { return Responses.Any(); } }


    }

    public class ValidationResultOutputFormatter
    {
        public static string FormatResults(ValidationResult result)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var validationResponse in result.Responses)
            {
                sb.AppendLine("FieldName: " + validationResponse.FieldName + " = " + validationResponse.Message);
            }
            return sb.ToString();
        }


    }
}