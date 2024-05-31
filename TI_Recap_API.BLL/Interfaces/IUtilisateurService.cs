﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_Recap_API.Domain.Entities;

namespace TI_Recap_API.BLL.Interfaces
{
    public interface IUtilisateurService
    {
        public IEnumerable<Utilisateur> GetAll();
        public Utilisateur? GetById(int id);
        public Utilisateur? Create(Utilisateur utilisateur);
        public Utilisateur? Update(Utilisateur utilisateur);
        public bool Delete(int id);
    }
}