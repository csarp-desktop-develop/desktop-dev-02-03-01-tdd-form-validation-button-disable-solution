using Kreta.Desktop.Validation.ValidationRules;
using System.Globalization;
using System.Windows.Controls;

namespace Kreta.Desktop.Validation
{
    public class LastNameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is not null && value is string)
            {
                string nameToValidate = (string)value;
                NameValidationRules nvr = new NameValidationRules(nameToValidate);
                if (nvr.IsNameShort)
                    return new ValidationResult(false, "A vezetéknév túl rövid!");
                if (!nvr.IsOnlyLetterOrSpaceOrDash)
                    return new ValidationResult(false, "A vezetéknév betűből, szóközből és kötőjelből állhat!");
                if (!nvr.IsFirstLetterUppercase)
                    return new ValidationResult(false, "A vezetéknév első betűje nagybetű kell legyen!");

            }
            return new ValidationResult(true, "");
        }
    }
}
