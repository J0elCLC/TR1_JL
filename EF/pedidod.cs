//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedidod
    {
        public int id_pedido { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> horario { get; set; }
        public Nullable<bool> activo { get; set; }
    
        public virtual producto producto { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
