namespace TestAdminServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestDB")]
    public partial class TestDB
    {
        public int ID { get; set; }

        public int IdFromPerson { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Test { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLoad { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
