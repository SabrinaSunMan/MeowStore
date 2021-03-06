using StoreDB.Model.Partials;

namespace StoreDB.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoreDBContext : DbContext
    {
        public StoreDBContext()
            : base("name=StoreEF")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }

        //public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<NLog_Error> Nlog_Error { get; set; }
        public virtual DbSet<MenuTreeRoot> MenuTreeRoot { get; set; }
        public virtual DbSet<MenuTree> MenuTree { get; set; }
        public virtual DbSet<MenuSideList> MenuSideList { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<PictureInfo> PictureInfo { get; set; }
        public virtual DbSet<StaticHtml> StaticHtml { get; set; }
        public virtual DbSet<HtmlSubject> HtmlSubject { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Addresses)
                .HasForeignKey(e => e.addressInfo_AddressID);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);
        }
    }
}