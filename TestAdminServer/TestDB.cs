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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestDB()
        {
            PassExams = new HashSet<PassExam>();
        }

        public int ID { get; set; }

        public int IdFromPerson { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Test { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLoad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassExam> PassExams { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
