using MagicVilla_VillaAPI.Repository.IRepository;
using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>,IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }      

        

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);            
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
