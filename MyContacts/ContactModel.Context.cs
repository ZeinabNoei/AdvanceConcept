﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyContacts
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MvcShopEntities : DbContext
    {
        public MvcShopEntities()
            : base("name=MvcShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BaseSalaries> BaseSalaries { get; set; }
        public virtual DbSet<Mounts> Mounts { get; set; }
        public virtual DbSet<MyContacts> MyContacts { get; set; }
        public virtual DbSet<Personels> Personels { get; set; }
        public virtual DbSet<Salaries> Salaries { get; set; }
        public virtual DbSet<Years> Years { get; set; }
    }
}
