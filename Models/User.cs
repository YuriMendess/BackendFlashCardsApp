namespace BackendFlashCardsApp.Models
{
    public class User
    {
        public Guid? Id { get; }
        public string Name { get; }
        public string UserName { get; }
        public string Email { get; }
        public string Password { get; }
        public DateTime Created_at { get; }

        public User(
            Guid id,
            string name,
            string userName,
            string email,
            string password,
            DateTime created_at)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Email = email;
            Password = password;
        }
        
    }
}