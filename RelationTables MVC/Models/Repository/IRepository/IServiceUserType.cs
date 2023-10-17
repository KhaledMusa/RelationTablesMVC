namespace RelationTables_MVC.Models.Repository.IRepository
{
    public interface IServiceUserType<Tentity>
    {
        public IEnumerable<Tentity> List();
    }
}
