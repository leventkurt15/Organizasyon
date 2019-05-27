namespace Organizasyon.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesaj")]
    public partial class Mesaj
    {
        public int MesajId { get; set; }

        [Column("Mesaj")]
        public string Mesaj1 { get; set; }

        public int? GonderenId { get; set; }

        public int? AlıcıId { get; set; }

        public virtual Login Login { get; set; }

        public virtual Login Login1 { get; set; }
    }
}
