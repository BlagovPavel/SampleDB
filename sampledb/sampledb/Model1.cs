namespace sampledb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Form3> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Works_on> Works_on { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form3>()
                .Property(e => e.Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Form3>()
                .Property(e => e.DepartmentName)
                .IsFixedLength();

            modelBuilder.Entity<Form3>()
                .Property(e => e.Location)
                .IsFixedLength();

            modelBuilder.Entity<Form3>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DepartamentNumber);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.DepartamentNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Works_on)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmpId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.ProjectName)
                .IsFixedLength();

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Works_on)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Works_on>()
                .Property(e => e.ProjectNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Works_on>()
                .Property(e => e.Job)
                .IsFixedLength();
        }
    }
}
