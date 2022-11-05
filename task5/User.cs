public class User
{
    public int userId { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public User(int user, string username, string password)
    {
        userId = user;
        this.username = username;
        this.password = password;
    }
      public void GetUserInfo()
    {
        System.Console.WriteLine($"{userId}, {username}, {password}");
    }
}