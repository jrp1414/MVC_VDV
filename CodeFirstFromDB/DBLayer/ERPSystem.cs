namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ERPSystem : DbContext
    {
        public ERPSystem()
            : base("name=ERPSystem")
        {
        }

        public virtual DbSet<BankData> BankDatas { get; set; }
        public virtual DbSet<BookMaster> BookMasters { get; set; }
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual DbSet<DesignationMaster> DesignationMasters { get; set; }
        public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public virtual DbSet<ExpenseMaster> ExpenseMasters { get; set; }
        public virtual DbSet<FitnessMaster> FitnessMasters { get; set; }
        public virtual DbSet<InventoryMaster> InventoryMasters { get; set; }
        public virtual DbSet<LibraryMaster> LibraryMasters { get; set; }
        public virtual DbSet<NewUser> NewUsers { get; set; }
        public virtual DbSet<PublisherMaster> PublisherMasters { get; set; }
        public virtual DbSet<SecurityQuestionMaster> SecurityQuestionMasters { get; set; }
        public virtual DbSet<StudentMaster> StudentMasters { get; set; }
        public virtual DbSet<TransactionMaster> TransactionMasters { get; set; }
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DesignationMaster>()
                .HasMany(e => e.EmployeeMasters)
                .WithRequired(e => e.DesignationMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DesignationMaster>()
                .HasMany(e => e.PublisherMasters)
                .WithRequired(e => e.DesignationMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExpenseMaster>()
                .Property(e => e.CostCenter)
                .IsFixedLength();

            modelBuilder.Entity<InventoryMaster>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SecurityQuestionMaster>()
                .HasMany(e => e.EmployeeMasters)
                .WithRequired(e => e.SecurityQuestionMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentMaster>()
                .Property(e => e.Class)
                .IsFixedLength();
        }
    }
}
