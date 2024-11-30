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
            return _context.Musicos.ToList();
        }

        public Musico GetById(int id) 
        {  
          
            return _context.Musicos.FirstOrDefault(x => x.Id == id); 
        }

        public Musico Add(Musico musico)
        {

            _context.Musicos.Add(musico);
            _context.SaveChanges();
            return musico;
        }
        public int Update(Musico musico)
        {
            _context.Musicos.Update(musico);
            return _context.SaveChanges();
        }
        public int Delete(Musico musico)
        {
            
            _context.Musicos.Remove(musico);
            return _context.SaveChanges();
        }

    }
}
