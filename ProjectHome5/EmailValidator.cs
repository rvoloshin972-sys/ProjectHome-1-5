using System.Text.RegularExpressions;

namespace ProjectHome5
{
    internal class EmailValidator : IValidator
    {
        private string email;
        public EmailValidator(string email)
        {
            this.email = email;
        }
        public bool Validate()
        {
            return Regex.IsMatch(email,@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
