using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name="Royal Villa",
                    Details="lorem ispum",
                    ImageUrl= "https://media.istockphoto.com/id/506903162/photo/luxurious-villa-with-pool.jpg?b=1&s=612x612&w=0&k=20&c=vcCQ5L9Tt2ZurwFhtodR6njSUnMsEn_ZqEmsa0hs9lM=",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity="",
                    CreatedDate= DateTime.Now,
                    UpdatedDate= DateTime.Now,
                }
                );

        }

    }
}
