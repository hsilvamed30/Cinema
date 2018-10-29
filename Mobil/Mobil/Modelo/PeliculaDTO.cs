using System;
using System.Collections.Generic;
using System.Text;

namespace Mobil.Modelo
{
    public class PeliculaDTO
    { 
            public string Nombre { get; set; }
            public DateTime FechaEstreno { get; set; }
            public string Genero { get; set; }
            public string Recomendacion { get; set; }
            public int Duracion { get; set; }
            public string Imagen { get; set; }
            public Funcione[] Funciones { get; set; }


        public class Funcione
        {
            public string Cinema { get; set; }
            public string Sala { get; set; }
            public string Ciudad { get; set; }
            public int Precio { get; set; }
        }

    }
}
