using TI_Recap_API.API.Models.DTOs;
using TI_Recap_API.Domain.Entities;

namespace TI_Recap_API.API.Mappers
{
    public static class UtilisateurMappers
    {
        public static UtilisateurDetailsDTO ToDetailsDTO(this Utilisateur utilisateur)
        {
            return new UtilisateurDetailsDTO
            {
                Email = utilisateur.Email,
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom,
                Id = utilisateur.Id,
            };
        }

        public static Utilisateur ToEntity(this UtilisateurCreateDTO dto)
        {
            return new Utilisateur
            {
                Email = dto.Email,
                Nom = dto.Nom,
                Prenom = dto.Prenom,
                Password = dto.Password,
            };
        }
    }
}
