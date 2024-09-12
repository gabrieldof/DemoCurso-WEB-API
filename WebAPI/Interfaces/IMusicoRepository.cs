using WebAPI.Entities;

namespace WebAPI.Interfaces
{
    public interface IMusicoRepository
    {

        List<Musico> Get();

        public Musico GetById(int id);
    }
}
