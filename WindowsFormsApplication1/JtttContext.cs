using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class JtttContext : DbContext
    {
        public DbSet<MyTask> MyTasks { get; set; }
    }
}
