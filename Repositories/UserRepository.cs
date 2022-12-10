using BackendFlashCardsApp.Models;

namespace BackendFlashCardsApp.Repository
{
    public class UserRepository
    {
        private const string CacheKey = "User";
        public UserRepository()
        {
            var ctx = HttpContext.Current;

            if(ctx != null)
            {
                if(ctx.Cache[CacheKey] == null)
                {
                    var users = new User[]
                    {
                        new User
                        {
                            Id = new Guid(),
                            Name = "Yuri",
                            Username = "YuriMendess",
                            Email = "yuri@gmail.com",
                            Password = "",
                            Created_at = DateTime.UtcNow
                        },

                        new User
                        {
                            Id = new Guid(),
                            Name = "Yuri",
                            Username = "YuriMendess",
                            Email = "yuri666@gmail.com",
                            Password = "",
                            Created_at = DateTime.UtcNow
                        }
                    };

                    ctx.Cache[CacheKey] = users;
                }
            }
        }

        public bool SaveContact(User user)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var currentData = ((User[])ctx.Cache[CacheKey]).ToList();
                    currentData.Add(user);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }
    }
}