using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace TWValidacao.Attributes
{
    public class AgeBetweenAttribute : ValidationAttribute
    {
        private int Min { get; }
        private int Max { get; }

        public AgeBetweenAttribute(int max, int min = 0)
        {
            Max = max; Min = min;
        }

        public override bool IsValid(object? value)
        {
            if (value is null)
                return true;

            DateTime birthDate = Convert.ToDateTime(value);
            var age = calculateAge(birthDate);

            return age >= Min && age <= Max;
        }

        private int calculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if(birthDate.Date > today.AddYears(-age)) 
            {
                age--;
            }

            return age;
        }
    }
}
