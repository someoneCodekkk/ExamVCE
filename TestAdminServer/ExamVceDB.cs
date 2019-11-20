namespace TestAdminServer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExamVceDB : DbContext
    {
        public ExamVceDB()
            : base("name=ExamVceDB")
        {
        }

        public virtual DbSet<PassExam> PassExams { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TestDB> TestDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Staff>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.PassExams)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.Id_Sender);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.TestDBs)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.IdFromPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.PassExams)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.Id_Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TestDB>()
                .HasMany(e => e.PassExams)
                .WithRequired(e => e.TestDB)
                .HasForeignKey(e => e.Id_Test)
                .WillCascadeOnDelete(false);
        }
    }
}
