﻿using WebAPI.Entities;

namespace WebAPI.Interfaces
{
    public interface IMusicoService
    {
        public List<Musico> Get();
        public Musico GetById(int id);
    }
}
