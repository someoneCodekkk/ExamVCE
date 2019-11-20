namespace TestAdminServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            PassExams = new HashSet<PassExam>();
            TestDBs = new HashSet<TestDB>();
        }

        public int ID { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirthday { get; set; }

        [Required]
        [StringLength(255)]
        public string Profesion { get; set; }

        [Required]
        [StringLength(255)]
        public string Login { get; set; }

        [Required]
        [StringLength(1024)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassExam> PassExams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestDB> TestDBs { get; set; }
    }
}
