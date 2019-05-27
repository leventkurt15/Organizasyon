namespace Organizasyon.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categori")]
    public partial class Categori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categori()
        {
            Organizasyon = new HashSet<Organizasyon>();
        }

        public int CategoriId { get; set; }

        [StringLength(50)]
        public string CategoriAdı { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organizasyon> Organizasyon { get; set; }
    }
}
