using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace apiGestionCegep.Controllers
{
    [ApiController]
    public class CegepController : Controller
    {
        [Route("Cegep/ObtenirListeCegep")]
        [HttpGet]
        public List<CegepDTO> ObtenirListeCegep()
        {
            List<CegepDTO> liste;
            try
            {
                liste = CegepControleur.Instance.ObtenirListeCegep();
            }
            catch(Exception)
            {
                liste = new List<CegepDTO>();
            }
            return liste;
        }

        [Route("Cegep/ObtenirCegep")]
        [HttpGet]
        public CegepDTO ObtenirCegep([FromQuery] string nomCegep)
        {
            CegepDTO cegepDTO; 
            try
            {
                cegepDTO = CegepControleur.Instance.ObtenirCegep(nomCegep);
            }
            catch (Exception)
            {
                cegepDTO = null;
            }
            return cegepDTO;
        }

        [Route("Cegep/AjouterCegep")]
        [HttpPost]
        public void AjouterCegep([FromBody] CegepDTO cegepDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterCegep(cegepDTO);
            }
            catch (Exception)
            {
                
            }
        }

        [Route("Cegep/ModifierCegep")]
        [HttpPost]
        public void ModifierCegep([FromBody] CegepDTO cegepDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierCegep(cegepDTO);
            }
            catch (Exception)
            {

            }
        }

        [Route("Cegep/SupprimerCegep")]
        [HttpPost]
        public void SupprimerCegep([FromQuery] string nomCegep)
        {
            try
            {
                CegepControleur.Instance.SupprimerCegep(nomCegep);
            }
            catch (Exception)
            {

            }
        }

        [Route("Cegep/ViderListeCegep")]
        [HttpPost]
        public void ViderListeCegep()
        {
            try
            {
                CegepControleur.Instance.ViderListeCegep();
            }
            catch (Exception)
            {

            }
        }
    }
}
