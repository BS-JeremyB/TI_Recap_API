using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Recap_API.Domain.Entities
{
    public class Utilisateur
    {

        public int Id { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
