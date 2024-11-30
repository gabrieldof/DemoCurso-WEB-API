using WebAPI.Entities;

namespace WebAPI.Interfaces
{
    public interface IMusicoService
    {
        public List<Musico> Get();
        public Musico GetById(int id);
        public Musico Add(Musico musico);
        public int Update(Musico musico);
        public int Delete (int id);

    }
}
