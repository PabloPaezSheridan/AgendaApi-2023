using Data;
using Data.Entities;

namespace Services
{
    public class UserService
    {
        private readonly AgendaContext _context;
        public UserService(AgendaContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? Get(int id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id);
        }

        public void Delete(int id)
        {
            User user = Get(id);
            _context.Users.Remove(user);
        }

        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }

        public int Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public User? GetByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public bool ValidateCredentials(string email, string password)
        {
            User? userForLoggin = GetByEmail(email);
            if (userForLoggin != null)
            {
                if (userForLoggin.Password == password)
                    return true;
            }
            return false;
        }
    }
}
