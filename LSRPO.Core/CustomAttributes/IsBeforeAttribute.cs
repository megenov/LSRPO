using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.CustomAttributes
{
    public class IsBeforeAttribute : ValidationAttribute
    {
        private readonly string propertyToCompare;

        public IsBeforeAttribute(string propertyToCompare, string errorMessage = "")
        {
            this.propertyToCompare = propertyToCompare;
            this.ErrorMessage = errorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                DateTime dateToCompare = (DateTime)validationContext
                .ObjectType
                .GetProperty(propertyToCompare)
                .GetValue(validationContext.ObjectInstance);

                if ((DateTime)value < dateToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            catch (Exception)
            {}

            return new ValidationResult(ErrorMessage);
        }
    }
}