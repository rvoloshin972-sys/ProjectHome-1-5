using System.Text.RegularExpressions;

namespace ProjectHome5
{
    internal class PasswordValidator : IValidator
    {
        private string password;
        public PasswordValidator(string password)
        {
            this.password = password;
        }
        public bool Validate()
        {
            return Regex.IsMatch(password,@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        }
    }
}
