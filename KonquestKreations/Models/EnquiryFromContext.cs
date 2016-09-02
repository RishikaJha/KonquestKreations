using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonquestKreations.Models
{
    class EnquiryFromContext : DbContext
    {
        public EnquiryFromContext() : base("name=EnquiryFormDBConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<EnquiryFormEntry> EnquiryFormEntries { get; set; }
    }
}
