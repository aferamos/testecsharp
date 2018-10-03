using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Matamata.Models
{
    public class CopaContext: DbContext
    {
        public CopaContext():base("MyDB")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public System.Data.Entity.DbSet<Matamata.Models.Quarta> Quartas { get; set; }

        public System.Data.Entity.DbSet<Matamata.Models.Semi> Semis { get; set; }

        public System.Data.Entity.DbSet<Matamata.Models.Final> Finals { get; set; }
    }
}