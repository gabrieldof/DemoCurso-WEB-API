using WebAPI.Data;
using WebAPI.Entities;
using WebAPI.Interfaces;

namespace WebAPI.Repositositories
{
    public class MusicoRepository : IMusicoRepository
    {
        private readonly ApplicationContext _context;

        public MusicoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Musico> Get()

        {
            return _context.Musicos.Take(1).ToList();
        }
        public Musico GetById(int id) {  return _context.Musicos.FirstOrDefault(x => x.Id == id); }
    }
}
