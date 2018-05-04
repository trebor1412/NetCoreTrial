using Microsoft.EntityFrameworkCore;

namespace NetCore.NorthWind.Repository
{
    public partial class NorthWindContext
    {
        public NorthWindContext(DbContextOptions<NorthWindContext> options) : base(options)
        {
        }
    }
}