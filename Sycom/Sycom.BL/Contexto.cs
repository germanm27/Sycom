using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sycom.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("SycomDB")
        {

        }

        public DbSet<Producto> Productos { get; set; }
    }
}
