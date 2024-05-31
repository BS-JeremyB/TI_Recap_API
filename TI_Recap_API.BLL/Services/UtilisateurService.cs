using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_Recap_API.BLL.Interfaces;
using TI_Recap_API.DAL.Interfaces;
using TI_Recap_API.Domain.Entities;

namespace TI_Recap_API.BLL.Services
{
    public class UtilisateurService : IUtilisateurService
    {

        private readonly IUtilisateurRepository _repository;

        public UtilisateurService(IUtilisateurRepository repository)
        {
            _repository = repository;
        }

        public Utilisateur? Create(Utilisateur utilisateur)
        {
            return _repository.Create(utilisateur);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Utilisateur> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utilisateur? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Utilisateur? Update(Utilisateur utilisateur)
        {
            throw new NotImplementedException();
        }
    }
}
