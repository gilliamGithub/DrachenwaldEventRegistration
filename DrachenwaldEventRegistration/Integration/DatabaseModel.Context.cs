﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrachenwaldEventRegistration.Integration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EventRegistrationDBEntities : DbContext
    {
        public EventRegistrationDBEntities()
            : base("name=EventRegistrationDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<FormItem> FormItem { get; set; }
        public virtual DbSet<FormItemTemplate> FormItemTemplate { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<RegistrationForm> RegistrationForm { get; set; }
        public virtual DbSet<RegistrationFormLayout> RegistrationFormLayout { get; set; }
        public virtual DbSet<RegistrationFormLayoutTemplate> RegistrationFormLayoutTemplate { get; set; }
        public virtual DbSet<RegistrationFormTemplate> RegistrationFormTemplate { get; set; }
    }
}
