using Microsoft.EntityFrameworkCore;

namespace Net.MemberAPI.Models
{
    public class MemberContext : DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; } = null!;
    }
}
