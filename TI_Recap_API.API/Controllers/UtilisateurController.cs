using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TI_Recap_API.API.Mappers;
using TI_Recap_API.API.Models.DTOs;
using TI_Recap_API.BLL.Interfaces;
using TI_Recap_API.Domain.Entities;

namespace TI_Recap_API.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateurService _Service;

        public UtilisateurController(IUtilisateurService service)
        {
            _Service = service;
        }

        [HttpPost]
        public ActionResult<UtilisateurDetailsDTO> Create([FromBody] UtilisateurCreateDTO utilisateur)
        {

            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            Utilisateur? utilisateurCree = _Service.Create(utilisateur.ToEntity());

            if(utilisateurCree is not null)
            {
                return Ok(utilisateurCree.ToDetailsDTO());
            }

            return BadRequest();

        }
    }
}
