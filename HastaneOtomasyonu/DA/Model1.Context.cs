﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HastaneOtomasyonuEntities : DbContext
    {
        public HastaneOtomasyonuEntities()
            : base("name=HastaneOtomasyonuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brans> Brans { get; set; }
        public virtual DbSet<Doktor> Doktor { get; set; }
        public virtual DbSet<Hasta> Hasta { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}