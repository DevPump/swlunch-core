using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace swlunch.data
{
    public partial class lunchContext : DbContext
    {
        public lunchContext()
        {
        }

        public lunchContext(DbContextOptions<lunchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Lunchchoices> Lunchchoices { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<Weekchoices> Weekchoices { get; set; }

        // Unable to generate entity type for table 'public.sessions'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseNpgsql(optionsBuilder.);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lunchchoices>(entity =>
            {
                entity.ToTable("lunchchoices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dictatorchoice).HasColumnName("dictatorchoice");

                entity.Property(e => e.Userchoice).HasColumnName("userchoice");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Weekdate)
                    .HasColumnName("weekdate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.ToTable("people");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Personauthtoken)
                    .IsRequired()
                    .HasColumnName("personauthtoken")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Personemail)
                    .IsRequired()
                    .HasColumnName("personemail")
                    .HasColumnType("character varying(45)");

                entity.Property(e => e.Personname)
                    .IsRequired()
                    .HasColumnName("personname")
                    .HasColumnType("character varying(45)");
            });

            modelBuilder.Entity<Restaurants>(entity =>
            {
                entity.ToTable("restaurants");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Restaurant)
                    .IsRequired()
                    .HasColumnName("restaurant")
                    .HasColumnType("character varying(25)");
            });

            modelBuilder.Entity<Weekchoices>(entity =>
            {
                entity.ToTable("weekchoices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Choicenum).HasColumnName("choicenum");

                entity.Property(e => e.Choiceweek)
                    .HasColumnName("choiceweek")
                    .HasColumnType("date");

                entity.Property(e => e.Usernum).HasColumnName("usernum");
            });
        }
    }
}
