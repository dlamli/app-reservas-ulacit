//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiSegura.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sesion
    {
        public int SES_CODIGO { get; set; }
        public int USU_CODIGO { get; set; }
        public System.DateTime SES_FEC_HORA_INICIO { get; set; }
        public System.DateTime SES_FEC_HORA_FIN { get; set; }
        public string SES_ESTADO { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
