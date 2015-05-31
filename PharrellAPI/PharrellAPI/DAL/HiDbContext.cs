using SocialData.Plugins.Twitter;
using Spatial;

namespace PharrellAPI.DAL
{
    using System.Data.Entity;

    public class HiDbContext : DbContext
    {
        public HiDbContext()
            : base("name=HiDbContext")
        {
        }

        public virtual DbSet<Tweet> Tweets { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
    }
}