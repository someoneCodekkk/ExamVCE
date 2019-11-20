namespace TestAdminServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PassExam")]
    public partial class PassExam
    {
        public int ID { get; set; }

        public int Id_Test { get; set; }

        public int Id_Student { get; set; }

        public int Mark { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Pass { get; set; }

        public int? Id_Sender { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Student Student { get; set; }

        public virtual TestDB TestDB { get; set; }
    }
}
