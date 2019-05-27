namespace Organizasyon.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organizasyon")]
    public partial class Organizasyon
    {
        public int OrganizasyonId { get; set; }

        [StringLength(50)]
        public string OrganizasyonAdı { get; set; }

        public DateTime? Tarihi { get; set; }

        public DateTime? BaşvuruTarihi { get; set; }

        public int? KatilimciSayisi { get; set; }

        public string Resim { get; set; }

        public int? OrganizatorId { get; set; }

        public int? CategoriId { get; set; }

        public virtual Categori Categori { get; set; }
    }
}
