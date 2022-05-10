using System.Text.RegularExpressions;

namespace Login
{
    public class User
    {
        public User(string username, string mail)
        {
            this.username = username;
            this.mail = mail;
        }

        public string username { get; set; }
        public string mail { get; set; }

        public bool verifMail()
        {
            return Regex.IsMatch(this.mail, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }
    }
}
