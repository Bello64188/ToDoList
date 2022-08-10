using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Model;

namespace ToDoAPI.Configuration
{
    public class StudentSeedsConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Bello",
                    LastName = "Azeez",
                    DateOfBirth = DateTime.Now,
                    Gender = "male"
                },
                 new Student
                 {
                     Id = 2,
                     FirstName = "Bolaji",
                     LastName = "Kola",
                     DateOfBirth = DateTime.Now,
                     Gender = "male"
                 },
                  new Student
                  {
                      Id = 3,
                      FirstName = "Maryam",
                      LastName = "Atinuke",
                      DateOfBirth = DateTime.Now,
                      Gender = "female"
                  },
                   new Student
                   {
                       Id = 4,
                       FirstName = "John",
                       LastName = "Deji",
                       DateOfBirth = DateTime.Now,
                       Gender = "male"
                   }
                );
        }
    }
}
