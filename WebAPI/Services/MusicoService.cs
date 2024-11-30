using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Entities;
using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class MusicoService : IMusicoService
    {

        private static List<Musico> _musicos = new List<Musico>
        {
            new Musico { Id = 1, Nombre = "Gustavo Cerati" },
                                 new Musico { Id = 2, Nombre = "Indio Solari" },
                                 new Musico { Id = 3, Nombre = "Miranda" },
                                 new Musico { Id = 4, Nombre = "Charly García" },
                                 new Musico { Id = 5, Nombre = "Divididos" },
                                 new Musico { Id = 6, Nombre = "Mercedes Sosa" }
        };
        private readonly IMusicoRepository _repository;

        public MusicoService (IMusicoRepository repository)
        {
            _repository = repository;
        }

        public List<Musico> Get()

        {
            return _repository.Get();
        }

        public Musico GetById(int id)

        {
            return _repository.GetById(id);
        }

        public Musico Add(Musico musico)
        {
            return _repository.Add(musico);
        }
        public int Update(Musico musico)
        {
            return _repository.Update(musico);
        }
        public int Delete(int id)
        {
            var musico  = _repository.GetById(id);
            return _repository.Delete(musico);
        }
    }
}
