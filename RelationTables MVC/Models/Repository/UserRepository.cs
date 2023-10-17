using Microsoft.EntityFrameworkCore;
using RelationTables_MVC.Models.Repository.IRepository;

namespace RelationTables_MVC.Models.Repository
{
    public class UserRepository : IServiceUser<User>
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Add(User entity)
        {
           _db.Users.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(User entity)
        {
           _db?.Users.Remove(entity);
            _db?.SaveChanges();
        }

        public User Find(int id)
        {
           return _db.Users.Find(id);
        }

        public IEnumerable<User> List()
        {
           return _db.Users.Include("UserType").ToList();
        }

        public void Update(User entity)
        {
           _db.Users.Update(entity);
            _db.SaveChanges();
        }
    }
}
