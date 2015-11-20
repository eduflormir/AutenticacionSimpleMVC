using System;
using System.ComponentModel;

namespace AutenticacionSimpleMVC5.Models
{
    public class Usuario
    {
        [DisplayName("Nombre de usuario:")]
        public String Login { get; set; }

        [DisplayName("Contraseña:")]
        public String Password { get; set; }
        
    }
}