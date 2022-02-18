using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace apiGestionCegep.Controllers
{
    [ApiController]
    public class CoursController : Controller
    {
        [Route("Cours/ObtenirListeCours")]
        [HttpGet]
        public List<CoursDTO> ObtenirListeCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            List<CoursDTO> liste;
            try
            {
                liste = CegepControleur.Instance.ObtenirListeCours(nomCegep, nomDepartement);
            }
            catch (Exception)
            {
                liste = new List<CoursDTO>();
            }
            return liste;
        }

        [Route("Cours/ObtenirCours")]
        [HttpGet]
        public CoursDTO ObtenirCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] string nomCours)
        {
            CoursDTO coursDTO;
            try
            {
                coursDTO = CegepControleur.Instance.ObtenirCours(nomCegep, nomDepartement, nomCours);
            }
            catch (Exception)
            {
                coursDTO = null;
            }
            return coursDTO;
        }

        [Route("Cours/AjouterCours")]
        [HttpPost]
        public void AjouterCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] CoursDTO coursDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterCours(nomCegep, nomDepartement, coursDTO);
            }
            catch (Exception)
            {

            }
        }

        [Route("Cours/ModifierCours")]
        [HttpPost]
        public void ModifierCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] CoursDTO coursDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierCours(nomCegep, nomDepartement, coursDTO);
            }
            catch (Exception)
            {

            }
        }

        [Route("Cours/SupprimerCours")]
        [HttpPost]
        public void SupprimerCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] string nomCours)
        {
            try
            {
                CegepControleur.Instance.SupprimerCours(nomCegep, nomDepartement, nomCours);
            }
            catch (Exception)
            {

            }
        }

        [Route("Cours/ViderListeCours")]
        [HttpPost]
        public void ViderListeCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                CegepControleur.Instance.ViderListeCours(nomCegep, nomDepartement);
            }
            catch (Exception)
            {

            }
        }
    }
}

