using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace apiGestionCegep.Controllers
{
    [ApiController]
    public class EnseignantsController : Controller
    {
        [Route("Enseignant/ObtenirListeEnseignant")]
        [HttpGet]
        public List<EnseignantDTO> ObtenirListeEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            List<EnseignantDTO> liste;
            try
            {
                liste = CegepControleur.Instance.ObtenirListeEnseignant(nomCegep, nomDepartement);
            }
            catch (Exception)
            {
                liste = new List<EnseignantDTO>();
            }
            return liste;
        }

        [Route("Enseignant/ObtenirEnseignant")]
        [HttpGet]
        public EnseignantDTO ObtenirEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] int noEnseignant)
        {
            EnseignantDTO enseignantDTO;
            try
            {
                enseignantDTO = CegepControleur.Instance.ObtenirEnseignant(nomCegep, nomDepartement, noEnseignant);
            }
            catch (Exception)
            {
                enseignantDTO = null;
            }
            return enseignantDTO;
        }

        [Route("Enseignant/AjouterEnseignant")]
        [HttpPost]
        public void AjouterEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] EnseignantDTO enseignantDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterEnseignant(nomCegep, nomDepartement, enseignantDTO);
            }
            catch (Exception)
            {

            }
        }

        [Route("Enseignant/ModifierEnseignant")]
        [HttpPost]
        public void ModifierEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] EnseignantDTO enseignantDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierEnseignant(nomCegep, nomDepartement, enseignantDTO);
            }
            catch (Exception)
            {

            }
        }

        [Route("Enseignant/SupprimerEnseignant")]
        [HttpPost]
        public void SupprimerEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] int noEnseignant)
        {
            try
            {
                CegepControleur.Instance.SupprimerEnseignant(nomCegep, nomDepartement, noEnseignant);
            }
            catch (Exception)
            {

            }
        }

        [Route("Enseignant/ViderListeEnseignant")]
        [HttpPost]
        public void ViderListeEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                CegepControleur.Instance.ViderListeEnseignant(nomCegep, nomDepartement);
            }
            catch (Exception)
            {

            }
        }
    }
}
