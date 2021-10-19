using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlmacenPersona.Models.ViewModels
{
    public class PersonaViewModel
    {

        public int IdPersona { get; set; }

        [Display(Name = "NombrePersona")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public String NombrePersona { get; set; }

        [Display(Name = "EdadPersona")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        [Range(18,100,ErrorMessage ="La edad minima aceptada es 18 años")]
        public int EdadPersona { get; set; }

        [Display(Name = "DescripcionPersona")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]        
        public String DescripcionPersona { get; set; }

    }
}