using System.Text.RegularExpressions;

namespace Lab29_Console_App
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public bool ValidatePassword()
        {
            
            if (Password.Length < 8 || !Regex.IsMatch(Password, "[a-z]") || !Regex.IsMatch(Password, "[A-Z]"))
                return false;
            return true;
        }
    }
}
