//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiCEM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notas
    {
        public int idNota { get; set; }
        public double calificacion { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> numeral { get; set; }
        public Nullable<int> idUsuarioFK { get; set; }
        public Nullable<int> idProgramaEstudiosFK { get; set; }
    
        public  Usuario Usuario { get; set; }
    }
}
