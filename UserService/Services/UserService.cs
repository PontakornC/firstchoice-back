using UserService.Entity;

namespace UserService.Services
{
    public class UserServices
    {
        private readonly List<User> _users = new();

        public IEnumerable<User> GetAllUsers() => _users;

        public User GetUserById(Guid id) => _users.FirstOrDefault(u => u.Id == id);

        public void AddUser(User user) => _users.Add(user);
    }
}
