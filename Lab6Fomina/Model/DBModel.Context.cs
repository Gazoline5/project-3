﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab6Fomina.Model;
using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dfominaEntities : DbContext
    {
        public dfominaEntities()
            : base("name=dfominaEntities")
        {
        }

        private static dfominaEntities context;
        public static dfominaEntities GetContext()
        {
            if (context == null)
                context = new dfominaEntities();

            return context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SecretQuestion> SecretQuestion { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }

