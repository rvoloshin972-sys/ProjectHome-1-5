using System;
using System.Text;

namespace ProjectHome5
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IValidator password1 = new PasswordValidator("Strong123");
            IValidator password2 = new PasswordValidator("abc123");
            IValidator email1 = new EmailValidator("user@gmail.com");
            IValidator email2 = new EmailValidator("usergmail.com");

            Console.WriteLine(" Перевірка пароля ");
            Console.WriteLine("Strong123: " + (password1.Validate() ? "Коректний" : "Некоректний"));
            Console.WriteLine("abc123: " + (password2.Validate() ? "Коректний" : "Некоректний"));

            Console.WriteLine();
            Console.WriteLine(" Перевірка електронної пошти ");
            Console.WriteLine("user@gmail.com: " + (email1.Validate() ? "Коректна" : "Некоректна"));
            Console.WriteLine("usergmail.com: " + (email2.Validate() ? "Коректна" : "Некоректна"));
        }
    }
}
