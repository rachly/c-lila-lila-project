﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LilelileEntities : DbContext
    {
        public LilelileEntities()
            : base("name=LilelileEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<TypeProduct> TypeProduct { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
