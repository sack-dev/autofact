using System.Text.RegularExpressions;

namespace Login
{
    public class User
    {
        public User(string username, string mail)
        {
            this.Username = username;
            this.Mail = mail;
        }

        public string Username { get; set; }
        public string Mail { get; set; }

        public bool VerifMail()
        {
            return Regex.IsMatch(this.Mail, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }
    }
}
