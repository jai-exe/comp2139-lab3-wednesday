using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comp2139_lab3_wednesday.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {  }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family"},
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactId = 1, 
                    Firstname = "Bruce", 
                    Lastname = "Wayne", 
                    Phone = "416-123-1564", 
                    Email = "bruce.wayne@domain.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    Firstname = "Peter",
                    Lastname = "Parker",
                    Phone = "416-123-9785",
                    Email = "peter.parker@domain.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    Firstname = "Diana",
                    Lastname = "Prince",
                    Phone = "416-123-7501",
                    Email = "diana.prince@domain.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                }

            );



        }



    }
}
