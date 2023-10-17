namespace RelationTables_MVC.Models.Repository.IRepository
{
    public interface IServiceUser<Tentity>
    {
        public IEnumerable<Tentity> List();
        public void Add(Tentity entity);
        public void Update(Tentity entity);
        public void Delete(Tentity entity);
        public Tentity Find(int id);
    }
}
