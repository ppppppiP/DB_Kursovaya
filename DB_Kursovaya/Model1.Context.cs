﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Kursovaya
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StrahovieEntities : DbContext
    {
        public StrahovieEntities()
            : base("name=StrahovieEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Isk> Isk { get; set; }
        public virtual DbSet<Strahovie_Companii> Strahovie_Companii { get; set; }
        public virtual DbSet<Strahovie_Polici> Strahovie_Polici { get; set; }
    }
}
