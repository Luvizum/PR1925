﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR1925.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AuthorizationEntities : DbContext
    {
        public AuthorizationEntities()
            : base("name=AuthorizationEntities")
        {
        }
        public static AuthorizationEntities GetEntities()
        {
            AuthorizationEntities authorizationEntities = new AuthorizationEntities();
            return authorizationEntities;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersType> UsersTypes { get; set; }
    }
}
