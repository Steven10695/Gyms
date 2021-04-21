using Microsoft.EntityFrameworkCore;
using gym.Models;

namespace gym.Data
{
    public class GymContext : DbContext
    {
        public DbSet<Gym> Gyms { get; set; }

        public GymContext(DbContextOptions dco) : base(dco) {

        }
    }
}