//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doktor()
        {
            this.Randevu = new HashSet<Randevu>();
        }
    
        public int Id { get; set; }
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string DoktorTc { get; set; }
        public string DoktorTelefon { get; set; }
        public int BransId { get; set; }
    
        public virtual Brans Brans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevu { get; set; }

        public override string ToString()
        {
            return DoktorAd+" "+DoktorSoyad;
        }
    }
}
