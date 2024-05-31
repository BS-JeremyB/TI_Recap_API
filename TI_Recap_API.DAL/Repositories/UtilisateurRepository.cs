using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_Recap_API.DAL.Interfaces;
using TI_Recap_API.Domain.Entities;

namespace TI_Recap_API.DAL.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly string _connection = @"server=(localdb)\MSSQLLocaldb;database=DB_Recap_API;integrated security=true";

        public Utilisateur? Create(Utilisateur utilisateur)
        {
            using(SqlConnection connection = new SqlConnection(_connection))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO Utilisateur (Nom, Prenom, Email, Password) OUTPUT INSERTED.Id
                                                        VALUES(@Nom, @Prenom, @Email, @Password)";

                    command.Parameters.AddWithValue("@Nom", utilisateur.Nom);
                    command.Parameters.AddWithValue("@Prenom", utilisateur.Prenom);
                    command.Parameters.AddWithValue("@Email", utilisateur.Email);
                    command.Parameters.AddWithValue("@Password", utilisateur.Password);

                    connection.Open();
                    int id = (int)command.ExecuteScalar();

                    if(id > 0)
                    {
                        utilisateur.Id = id;
                        return utilisateur;
                    }

                    return null;
                }
            }
        }

        public bool Delete(Utilisateur utilisateur)
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
