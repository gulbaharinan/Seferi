//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seferi.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guzergahlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guzergahlar()
        {
            this.GuzergahDuraklaris = new HashSet<GuzergahDuraklari>();
            this.Seferlers = new HashSet<Seferler>();
        }
    
        public int GuzergahID { get; set; }
        public string GuzergahAdi { get; set; }
        public string Aciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuzergahDuraklari> GuzergahDuraklaris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seferler> Seferlers { get; set; }
    }
}
