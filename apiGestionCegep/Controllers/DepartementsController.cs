using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace apiGestionCegep.Controllers
{
    [ApiController]
    public class DepartementsController : Controller
    {
        [Route("Departement/ObtenirListeDepartement")]
        [HttpGet]
        public List<DepartementDTO> ObtenirListeDepartement([FromQuery] string nomCegep)
        {
            List<DepartementDTO> liste;
            try
            {
                liste = CegepControleur.Instance.ObtenirListeDepartement(nomCegep);
            }
            catch (Exception)
            {
                liste = new List<DepartementDTO>();
            }
            return liste;
        }

        [Route("Departement/ObtenirDepartement")]
        [HttpGet]
        public DepartementDTO ObtenirDepartement([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            DepartementDTO departementDTO;
            try
            {
                departementDTO = CegepControleur.Instance.ObtenirDepartement(nomCegep, nomDepartement);
            }
            catch (Exception)
            {
                departementDTO = null;
            }
            return departementDTO;
        }

        [Route("Departement/AjouterDepartement")]
        [HttpPost]
        public void AjouterDepartement([FromQuery] string nomCegep, [FromBody] DepartementDTO departementDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterDepartement(nomCegep, departementDTO);
            }
            catch (Exception)
            {

            }
        }

        [Route("Departement/ModifierDepartement")]
        [HttpPost]
        public void ModifierDepartement([FromQuery] string nomCegep, [FromBody] DepartementDTO departementDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierDepartement(nomCegep, departementDTO);
            }
            catch (Exception)
            {

            }
        }

        [Route("Departement/SupprimerDepartement")]
        [HttpPost]
        public void SupprimerDepartement([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                CegepControleur.Instance.SupprimerDepartement(nomCegep, nomDepartement);
            }
            catch (Exception)
            {

            }
        }

        [Route("Departement/ViderListeDepartement")]
        [HttpPost]
        public void ViderListeDepartement([FromQuery] string nomCegep)
        {
            try
            {
                CegepControleur.Instance.ViderListeDepartement(nomCegep);
            }
            catch (Exception)
            {

            }
        }
    }
}
