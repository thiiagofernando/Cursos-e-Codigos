//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnTheLine.Models.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Foto
    {
        public int FotoID { get; set; }
        public string Descricao { get; set; }
        public string Caminho { get; set; }
        public int AlbumID { get; set; }
    
        public virtual Album Album { get; set; }
    }
}
