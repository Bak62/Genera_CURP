//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Genera_CURP
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPersona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public System.DateTime fnacimiento { get; set; }
        public string sexo { get; set; }
        public int edonac { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public int edoact { get; set; }
        public string delact { get; set; }
        public string colact { get; set; }
        public string calleact { get; set; }
        public string numact { get; set; }
    
        public virtual tbEstado tbEstado { get; set; }
        public virtual tbEstado tbEstado1 { get; set; }
    }
}
