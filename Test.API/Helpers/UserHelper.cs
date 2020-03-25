using System;

namespace Test.API.Helpers
{
    public static class UserHelper
    {
        public static int GetAge(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year -1;
            if(dateOfBirth >= DateTime.Today)
                age++;
            return age;
        }
    }
}