using Lab29_Console_App;

public class UserDatabase
{
    private static Dictionary<string, User> users = new Dictionary<string, User>();

    static UserDatabase()
    {
        // Örnek kullanıcılar ekleyelim
        users.Add("admin", new User("admin", "Admin123", Role.Admin));
        users.Add("moderator", new User("moderator", "Moderator123", Role.Moderator));
        users.Add("user1", new User("user1", "userpass", Role.User));
    }
    public static User RegisterUser(string username, string password, Role role)
    {
        if (users.ContainsKey(username))
        {
            Console.WriteLine("Istifadeci adı  movcuddur.");
            return null;
        }

        var newUser = new User(username, password, role);
        users.Add(username, newUser);
        Console.WriteLine("Qeydiyyat ugurlu oldu.");
        return newUser;
    }

    public static User LoginUser(string username, string password)
    {
        if (users.ContainsKey(username) && users[username].Password == password)
        {
            return users[username];
        }
        return null;
    }
}
