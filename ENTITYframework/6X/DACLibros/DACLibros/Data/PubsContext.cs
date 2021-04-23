using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DACLibros.Data
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
            : base("name=PubsContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_fname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_name)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.country)
                .IsUnicode(false);
        }
    }
}
