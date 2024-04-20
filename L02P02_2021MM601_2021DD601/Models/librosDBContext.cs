using Microsoft.EntityFrameworkCore;

namespace L02P02_2021MM601_2021DD601.Models
{
    public class librosDBContext : DbContext
    {
        public librosDBContext(DbContextOptions options) : base (options) { }

    }

}
