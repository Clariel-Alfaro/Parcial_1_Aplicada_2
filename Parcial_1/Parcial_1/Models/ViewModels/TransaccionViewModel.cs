using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial_1.Models.ViewModels
{
    public class TransaccionViewModel
    {
        
        public int Id { get; set; }

        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Es requerido ingresar un monto")]
        public int Monto { get; set; }


    }
}