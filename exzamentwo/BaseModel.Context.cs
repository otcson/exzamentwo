﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exzamentwo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class exzamenEntities : DbContext
    {
        private static exzamenEntities _context;
        public static exzamenEntities GetContext()
        {
            if (_context == null)
                _context = new exzamenEntities();
            return _context;
        }
        public exzamenEntities()
            : base("name=exzamenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Access> Access { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PointProduct> PointProduct { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<StructureOrder> StructureOrder { get; set; }
    }
}
