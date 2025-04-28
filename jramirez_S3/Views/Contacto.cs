using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jramirez_S3.Views
{
    public class Contacto
    {
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public double Salario { get; set; }
    
    public double CalcularAporteIESS()
        {
            return Salario * 0.0945;
        }

}


}