using RelationTables_MVC.Models.Repository.IRepository;

namespace RelationTables_MVC.Models.Repository
{
    public class UserTypeRepository : IServiceUserType<Usertype>
    {
        private readonly ApplicationDbContext _db;
        public UserTypeRepository(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IEnumerable<Usertype> List()
        {
            return _db.UserTypes.ToList();
        }
    }
}
