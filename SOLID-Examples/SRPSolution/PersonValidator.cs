using System;

namespace SRPSolution
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            bool isFirstNameValid = string.IsNullOrWhiteSpace(person.FirstName);
            bool isLastNameValid = string.IsNullOrWhiteSpace(person.LastName);

            if (isFirstNameValid == false)
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (isLastNameValid == false)
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
