namespace BackendFlashCardsApp.Models
{
    public class User
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created_at { get; set; }

        public User(
            Guid id,
            string name,
            string username,
            string email,
            string password,
            DateTime created_at)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Password = password;
        }
        
    }
}